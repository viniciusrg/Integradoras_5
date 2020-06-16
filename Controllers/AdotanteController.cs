using CaoLendario.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaoLendario.Controllers
{
	public class AdotanteController : User
	{
        private IAdotanteRepositorio repositorio;
        private ApplicationDbContext context;

        public object ViewBag { get; private set; }

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
            ViewBag.UserID = new SelectList(context.Adotantes.OrderBy(f
           => f.Nome), "UserID", "Nome");
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
        public IActionResult Delete(AdotanteController adotante)
        {
            repositorio.Delete(adotante);
            return RedirectToAction("List");
        }


        //Consulta
        [HttpGet]
        public IActionResult New()
        {
            ViewBag.UserID = new SelectList(context.Adotantes.OrderBy(a => a.Nome), "UserID", "nome");
            return View();
        }

        //Create
        [HttpGet]
        public IActionResult New()
        {
            ViewBag.UserID = new SelectList(context.Adotantes.OrderBy(f => f.Nome), "UserID", "Nome");
            return View();
        }
        [HttpPost]
        public IActionResult New(Adotante adotante)
        {
            repositorio.Create(adotante);
            return RedirectToAction("List");
        }
    }
}
