using Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio
{
    public interface ICategoriaRepository
    {
        void Adicionar(Categoria categoria);
        void Salvar(Categoria categoria);
        IEnumerable<Categoria> ListarTodos();
        Categoria BuscarPor(int idCategoria);
    }
}
