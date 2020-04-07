using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Pessoa
    {
        public string Nome { get; set; }
    }

    //um funcionário é uma pessoa
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissão { get; set; }
    }

    public class Processo
    {
        public void Execucao()
        {
            var funcionario = new Funcionario
            {
                Nome = "Lucas",
                DataAdmissão = DateTime.Now
            };
        }
    }
}
