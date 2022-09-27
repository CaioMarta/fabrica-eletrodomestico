using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaEletrodomestico
{
    //classe abstrata nao pode ser instanciada
    // (nao podemos ter objetos nela).
    // Serve apenas para ser Herdade ( classe BASE )
    abstract class Eletrodomestico
    {
        // propriedades  e IMPLICITAMENTE declarar os atributos

        // atributos
        public int Voltagem { get; set; }
        public bool Ligado { get; set; }

        // construtor
        public Eletrodomestico()
        {
            Voltagem = 0;       // metodo set
            Ligado = false;     // metodo set
        }

        // métods ABSTRATOS : na classe Abstrata, colocamos a penas a ASSINATURA dos metodos
        // métodos abstratos serao Implementados as classes Derivadas
        public abstract void Ligar();
        public abstract void Desligar();

    }
}
