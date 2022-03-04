using System;

namespace FrequenciaDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nmros = new int[] { 10, 10, 20, 20, 30, 30, 30, 30, 40, 40, 15, 15, 15 };

            for (int lerOnumero = 0; lerOnumero < nmros.Length; lerOnumero++) Console.Write(nmros[lerOnumero] + " ");
            Console.WriteLine(" ");

            //ordenar os numeros
            Array.Sort(nmros); 

            int x = 0;
            int y = 0;

            while (x < nmros.Length)
            {
                int numero = nmros[x];
                int cont = 0;

                while (nmros[x] == nmros[y])
                {
                    cont++;
                    y++;

                    if (y == nmros.Length)// verificar se é o ultimo elemento e parar
                    {
                        break;
                    }
                }

                string apareceu = (cont > 1) ? " vezes" : " vez";
                Console.WriteLine( + numero + " apareceu " + cont + apareceu);
                x = y;
            }
            Console.ReadLine();
        }
    }
}   