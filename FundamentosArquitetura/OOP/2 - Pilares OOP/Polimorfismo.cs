using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Polimorfismo
    {}

    //Poli - Morfismo
    //Muitos comportamentos para algo

    public class CafeteiraEspressa : Eletrodomestico
    {
        public CafeteiraEspressa(string nome, int voltagem)
        : base(nome, voltagem)
        {

        }

        public static void AquecerAgua() { }
        public static void MoerGraos() { }

        public void PrepararCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
        }

        //método com comportamento padrão
        public override void Testar()
        {
            // testar cafeteira
        }


        //métodos abstratos sem implementação
        public override void Desligar()
        {
            // resfriar aquecedor
        }

        public override void Ligar()
        {
            // verificar recipiente de agua
        }

    }
}
