using ControleContatos.Models;
using System;
using System.Collections.Generic;

namespace ControleContatos.Repositorio
{
    public interface IRepoContato
    {
        List<ContatoModel> Consultar();
        List<ContatoModel> ConsultarUmL(Int64 cpf);
        ContatoModel ConsultarUm(Int64 cpf);
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Editar(ContatoModel contato);
        ContatoModel Excluir(ContatoModel contato);
    }
}
