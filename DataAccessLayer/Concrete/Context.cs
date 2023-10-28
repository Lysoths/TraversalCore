using System;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
	public class Context:DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=root;Password=root;Host=localhost;Port=5432;Database=TraversalDB;");
        }

        DbSet<About> Abouts { get; set; }
        DbSet<About2> Abouts2 { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<Destination> Destinations { get; set; }
        DbSet<Feature> Features { get; set; }
        DbSet<Feature2> Features2 { get; set; }
        DbSet<Guide> Guides { get; set; }
        DbSet<Newsletter> Newsletters { get; set; }
        DbSet<SubAbout> SubAbouts { get; set; }
        DbSet<Testimonial> Testimonials { get; set; }

    }
}

