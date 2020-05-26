using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaoLendario.Models
{
    public interface IProcedimentosPosAdocaoRepositorio
    {
        IQueryable<ProcedimentosPosAdocao> ProcedimentosPosAdocao { get; }
        public void Create(ProcedimentosPosAdocao procedimentosPosAdocao);
        public ProcedimentosPosAdocao ObterProcedimentosPosAdocao(int id);
        public void Edit(ProcedimentosPosAdocao procedimentosPosAdocao);
        public void Delete(ProcedimentosPosAdocao procedimentosPosAdocao);
    }
}
