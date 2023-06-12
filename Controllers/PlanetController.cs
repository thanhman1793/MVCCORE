using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Models;
using MVC.Services;

namespace MVC.Controllers
{
    public class PlanetController : Controller
    {
        private readonly ILogger<PlanetController> _logger;
        private readonly PlanetService _planetService;

        public PlanetController(ILogger<PlanetController> logger, PlanetService planetService)
        {
            _logger = logger;
            _planetService = planetService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [BindProperty(SupportsGet = true, Name = "action")]
        public string Name { get; set; }
        public IActionResult Mercury()
        {
            var planet = _planetService.Where(x => x.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }

        [Route("hanhtinh/{id:int}")]
         public IActionResult PlanetInfo(int id)
        {
            var planet = _planetService.Where(x => x.Id == id).FirstOrDefault();
            return View("Detail", planet);
        }

    }

}
