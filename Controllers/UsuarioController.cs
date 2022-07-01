using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Atividade_2.Models;

namespace Atividade_2.Controllers
{
    public class UsuarioController : Controller
    {

        public IActionResult Login()
        {

            return View();

        }

        [HttpPost]
        public IActionResult Login(Usuario usuario)
        {

            UsuarioRepository ur = new UsuarioRepository();
            Usuario usuarioSessao = ur.ValidarLogin(usuario);

            if (usuarioSessao == null)
            {
                
                ViewBag.mensagem = "Login ou Senha Incorretos!!!";
                return View();
            }
            else
            {
             
                ViewBag.mensagem = "Logado com Sucesso!!!";

                
                HttpContext.Session.SetInt32("IdUsuario", usuarioSessao.Id);
                HttpContext.Session.SetString("NomeUsuario", usuarioSessao.Nome);

                return View();
            }
        }

        public IActionResult Logout()
        {

            HttpContext.Session.Clear();
            return View("Login");
        }

        public IActionResult Lista(int Id)
        {

            /*if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }*/

            UsuarioRepository ur = new UsuarioRepository();
            return View(ur.Listar(Id));

        }

        public IActionResult Excluir(int Id)
        {

            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Index", "Home");
            }

            UsuarioRepository ur = new UsuarioRepository();
            Usuario cliente = ur.BuscarPorId(Id);

            ur.Remover(cliente);

            return RedirectToAction("Lista");
        }

        public IActionResult Cadastrar()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario user)
        {

            UsuarioRepository ur = new UsuarioRepository();
            ur.Inserir(user);

            ViewData["mensagem"] = "Cadastro realizado com sucesso";
            return View();
        }

        public IActionResult Refazer(int Id)
        {

            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }

            UsuarioRepository ur = new UsuarioRepository();
            Usuario UsuarioEncontrado = ur.BuscarPorId(Id);

            return View(UsuarioEncontrado);
        }
        [HttpPost]
        public IActionResult Refazer(Usuario user)
        {

            UsuarioRepository ur = new UsuarioRepository();
            ur.Atualizar(user);

            ViewData["mensagem"] = "Usuario modificado com sucesso!!!";
            return RedirectToAction("Lista");
        }
    }
}