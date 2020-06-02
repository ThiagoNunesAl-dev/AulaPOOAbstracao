using System;

namespace AulaPOOLojaVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito visa = new CartaoCredito();
            visa.limite = 1200f;
            Console.WriteLine("Deseja aumentar o limite do cartão? Qual é o acréscimo?");
            float acrescimo = float.Parse(Console.ReadLine());
            visa.AumentarLimite(acrescimo);
            Console.WriteLine("Novo limite: R$"+visa.limite+".");

            Console.WriteLine("Digite a data de pagamento (ex. 2020/06/15 15:30):");
            visa.data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Data de pagamento: "+visa.data);
            Console.WriteLine(visa.Pagar(900f));
        }
    }
}
