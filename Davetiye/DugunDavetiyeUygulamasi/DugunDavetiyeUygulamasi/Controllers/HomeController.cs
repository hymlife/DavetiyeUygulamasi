using DugunDavetiyeUygulamasi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace DugunDavetiyeUygulamasi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult CevapFormu()
        {
            return View();
        }

        [HttpPost]
        public ViewResult CevapFormu(Cevap KatilimciCevabi)
        {
            Repositery.CevapEkle(KatilimciCevabi);
            return View("Tesekkurler",KatilimciCevabi);
        }

        public ViewResult CevaplariListele()
        {
            return View(Repositery.Cevaplar.Where(x => x.DuguneGelicekmi == true));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
