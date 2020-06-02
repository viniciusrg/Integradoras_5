using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaoLendario.Models
{
    interface IInteresseRepositorio
    {
        IQueryable<Interesse> Interesses { get; }

        public void Create(Interesse interesse);
        public Interesse ObterInteresse(int id);
        public void Edit(Interesse interesse);
        public void Delete(Interesse interesse);
    }
}
