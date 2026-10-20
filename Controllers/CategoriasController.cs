using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using TechStoreMVC.Models;

public class CategoriasController : Controller
{
    public ActionResult Index()
    {
        List<Categoria> categorias = new List<Categoria>
        {
            new Categoria (1,"Informática", "Computadores e compoenntes", true),
            new Categoria (2,"Períféricos", "Mouse, teclado e acessórios", true),
            new Categoria (3,"Áudio", "Fones, caixas e microfones", true),
            new Categoria (4,"onitores", "Telas e munitores", true),
            new Categoria (5,"Descontinuados", "Categoria fora de uso", false),
        };

        return View(categorias);
    }
}
