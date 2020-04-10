using Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio
{
    public interface IProdutoRepository
    {
        void Adicionar(Produto produto);
        void Salvar(Produto produto);
        IEnumerable<Produto> ListarTodos();
        Produto BuscarPor(int idProduto);
    }
}
