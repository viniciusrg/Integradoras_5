using CaoLendario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaoLendario.Controllers
{
	public class AdotanteController
	{
        private ApplicationDbContext context;

        public AdotanteController(IAdotanteRepositorio repo, ApplicationDbContext ctx)
        {
            repositorio = repo;
            context = ctx;
        }

        //Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var adotante = context.Adotantes.Find(id);
            ViewBag.AdotanteId = new SelectList(context.Adotantes.OrderBy(f
           => f.Nome), "AdotanteID", "Nome");
            return View(adotante);
        }
        [HttpPost]
        public IActionResult Edit(Adotante adotante)
        {
            repositorio.Edit(adotante);
            return RedirectToAction("List");
        }


        //Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var adotante = repositorio.ObterAdotante(id);
            return View(adotante);
        }
        [HttpPost]
        public IActionResult Delete(AdotanteControler adotante)
        {
            repositorio.Delete(adotante);
            return RedirectToAction("List");
        }


        //Consulta
        [HttpGet]
        public IActionResult New()
        {
            ViewBag.UserID = new SelectList(context.Adotante.OrderBy(a => a.Nome), "UserID", "nome");
            return View();
        }
    }
}
