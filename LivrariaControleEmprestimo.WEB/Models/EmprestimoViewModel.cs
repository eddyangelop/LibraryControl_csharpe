using LivrariaControleEmprestimo.DATA.Models;
using System;
using System.Collections.Generic;

namespace LivrariaControleEmprestimo.WEB.Models
{
    public class EmprestimoViewModel
    {
        public Livro oLivro { get; set; }
        public Cliente oCliente { get; set; }      
        public LivroClienteEmprestimo oLivroClienteEmprestimo { get; set; }

        public List<Cliente> oListCliente { get; set; }
        public List<Livro> oListLivro { get; set; }
        
    }
}
