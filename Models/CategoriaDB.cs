namespace TechStoreMVC.Models;

public class CategoriaDB
{

    private static readonly List<Categoria> categorias = new()
    {
              new Categoria (1, "Informática", "mouse gamer é um periférico de computador projetado especialmente para jogos eletrônicos, oferecendo maior precisão, durabilidade, ergonomia e velocidade de resposta do que um mouse comum.", true),
              new Categoria (2, "Periféricos", " é um tipo de periférico que utiliza um interruptor físico individual (switch) sob cada tecla, em vez de usar uma camada única de borracha ou silicone como nos teclados de membrana tradicionais", false),
              new Categoria (1, "Monitores", "é um visor de computador com cerca de 60,9 cm de diagonal de tela, sendo o tamanho mais equilibrado e popular para uso geral, estudo, trabalho de escritório e jogos de entrada ou competitivos.", true),
              new Categoria (1, "Áudio", "é um conjunto de fone de ouvido robusto integrado a um microfone (fixo, retrátil ou destacável), projetado especificamente para proporcionar imersão sonora, comunicação em tempo real com equipes e conforto em longas sessões de jogos.", true)
    };

    public List<Categoria> Listar()
    {
        return categorias;
    }
    public Categoria? buscarPorId(int Id)
    {
        return categorias.FirstOrDefault(
            Categoria => Categoria.Id == Id
        );
    }
    public void Adicionar(Categoria categoria)
    {
        categoria.Id = categorias.Count + 1;
        categorias.Add(categoria);
    }
    public bool Atualizar(Categoria CategoriaAtualizado)
    {
        Categoria? categoriaExistente =
            buscarPorId(CategoriaAtualizado.Id);

        if (categoriaExistente is null)
            return false;

        categoriaExistente.Nome = CategoriaAtualizado.Nome;
        categoriaExistente.Descricao = CategoriaAtualizado.Descricao;
        categoriaExistente.Ativa = CategoriaAtualizado.Ativa;
        return true;
    }

    public bool Excluir(int id)
    {
        Categoria? categoria = buscarPorId(id);
        if (categoria is null)
            return false;
        categorias.Remove(categoria);

        return true;
    }
}