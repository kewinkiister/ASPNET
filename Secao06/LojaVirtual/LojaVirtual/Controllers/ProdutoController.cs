using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Visualiza() 
        {
            return new ContentResult() { Content = "<h3>Produto -> Visualizar</h3>", ContentType = "text/html" }; 
        }

    }
}
