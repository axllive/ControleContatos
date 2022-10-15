using ControleContatos.Models;
using ControleContatos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;

namespace ControleContatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IRepoContato _repoContato;
        public ContatoController(IRepoContato repoContato)
        {
            _repoContato = repoContato;
        }
        public IActionResult Index()
        {
            List<ContatoModel> contatos = _repoContato.Consultar();
            return View(contatos);
        }
        public IActionResult Consultar(ContatoModel c) {
            ContatoModel res = _repoContato.ConsultarUm(c.cpf);
            return View(res);
        }
        public IActionResult Adicionar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Adicionar(ContatoModel contato) {
            _repoContato.Adicionar(contato);
            return RedirectToAction("Index");
        }
        public IActionResult Alterar(Int64 cpf)
        {
            ContatoModel res = _repoContato.ConsultarUm(cpf);
            return View(res);
        }
        [HttpPost]
        public IActionResult Alterar(ContatoModel contato) {
            _repoContato.Editar(contato);
            return RedirectToAction("Index");
        }

        public IActionResult Excluir(Int64 cpf)
        {
            ContatoModel res = _repoContato.ConsultarUm(cpf);
            return View(res);
        }
        [HttpPost]
        public IActionResult Excluir(ContatoModel contato) {
            _repoContato.Excluir(contato);
            return RedirectToAction("Index");
        }
    }
}
