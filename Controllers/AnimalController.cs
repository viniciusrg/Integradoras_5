using CaoLendario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaoLendario.Controllers
{
    public class AnimalControllers
    {
        private ApplicationDbContext context;

        public AnimalController(IAnimalRepositorio repo, ApplicationDbContext ctx)
        {
            repositorio = repo;
            context = ctx;
        }
    }
}
