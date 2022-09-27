using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaEletrodomestico
{
    // classe Concreta que Herdara a classe abstrata
    // Eletodomestico. Devera implementar os metodos abstratos definidos na classe ABSTRATA
    class Radio : Eletrodomestico  // Herança
    {
        // propriedades IMPLICITAMENTE serão declarados os atributos
        public int MaxFrequencia {get; set;}
        public double Sintonia { get; set; }

        //construtor
        public Radio() : base()
        {
            MaxFrequencia = 240;
            Sintonia = 0;
        }

        //metodos da classe
        public override string ToString()
        {
            return "\n Frequência Máxima RADIO: " + MaxFrequencia +
                   "\n Sintonia: " + Sintonia +
                   "\n Voltagem: " + base.Voltagem + " volts"; //nao precisa palavra base, é só para saber que esta na base
        }

        // implementar os metodos abstratos
        public override void Desligar()
        {
            if (Ligado)
            {
                Ligado = false;
            }
        }
        public override void Ligar()
        {
            if(!Ligado)
            {
                Ligado = true;
                Sintonia = 91.5;
                Console.WriteLine("\n Jovem Pan - aqui não aroeira");
            }
        }



    }
}
