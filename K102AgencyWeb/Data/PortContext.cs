using K102AgencyWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K102AgencyWeb.Data
{
    public class PortContext:DbContext
    {
        public PortContext(DbContextOptions<PortContext>options):base(options)
        {}
        public DbSet<Section1> Section1 { get; set; }     
        public DbSet<SectionAbout> SectionAbouts { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<SectionService> SectionServices { get; set; }
        public DbSet<Brands> Brands { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
