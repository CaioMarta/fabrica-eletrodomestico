using System;

namespace FabricaEletrodomestico
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciar as classes CONCRETAS
            Radio radio = new Radio();
            Televisao tv = new Televisao();


            // configurar o RADIO
            radio.Voltagem = 110;
            radio.Ligar();
            Console.WriteLine(radio.ToString());

            // configurar TV
            tv.Voltagem = 220;
            tv.Ligar();
            Console.WriteLine(tv.ToString());




            // desligar           
            if(radio.Ligado)
            {
                Console.Write("\n Radio Ligado");
            }
            else
            {
                Console.Write("\n Radio Desligado");
            }           
            radio.Desligar();
            Console.WriteLine(radio.ToString());




            if (tv.Ligado)
            {
                Console.Write("\n TV Ligado");
            }
            else
            {
                Console.Write("\n TV Desligado");
            }
            tv.Desligar();
            Console.WriteLine(tv.ToString());


        }
    }
}
