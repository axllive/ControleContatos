using ControleContatos.Data;
using ControleContatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleContatos.Repositorio
{
    public class RpoContato : IRepoContato
    {
        private readonly BancoContext _bancoContext;
        public RpoContato(BancoContext bcoContext) {
            _bancoContext = bcoContext;
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public List<ContatoModel> Consultar()
        {
            return _bancoContext.Contatos.ToList();
        }

        public ContatoModel ConsultarUm(Int64 cpf)
        {
            ContatoModel c = _bancoContext.Contatos.Find(cpf);
            List<ContatoModel> ad = new List<ContatoModel>();
            ad.Add(c);
            return c;
        }

        public List<ContatoModel> ConsultarUmL(long cpf)
        {
            ContatoModel c = _bancoContext.Contatos.Find(cpf);
            List<ContatoModel> ad = new List<ContatoModel>();
            ad.Add(c);
            return ad;
        }

        public ContatoModel Editar(ContatoModel contato) { 
            ContatoModel edit = _bancoContext.Contatos.Find(contato.cpf);
            _bancoContext.Entry(edit).CurrentValues.SetValues(contato);
            _bancoContext.SaveChanges();
            return edit;
        }

        public ContatoModel Excluir(ContatoModel contato)
        {
            _bancoContext.Contatos.Remove(_bancoContext.Contatos.Find(contato.cpf));
            _bancoContext.SaveChanges();
            return null;
        }
    }
}
