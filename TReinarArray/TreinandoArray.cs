using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TReinarArray
{
    class TreinandoArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Treinando a exibição de valores dentro de Array");
            Console.WriteLine("Apresente valores e no Final Mudara de Posição");
            Console.WriteLine(" ");

            int[] Array = null;
            Array = new int[10];

            for (int i = 0; i < Array.Length; i++){
                Console.WriteLine("Valor " + i);
                Array[i] = int.Parse(Console.ReadLine());                
            }
          
            for (int i = 0; i < Array.Length; i++) {
                Console.WriteLine("Posicao " + i + " valor " + Array[i]);
            }
            for (int i = 0; i < Array.Length; i++)
            {
                int posicao = 0;
                posicao = Array[i];
                Array[i] = Array[Array.Length - i];
            }
        }
    }
}
