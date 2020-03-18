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

            ContatoEmail.EnviarContatoPorEmail(contato);

            return new ContentResult() { Content = string.Format("Dados recebidos com sucesso! <br/>Nome:{0} <br/>Email:{1} <br/>Texto:{2}",contato.Nome, contato.Email, contato.Texto), ContentType="text/html"  };
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