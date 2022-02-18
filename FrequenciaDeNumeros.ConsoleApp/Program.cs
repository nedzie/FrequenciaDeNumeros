using System;
using System.Linq;

namespace FrequenciaDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maiorNumero = 0;
            int vezesDeTeste = 0;
            int[] valoresRecebidos = new int[100];
            
            Console.WriteLine("> Valores lidos:");
            vezesDeTeste = int.Parse(Console.ReadLine());
            for (int i = 0;  i < vezesDeTeste;  i++)
            {
                Console.WriteLine("> Valor:");
                valoresRecebidos[i] = int.Parse(Console.ReadLine());
                if(valoresRecebidos[i] > maiorNumero)
                {
                    maiorNumero = valoresRecebidos[i];
                }
            }
            int[] todosOsValores = new int[maiorNumero];
            foreach (int c in valoresRecebidos)
            {
                Console.Write(c + " ");
            }
            valoresRecebidos = valoresRecebidos.Where(T => T != 0).ToArray(); // Remove os 0 (ou null) de um arr
            for (int i = 0; i <= maiorNumero; i++)
            {
                if(valoresRecebidos.Contains(i))
                {
                    todosOsValores[i] += valoresRecebidos[i];
                }
            }
            Console.WriteLine("Depois de retirar os zeros:");
            foreach (int z in valoresRecebidos)
            {
                Console.Write(z + " ");
            }
            #region Ordena -> Crescente
            Console.WriteLine("Em ordem crescente: ");
            Array.Sort(valoresRecebidos);
            foreach (int y in valoresRecebidos)
            {
                Console.Write(y + " ");
            }
            #endregion
            Console.WriteLine("Apenas os valores únicos: ");
            System.Collections.Generic.IEnumerable<int> valoresUnicos = valoresRecebidos.Distinct<int>();
            foreach (int l in valoresUnicos)
            {
                Console.Write(l + " ");
            }
        }
    }
}