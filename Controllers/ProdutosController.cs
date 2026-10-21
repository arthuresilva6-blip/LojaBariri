using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using TechStoreMVC.Models;

namespace TechStoreMVC.Controllers
{
    public class ProdutosController : Controller // o ":" significa herança
    //Herança = herança as caracteristicas de um Controller. :)
    //Conceito de POO -> Programação Orientada a Objetos
    {
        private readonly ProdutosDB _produtosDB;
        public ProdutosController()
        {
            _produtosDB = new ProdutosDB();
        }


        // Passo 02 - Criar a açãp  
        // Uma view depende de uma ação e vice-versa
        [HttpGet]
        public ActionResult Index()
        {
            List<Produto> produtos = _produtosDB.Listar();
            return View(produtos);

        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            Produto? produto = _produtosDB.buscarPorId(id);
            if (produto is null)
                return NotFound();
            return View(produto);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Produto produto)
        {
            if (ModelState.IsValid)
                return View(produto);

            _produtosDB.Adicionor(produto);
            TempData["Sucesso"] =
                "Produto cadastrado com sucesso!";
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Produto? produto = _produtosDB.buscarPorId(id);
            if (produto is null)
                return NotFound();
            return View(produto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Produto produto, int id)
        {
            if (id != produto.Id)
                return BadRequest();

            if (ModelState.IsValid)
                return View(produto);
            
            bool atualizou = _produtosDB.Atualizar(produto);

            TempData["Sucesso"] =
                "Produto atualizado com sucesso!";
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Produto? produto = _produtosDB.buscarPorId(id);
            if (produto is null)
                return NotFound();
            return View(produto);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Produto produto, int id)
        {
           
            
            bool excluir = _produtosDB.Excluir(id);
            if(!excluir)
                return NotFound();

            TempData["Sucesso"] =
                "Produto atualizado com sucesso!";

            return RedirectToAction(nameof(Index));
        }
    }
}
