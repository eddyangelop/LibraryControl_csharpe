using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using LivrariaControleEmprestimo.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class EmprestimosController : Controller
    {
        private LivroClienteEmprestimoService _oEmprestimoService = new LivroClienteEmprestimoService();
        public IActionResult Index()
        {
            List<VwLivroClienteEmprestimo> oListVwLivroClienteEmprestimo = 
              _oEmprestimoService.oRepositoryVwClienteEmprestimo.SelecionarTodos();
            return View(oListVwLivroClienteEmprestimo);
        }

        public IActionResult Create()
        {
            EmprestimoViewModel oEmprestimoViewModel = new EmprestimoViewModel();
            List<Livro> oListLivro = _oEmprestimoService.oRepositoryLivro.SelecionarTodos();
            List<Cliente> oListCliente = _oEmprestimoService.oRepositoryCliente.SelecionarTodos();

            oEmprestimoViewModel.oListCliente = oListCliente;
            oEmprestimoViewModel.oListLivro = oListLivro;

            oEmprestimoViewModel.oLivroClienteEmprestimo = new LivroClienteEmprestimo();

            oEmprestimoViewModel.oLivroClienteEmprestimo.LceDataEmprestimo = DateTime.Now;
            oEmprestimoViewModel.oLivroClienteEmprestimo.LceDataEntrega = DateTime.Now.AddDays(7);


            return View(oEmprestimoViewModel);
        }

        [HttpPost]
        public IActionResult Create(LivroClienteEmprestimo oLivroClienteEmprestimo)
        {
            
            if (!ModelState.IsValid)
            {
                return View();
            }

            _oEmprestimoService.oRepositoryLivroClienteEmprestimo.Incluir(oLivroClienteEmprestimo);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            EmprestimoViewModel oEmprestimoViewModel = new EmprestimoViewModel();

            oEmprestimoViewModel.oListCliente = _oEmprestimoService.oRepositoryCliente.SelecionarTodos();
            oEmprestimoViewModel.oListLivro = _oEmprestimoService.oRepositoryLivro.SelecionarTodos();

            LivroClienteEmprestimo oLivroClienteEmprestimo = 
              _oEmprestimoService.oRepositoryLivroClienteEmprestimo.SelecionarPk(id);
            oEmprestimoViewModel.oLivroClienteEmprestimo = oLivroClienteEmprestimo;


            return View(oEmprestimoViewModel);
        }

        [HttpPost]
        public IActionResult Edit(EmprestimoViewModel oEmprestimoViewModel)
        {
            if (!ModelState.IsValid)
            {
                oEmprestimoViewModel.oListCliente = _oEmprestimoService.oRepositoryCliente.SelecionarTodos();
                oEmprestimoViewModel.oListLivro = _oEmprestimoService.oRepositoryLivro.SelecionarTodos();
                return View(oEmprestimoViewModel);
            }

            _oEmprestimoService.oRepositoryLivroClienteEmprestimo.Alterar(oEmprestimoViewModel.oLivroClienteEmprestimo);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id) 
        {            
            VwLivroClienteEmprestimo oLivroClienteEmprestimo = _oEmprestimoService.oRepositoryVwClienteEmprestimo.SelecionarPk(id);
            return View(oLivroClienteEmprestimo);
        }

        public IActionResult Delete(int id)
        {
            _oEmprestimoService.oRepositoryLivroClienteEmprestimo.Excluir(id);
            return RedirectToAction("Index");
        }

    }
}
