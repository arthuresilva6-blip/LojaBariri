
using System.ComponentModel.DataAnnotations;

namespace TechStoreMVC.Models;

public class Produto
{
    // Passo 01 - Criar as Modesl
    //Atributos
    public int Id {get; set;}// Gat para obiter um id = Identivicador
                            // Set para definir um novo valor, atualizar e etc.
    [Required(ErrorMessage = "Informar um nome")]
    [StringLength(
        100,
        MinimumLength = 3,
        ErrorMessage = "O nome deve possoir entre 3 e 100 caracteristicas."
    )
    ]
    public string Nome {get; set;}
    public decimal Preco {get; set;}
    public int Estoque {get; set;}

//Método Construtro - Define valores iniciais desses atributos acima!!!!!!
    public Produto (
        int id,
        string nome,
        decimal preco,
        int estoque
    )
    {
        Id = id;
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }
}
