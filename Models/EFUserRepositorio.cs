using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaoLendario.Models
{
	public class EFUserRepositorio
	{
        private ApplicationDbContext context;

        public EFUserRepositorio(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<User> Users => context.Adotantes;


    }
}
