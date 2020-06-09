using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CaoLendario.Models
{
    public class EFProcedimentosPreAdocaoRepositorio : IProcedimentosPreAdocaoRepositorio
    {
        private ApplicationDbContext context;

<<<<<<< Updated upstream
        public IQueryable<ProcedimentosPreAdocao> ProcedimentosPreAdocao => context.ProcedimentosPreAdocao;

=======
>>>>>>> Stashed changes
        public EFProcedimentosPreAdocaoRepositorio(ApplicationDbContext ctx)
        {
            context = ctx;
        }
<<<<<<< Updated upstream
=======

        public IQueryable<ProcedimentosPreAdocao> ProcedimentosPreAdocao => context.ProcedimentosPreAdocao
        .Include(a => a.Animal);

>>>>>>> Stashed changes
        public void Create(ProcedimentosPreAdocao procedimentosPreAdocao)
        {
            context.Add(procedimentosPreAdocao);
            context.SaveChanges();
        }

        public void Delete(ProcedimentosPreAdocao procedimentosPreAdocao)
        {
            context.Remove(procedimentosPreAdocao);
            context.SaveChanges();
        }

        public void Edit(ProcedimentosPreAdocao procedimentosPreAdocao)
        {
            context.Entry(procedimentosPreAdocao).State = EntityState.Modified;
            context.SaveChanges();
        }

        public ProcedimentosPreAdocao ObterProcedimentosPreAdocao(int id)
        {
            var procedimentosPreAdocao = context.ProcedimentosPreAdocao.Find(id);
            return procedimentosPreAdocao;
        }
    }
}

