using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using LivrariaControleEmprestimo.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class EmprestimosController : Controller
    {
        private LivroClienteEmprestimoService oEmprestimoService = new LivroClienteEmprestimoService();
        public IActionResult Index()
        {
            List<VwLivroClienteEmprestimo> oListVwLivroClienteEmprestimo = oEmprestimoService.oRepositoryVwClienteEmprestimo.SelecionarTodos();
                return View(oListVwLivroClienteEmprestimo);
        }

        public IActionResult Create() 
        {
            EmprestimoViewModel oEmprestimoViewModel = new EmprestimoViewModel();
            List<Livro> oListLivro = oEmprestimoService.oRepositoryLivro.SelecionarTodos();
            List<Cliente> oListCliente = oEmprestimoService.oRepositoryCliente.SelecionarTodos();

            oEmprestimoViewModel.oListCliente = oListCliente;
            oEmprestimoViewModel.oListLivro = oListLivro;


            return View(oEmprestimoViewModel);
        }

    }
}
