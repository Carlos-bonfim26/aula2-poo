using AulaPoo2;

namespace AulaPoo2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Carro carro01 = new Carro();

            carro01.fabricante = "Chevrolet";
            carro01.ano = new DateOnly(1976, 1, 1);
            carro01.cor = "Preto";
            carro01.nome = "Opala";
            carro01.cambio = "Manual";

            Carro carro02 = new Carro();
            carro02.fabricante = "Chevrolet";
            carro02.ano = new DateOnly(2006, 6, 9);
            carro02.cor = "vermelho";
            carro02.nome = "Relâmpago Marquinhos Catchau";
            carro02.cambio = "Automático";

            carro01.status();
            Console.WriteLine();
            carro02.Ligar();
            carro02.status();
          
        }
    }
}