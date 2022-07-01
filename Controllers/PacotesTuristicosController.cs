using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Atividade_2.Models;
using Microsoft.AspNetCore.Http;

namespace Atividade_2.Controllers
{
    public class PacotesTuristicosController : Controller
    {
        public IActionResult ListarPacotes(int Id)
        {


            PacotesTuristicosRepository Pacotes = new PacotesTuristicosRepository();
            return View(Pacotes.ListarPcts(Id));
        }

        public IActionResult ExcluirPacotes(int Id)
        {

            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");

            }

            PacotesTuristicosRepository Pacotes = new PacotesTuristicosRepository();
            PacotesTuristicos PacotesEncontrados = Pacotes.BuscarPacotesPorId(Id);

            Pacotes.RemoverPacotes(PacotesEncontrados);

            return RedirectToAction("ListarPacotes");
        }
        public IActionResult CadastrarPacotes()
        {

            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");// retorna para açao login da controller usuario
            }

            return View();
        }

        [HttpPost]

        public IActionResult CadastrarPacotes(PacotesTuristicos Pacotes)
        {

            PacotesTuristicosRepository Packs = new PacotesTuristicosRepository();
            Packs.InserirPcts(Pacotes);

            ViewData["mensagem"] = "Pacote de viagem cadastrado com sucesso";
            return View();
        }

        public IActionResult AlterarPacotes(int pct)
        {

            if (HttpContext.Session.GetInt32("IdUsuario") != null)
            {
                PacotesTuristicosRepository pack = new PacotesTuristicosRepository();
                PacotesTuristicos PacoteEncontrado = pack.BuscarPacotesPorId(pct);

                return View(PacoteEncontrado);
            }
            return RedirectToAction("Login", "Usuario");

        }

        [HttpPost]

        public IActionResult AlterarPacotes(PacotesTuristicos Pct)
        {


            PacotesTuristicosRepository Packs = new PacotesTuristicosRepository();
            Packs.AterarPcts(Pct);

            return RedirectToAction("ListarPacotes");
        }
    }
}
