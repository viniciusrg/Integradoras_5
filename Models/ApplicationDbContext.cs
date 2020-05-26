using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace CaoLendario.Models
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { }

        public DbSet<Animal> Animais { get; set; }
        public DbSet<Interesse> Interesse { get; set; }
        public DbSet<Adotante> Adotantes { get; set; }
        public DbSet<ProcedimentoPreAdocao> ProcedimentoPreAdocao { get; set; }
        public DbSet<ProcedimentoPosAdocao> ProcedimentoPosAdocao { get; set; }
        public DbSet<MedicoVeterinario> MedicoVeterinario { get; set; }

    }
}
