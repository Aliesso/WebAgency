using K102AgencyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K102AgencyWeb.ViewModel
{
    public class HomeVM
    {
        public Section1 Section1  { get; set; }
        public SectionAbout SectionAbout { get; set; }
        public List<SectionService> SectionServices { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<Portfolio> Portofolio { get; set; }
        public List<Blog> Blog { get; set; }
    }
}
