﻿using LivrariaControleEmprestimo.DATA.Models;
using System;
using System.Collections.Generic;

namespace LivrariaControleEmprestimo.WEB.Models
{
    public class EmprestimoViewModel
    {
        public Livro oLivro { get; set; }
        public Cliente oCliente { get; set; }
        public int IdCliente { get; set; }
        public int IdLivro { get; set; }

        public DateTime dataEmprestimo { get; set; }
        public DateTime dataEntrega { get; set; }      
        public List<Cliente> oListCliente { get; set; }
        public List<Livro> oListLivro { get; set; }
    }
}
