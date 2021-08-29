using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace formulariomatalu.Data
{
    public class ApplicationDbContext:IdentityDbContext
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
        : base(options)
        {

        }

        public DbSet<formulariomatalu.Models.Registro> DataRegistros { get; set;} 
    }
}