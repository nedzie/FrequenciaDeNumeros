using System;
using System.Linq;

namespace FrequenciaDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vezesDeTeste = 0;
            Console.WriteLine("> Valores lidos:");
            vezesDeTeste = int.Parse(Console.ReadLine());
            int[] valoresRecebidos = new int[vezesDeTeste];
            for (int z = 0; z < vezesDeTeste; z++)
            {
                Console.WriteLine("> Valor:");
                valoresRecebidos[z] = int.Parse(Console.ReadLine());
            }
            Array.Sort(valoresRecebidos); // Ordena o array > menor : maior
            int numeroVerificador = 0;
            int numeroQueSeraVerificado = 0;
            while (numeroVerificador < valoresRecebidos.Length)
            {
                int numero = valoresRecebidos[numeroVerificador];
                int quantidadeVezes = 0;
                while (valoresRecebidos[numeroVerificador] == valoresRecebidos[numeroQueSeraVerificado])
                {
                    quantidadeVezes++;
                    numeroQueSeraVerificado++;
                    if (numeroQueSeraVerificado == valoresRecebidos.Length)
                        break;
                }
                Console.WriteLine(numero + " apareceu " + quantidadeVezes + " vez(es),");
                numeroVerificador = numeroQueSeraVerificado;
            }          
            Console.ReadKey();
        }
    }
}