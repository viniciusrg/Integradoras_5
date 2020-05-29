using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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


        public void Create(User user)
        {
            context.Add(user);
            context.SaveChanges();
        }
        public Adotante ObterAdotante(int id)
        {
            var user = context.Users
            .Include(f => f.Fabricante)
           .FirstOrDefault(p => p.ProdutoID == id);
            return user;
        }
        public void Edit(User user)
        {
            context.Entry(user).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Delete(User user)
        {
            context.Remove(user);
            context.SaveChanges();
        }
    }
}
