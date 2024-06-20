using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPoo2
{
    internal class Carro
    {
      public  string cambio, cor, fabricante, nome;
      public  DateOnly ano;
        private bool ligado = false;

        public void status()
        {
            Console.WriteLine($"nome: {nome}");
            Console.WriteLine($"cor: {cor}");
            Console.WriteLine($"ano: {ano}");
            Console.WriteLine($"fabricante: {fabricante}");
            Console.WriteLine($"câmbio: {cambio}");
            Console.WriteLine($"está ligado: {ligado}");
        }
        public bool Ligar()
        {
            return ligado = true;
        }
        public bool desligar()
        {
            return ligado = false;
        }
        
        
    }
}
