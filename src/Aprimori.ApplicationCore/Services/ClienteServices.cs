using Aprimori.ApplicationCore.Entity;
using Aprimori.ApplicationCore.Interfaces.Repository;
using Aprimori.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Aprimori.ApplicationCore.Services
{
    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteServices(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public Cliente Adicionar(Cliente entity)
        {
            return _clienteRepository.Adicionar(entity);
        }

        public void Atualizar(Cliente entity)
        {
            _clienteRepository.Atualizar(entity);
        }

        public IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado)
        {
            return _clienteRepository.Buscar(predicado);
        }

        public Cliente ObterPorId(int id)
        {
            return _clienteRepository.ObterPorId(id);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _clienteRepository.ObterTodos();
        }

        public void Remover(Cliente entity)
        {
            _clienteRepository.Remover(entity);
        }
    }
}
