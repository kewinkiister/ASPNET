using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LojaVirtual.Models;
using LojaVirtual.Libraries.Email;

namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult ContatoAcao()
        {

            Contato contato = new Contato
            {
                Nome = HttpContext.Request.Form["nome"],
                Email = HttpContext.Request.Form["email"],
                Texto = HttpContext.Request.Form["texto"]
            };

            //ContatoEmail.EnviarContatoPorEmail(contato);

            ViewData["MSG_S"] = "Mensagem de contato enviada com sucesso!";

            return View("Contato");
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult CadastroClientes()
        {
            return View();
        }

        public IActionResult CarrinhoCompras()
        {
            return View();
        }
    }
}