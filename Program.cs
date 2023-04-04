namespace Aula02Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
            // isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem
            // de IPI(única) a ser acrescentada.

            string codigoA, codigoB;
            int qtdA, qtdB;
            double precoA, precoB, ipi;

            Console.Write("Digite o código do parafuso A: ");
            codigoA = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Digite a quantidade de peças do parafuso A: ");
            qtdA = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Digite o valor unitário do parafuso A: ");
            precoA = double.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------");

            Console.Write("Digite o código do parafuso B: ");
            codigoB = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Digite a quantidade de peças do parafuso B: ");
            qtdB = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Digite o valor unitário do parafuso B: ");
            precoB = double.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------");

            Console.Write("Digite a porcentagem de IPI a ser acrescentada: ");
            ipi = double.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------");

            double totalA = qtdA * precoA * (1 + ipi / 100);
            double totalB = qtdB * precoB * (1 + ipi / 100);
            double totalGeral = totalA + totalB;

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Valor total do parafuso A (" + codigoA + "): R$" + totalA.ToString("F2"));
            Console.WriteLine("Valor total do parafuso B (" + codigoB + "): R$" + totalB.ToString("F2"));
            Console.WriteLine("Valor total da compra: R$" + totalGeral.ToString("F2"));
            Console.WriteLine("----------------------------------------------------");
        }
    }
}