using Microsoft.EntityFrameworkCore;
using PersonalWebsite.DAL.Entities;

namespace PersonalWebsite.DAL.Context;

public class PersonalWebsiteContext: DbContext
{
    public PersonalWebsiteContext(DbContextOptions<PersonalWebsiteContext> options) : base(options) { }

    
    public DbSet<About> Abouts { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Portfolio> Portfolios { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
}
