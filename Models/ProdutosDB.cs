namespace TechStoreMVC.Models;

public class ProdutosDB
{   
    //Passo 01 - Criar/trazer os dados de produtos do controler 
    //metodo que vai listar novos objetivos de um produto
    //e armazená-los na variável produtos
    private static readonly List<Produto> produtos = new()
    {
              new Produto (1, "Mouse Gamer", 129.9m, 10),
              new Produto (2, "Teclado Mecânico", 249.9m, 5),
              new Produto (1, "Mônitor 24 polegadas", 899.9m, 8),
              new Produto (1, "Headset Gamer", 179.9m, 15)  
    };
    //Passo 02 - Criar os métodos do CRUD e remover toda regra de nagócio do Controll
    //Responsabilidade  do Listar: Desenvolver/mostrar os prodotos. Igal ao Index
    public List<Produto> Listar()
    {
        return produtos;
    }
    public Produto? buscarPorId(int Id)
    {
        return produtos.FirstOrDefault(
            produto => produto.Id == Id
        );
    }
    public void Adicionor(Produto produto)
    {
        produto.Id = produtos.Count + 1;
        produtos.Add(produto);
    }
    public bool Atualizar(Produto ProdutoAtualizado)
    {
        Produto? produtoExistente = 
            buscarPorId(ProdutoAtualizado.Id);

            if(produtoExistente is null)
                return false;
            
            produtoExistente.Nome = ProdutoAtualizado.Nome;
            produtoExistente.Preco = ProdutoAtualizado.Preco;
            produtoExistente.Estoque = ProdutoAtualizado.Estoque;
            return true;
    }

    public bool Excluir(int id)
    {
        Produto? produto = buscarPorId(id);
            if(produto is null)
                    return false;
            produtos.Remove(produto);

            return true;
    }
}