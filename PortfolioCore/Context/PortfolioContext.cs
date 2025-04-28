using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using PortfolioCore.Entities;

namespace PortfolioCore.Context
{
    public class PortfolioContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-39MI0O0\\SQLEXPRESS;initial Catalog=portfolioNightDb;integrated security=true;");
        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Skill> skills { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Portfolio> portfolios { get; set; }
        public DbSet<SocialMedia> socialMedias { get; set; }
        public DbSet<Feature> features { get; set; }
        public DbSet<About> abouts { get; set; }
        public DbSet<Service> services { get; set; }
    }
}
//trust server certificate=true;
