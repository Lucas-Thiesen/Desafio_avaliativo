using System;

namespace EsquerdaVolver.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char comando, volver = 'N';

            Console.Write("Número de comados emitidos pelo sargento: ");
            int comandos_soldado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe os comandos a serem seguidos: ");
            Console.WriteLine("E - Esquerda, D - Direita");
            for (int i = 1; i <= comandos_soldado; i++)
            {
                Console.Write(i + "° Comando: ");
                comando = Convert.ToChar(Console.ReadLine());

                if (comando == 'D')
                {
                    switch (volver)
                    {
                        case 'N':
                            volver = 'L';
                            break;
                        case 'S':
                            volver = 'O';
                            break;
                        case 'L':
                            volver = 'S';
                            break;
                        case 'O':
                            volver = 'N';
                            break;
                    }
                }

                if (comando == 'E')
                {
                    switch (volver)
                    {
                        case 'N':
                            volver = 'O';
                            break;
                        case 'S':
                            volver = 'L';
                            break;
                        case 'L':
                            volver = 'N';
                            break;
                        case 'O':
                            volver = 'S';
                            break;
                    }
                }
            }
            Console.WriteLine("O recruta está olhando para o: " + volver);
            Console.ReadKey();
        }
    }
}