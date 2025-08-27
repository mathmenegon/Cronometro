using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stopwatch
{
    internal class Cronometro
    {   
        public void Start()
        {
            while (true) { 
                Console.Clear();
                Console.WriteLine("Menu de opções:");
                Console.WriteLine("1 - Progressivo");
                Console.WriteLine("2 - Regressivo");
                Console.WriteLine("3 - Sair");
                Console.WriteLine("\nDigite o numero desejado e pressione Enter");

                int operacao = int.Parse(Console.ReadLine()!);

                switch (operacao)
                {
                    case 1:
                        Progressivo(); break;
                    case 2:
                        Regressivo(); break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Opção inválida! Pressiona Enter para continuar"); break;

                }
            }
        }

        static int DigitarTempo()
        {
            Console.Clear();
            
            Console.WriteLine("Digite o tempo que deseja contar em segundos");
            int tempo = int.Parse(Console.ReadLine()!); ;
            return tempo;
        }

        static void Progressivo()
        {
            int tempoAtual = 0;
            int tempo = DigitarTempo();
            Console.WriteLine("Digite o tempo que deseja contar em segundos");

            while (tempoAtual != tempo)
            {
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Cronometro finalizado!");
            Thread.Sleep(2500);
        }

        static void Regressivo()
        {
            int tempoAtual = 1;
            int tempo = DigitarTempo();
            tempo = tempo + 1;

            Console.WriteLine("Digite o tempo que deseja contar em segundos");
            while (tempoAtual != tempo)
            {
                Console.Clear();
                tempo--;
                Console.WriteLine(tempo);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Cronometro finalizado!");
            Thread.Sleep(2500);
        }

    }
}
