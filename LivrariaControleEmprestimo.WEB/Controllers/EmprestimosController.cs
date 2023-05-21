using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class EmprestimosController : Controller
    {
        private LivroClienteEmprestimoService oEmprestimoService = new LivroClienteEmprestimoService();
        public IActionResult Index()
        {
            List<VwLivroClienteEmprestimo> oListVwLivroClienteEmprestimo = oEmprestimoService.oRepositoryVmClienteEmprestimo.SelecionarTodos();
                return View(oListVwLivroClienteEmprestimo);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(VwLivroClienteEmprestimo model )
        {
            if (!ModelState.IsValid) 
            {
                return View();
            }
            oEmprestimoService.oRepositoryVmClienteEmprestimo.Incluir(model);

            return RedirectToAction("Index");
        }
    }
}
