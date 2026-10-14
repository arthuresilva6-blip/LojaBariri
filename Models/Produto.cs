using System;

namespace TechStoreMVC.Models;

public class Produto
{
    // Passo 01 - Criar as Modesl
    //Atributos
    public int Id {get; set;}// Gat para obiter um id = Identivicador
                            // Set para definir um novo valor, atualizar e etc.
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
