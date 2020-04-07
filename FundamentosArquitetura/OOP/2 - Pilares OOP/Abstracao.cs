using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    //oferecer um conjunto de estados e comportamento que abstraem
    //uma certa especialização
    public abstract class Eletrodomestico
    {
        private readonly string Nome;
        private readonly int Voltagem;

        protected Eletrodomestico(string nome, int voltagem)
        {
            Nome = nome;
            Voltagem = voltagem;
        }

        public abstract void Ligar();
        public abstract void Desligar();
        public virtual void Testar()
        {
            //teste do equipamento
        }
    }
}
