using System;

namespace AlertaEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            double qtdMaxima,qtdAtual,resultado;
            string nomeproduto;
            Console.Clear();

            Console.WriteLine("Digite o nome do produto");
            nomeproduto = Console.ReadLine();

            Console.WriteLine("Digite a quantidade atual do produto");
            qtdAtual = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade máxima do produto");
            qtdMaxima = double.Parse(Console.ReadLine());

            resultado = (qtdAtual / qtdMaxima)*100;

            //O comando ToString ("n2") formata a saida do número que está em resultado
            //com 2 casas decimais. Ao final concatenamos com símbolo de porcentagem

            Console.WriteLine(resultado.ToString("n2")+"%");

            if(resultado <= 12)
                Console.WriteLine("Comprar com Urgência");
            else if(resultado<=20)
                Console.WriteLine("Realizar Compra");
            else
                Console.WriteLine("Ponto de Utilização");
                        
        }
    }
}
