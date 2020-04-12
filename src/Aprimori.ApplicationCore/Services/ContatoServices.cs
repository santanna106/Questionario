using Aprimori.ApplicationCore.Entity;
using Aprimori.ApplicationCore.Interfaces.Repository;
using Aprimori.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Aprimori.ApplicationCore.Services
{
    public class ContatoServices : IContatoServices
    {
        private readonly IContatoRepository _contatoRepository;
        public ContatoServices(IContatoRepository ContatoRepository)
        {
            _contatoRepository = ContatoRepository;
        }
        public Contato Adicionar(Contato entity)
        {
            return _contatoRepository.Adicionar(entity);
        }

        public void Atualizar(Contato entity)
        {
            _contatoRepository.Atualizar(entity);
        }

        public IEnumerable<Contato> Buscar(Expression<Func<Contato, bool>> predicado)
        {
            return _contatoRepository.Buscar(predicado);
        }

        public Contato ObterPorId(int id)
        {
            return _contatoRepository.ObterPorId(id);
        }

        public IEnumerable<Contato> ObterTodos()
        {
            return _contatoRepository.ObterTodos();
        }

        public void Remover(Contato entity)
        {
            _contatoRepository.Remover(entity);
        }
    }
}
