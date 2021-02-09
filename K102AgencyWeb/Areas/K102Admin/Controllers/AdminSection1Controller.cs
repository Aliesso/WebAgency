using K102AgencyWeb.Data;
using K102AgencyWeb.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace K102AgencyWeb.Areas.K102Admin.Controllers
{
    [Area("K102Admin")]
    public class AdminSection1Controller : Controller
    {
        private readonly PortContext _context;
        private readonly IWebHostEnvironment _env;
        public AdminSection1Controller(PortContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            return View(_context.Section1.ToList());
        }
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            Section1 selectedSection=_context.Section1.FirstOrDefault(s => s.ID == id);
            return View(selectedSection);
        }
        [HttpPost]
        public IActionResult Edit(int? id,Section1 section,IFormFile Photo)
        {
            if (id == null) return NotFound();
            //Image Upload
            string imgName = Guid.NewGuid() + "_" + Photo.FileName;
            string uploadLink = Path.Combine(_env.WebRootPath, "uploads");
            string filePath = Path.Combine(uploadLink, imgName);

            using FileStream file = new FileStream(filePath,FileMode.Create);
            Photo.CopyTo(file);
            section.PhotoUrl = imgName;
            _context.Section1.Update(section);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
