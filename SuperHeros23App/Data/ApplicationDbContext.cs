using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperHeros23App.Controllers;
using SuperHeros23App.Models;

namespace SuperHeros23App.Data
{
    public class ApplicationDbContext : IdentityDbContext //class
    {
       
    
        public DbSet<SuperHero23>SuperHeros23 { get; set; } //table
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) //constructor
        {
        }
    }
}