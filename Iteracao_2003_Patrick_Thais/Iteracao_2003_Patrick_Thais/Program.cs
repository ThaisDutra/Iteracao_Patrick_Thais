using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick_Thais_Iteracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("resultado");
            Console.ReadLine();
            int[] val = new int[5] { 1, 2, 3, 4, 5 };
            int resultado = Somar(val);

        }
        static int Somar(int[] valores)
        {
            int resultado = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                resultado += valores[i];
            }
            return resultado;

        }

    }
}
