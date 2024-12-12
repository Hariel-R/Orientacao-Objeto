using System.Drawing;
using System.Linq;
namespace ConsoleApp2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            Console.WriteLine("Informe 10 numeros: ");

            for (int i = 1; i <= 10; i++) 
            { 
            Console.WriteLine($"Informe o {i}º numero: ");       
            numeros.Add(int.Parse(Console.ReadLine()));
                Console.Clear();
             };
            var numerosdec = numeros.OrderByDescending(n => n).ToList();

            Console.WriteLine($"Lista: [{string.Join(", ", numerosdec)}]");
            Console.WriteLine($"Menor valor da lista: {numeros.Min()}");
            Console.WriteLine($"Maior valor da lista: {numeros.Max()}");

            Console.WriteLine("Insira mais 4 numeros: ");
            for (int j=0; j<4; j++)
            {
                int valor = int.Parse(Console.ReadLine());
            if ((valor % 2) == 0) {
                numerosdec.Insert(0, valor);
            }
            else
            {
                numerosdec.Add(valor);
            }

            }

            Console.WriteLine($"Lista com novos valores: [{string.Join(", ", numerosdec)}]");

            Console.WriteLine("Informe um valor para remover: ");
            int valor2 = int.Parse(Console.ReadLine());
            var indices = numerosdec
                .Select((num, index) => new { num, index }) 
                .Where(x => x.num == valor2)               
                .Select(x => x.index)               
                .ToList();
              Console.WriteLine($"Indices do valor {valor2} [ {string.Join(", ", indices)}]");
            
            Console.WriteLine("Informe a posição do item que deseja remover: ");
            numerosdec.RemoveAt(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Lista com valor removido [{string.Join(", ", numerosdec)}]");

        }
    }
}
