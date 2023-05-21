using LivrariaControleEmprestimo.DATA.Repositories;
using LivrariaControleEmprestimo.DATA.Repositories.LivrariaControleEmprestimo.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaControleEmprestimo.DATA.Services
{
    public class LivroClienteEmprestimoService
    {
        public RepositoryVwLivroClienteEmprestimo oRepositoryVwClienteEmprestimo { get; set; }
        public RepositoryLivro oRepositoryLivro { get; set; }
        public RepositoryCliente oRepositoryCliente { get; set; }

        public LivroClienteEmprestimoService()
        {
            oRepositoryVwClienteEmprestimo = new RepositoryVwLivroClienteEmprestimo();
            oRepositoryLivro = new RepositoryLivro();
            oRepositoryCliente = new RepositoryCliente();
        }
    }
}
