using K102AgencyWeb.Data;
using K102AgencyWeb.Models;
using K102AgencyWeb.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace K102AgencyWeb.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private PortContext _portContext;
        public HomeController(ILogger<HomeController> logger,PortContext portContext)
        {
            _portContext = portContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            HomeVM vm = new HomeVM();
            vm.Section1= _portContext.Section1.First();
            vm.SectionAbout= _portContext.SectionAbouts.First();
            vm.SectionServices = _portContext.SectionServices.ToList();
            vm.Testimonials = _portContext.Testimonials.ToList();
            vm.Portofolio = _portContext.Portfolios.ToList();
            vm.Blog = _portContext.Blogs.ToList();
            return View(vm);
        }
        public IActionResult About()
        {
            return View();
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
