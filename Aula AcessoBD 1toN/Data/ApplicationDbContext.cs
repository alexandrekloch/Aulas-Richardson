using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Aula_AcessoBD_1toN.Models;

namespace Aula_AcessoBD_1toN.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Aula_AcessoBD_1toN.Models.Veiculo> Veiculo { get; set; }
        public DbSet<Aula_AcessoBD_1toN.Models.Pessoa> Pessoa { get; set; }
    }
}
