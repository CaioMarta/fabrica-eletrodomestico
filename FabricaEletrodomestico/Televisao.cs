using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaEletrodomestico
{
    // classe Concreta que Herdara a classe abstrata
    // Eletodomestico. Devera implementar os metodos abstratos definidos na classe ABSTRATA
    class Televisao : Eletrodomestico
    {
        public int QdeCanais { get; set; }
        public bool FullHD { get; set; }

        // construtor
        public Televisao() : base()
        {
            QdeCanais = 200;
            FullHD = false;
        }

        //metodos classe
        public override string ToString()
        {
            string msg = "";
            if(FullHD == true)
            {
                msg = " Tv Full HD";
            }
            else
            {
                msg = " HD";
            }
            return "\n Quantidade de canais: " + QdeCanais +
              msg +"\n Voltagem: " + Voltagem + " volts";
        }

        // implementar os dados
        public override void Desligar()
        {
            if(Ligado)
            {
                Ligado = false;
                Console.WriteLine("\n Desligando...");
            }
        }

        public override void Ligar()
        {
            if(!Ligado)
            {
                Ligado = true;
                Console.WriteLine("\n Canal Favorito");
            }
        }
    }
}
