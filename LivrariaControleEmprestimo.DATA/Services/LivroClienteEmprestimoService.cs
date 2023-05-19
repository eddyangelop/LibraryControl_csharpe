using LivrariaControleEmprestimo.DATA.Repositories.LivrariaControleEmprestimo.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaControleEmprestimo.DATA.Services
{
    public class LivroClienteEmprestimoService
    {
        public RepositoryVwLivroClienteEmprestimo oRepositoryVmClienteEmprestimo { get; set; }

        public LivroClienteEmprestimoService()
        {
            oRepositoryVmClienteEmprestimo = new RepositoryVwLivroClienteEmprestimo();
        }
    }
}
