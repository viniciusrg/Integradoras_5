using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaoLendario.Controller
{
    public class AnimalController
    {
        private ApplicationDbContext context;

        public AnimalController(IAnimalRepositorio repo, ApplicationDbContext ctx)
        {
            repositorio = repo;
            context = ctx;
        }
    }
}
