using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using TechStoreMVC.Models;

namespace TechStoreMVC.Controllers
{
    public class ProdutosController : Controller // o ":" significa herança
    //Herança = herança as caracteristicas de um Controller. :)
    //Conceito de POO -> Programação Orientada a Objetos
    {
        // GET: ProdutosController

        // Passo 02 - Criar a açãp  
        // Uma view depende de uma ação e vice-versa
        public ActionResult Index()
        {
            List<Produto> produtos = new List<Produto>
            {
              new Produto (1, "Mouse Gamer", 129.9m, 10),
              new Produto (2, "Teclado Mecânico", 249.9m, 5),
              new Produto (1, "Mônitor 24 polegadas", 899.9m, 8),
              new Produto (1, "Headset Gamer", 179.9m, 15)
            };
            return View(produtos);

        }

    }
}
