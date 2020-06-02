using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaoLendario.Models
{
    public interface IProcedimentosPreAdocaoRepositorio
    {
        IQueryable<ProcedimentosPreAdocao> ProcedimentosPreAdocao { get; }
        public void Create(ProcedimentosPreAdocao procedimentosPreAdocao);
        public ProcedimentosPreAdocao ObterProcedimentosPreAdocao(int id);
        public void Edit(ProcedimentosPreAdocao procedimentosPreAdocao);
        public void Delete(ProcedimentosPreAdocao procedimentosPreAdocao);
    }
}
