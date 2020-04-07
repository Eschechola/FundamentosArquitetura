using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class EstadoComportamento
    {
        //estado são suas propriedades
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }


        //comportamento é o processamento
        //pode alterar o estado da classe
        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;

            if (dataAtual > DataNascimento)
                return dataAtual.Year - DataNascimento.Year;
            
            else
                return 0;
        }
    }
}
