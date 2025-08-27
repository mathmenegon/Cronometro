using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cronometro
{
    internal class Menu
    {
        public void Start()
        {
            MenuRaiz();
        }

        static void MenuRaiz()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu de opções:");
                Console.WriteLine("1 - Progressivo");
                Console.WriteLine("2 - Regressivo");
                Console.WriteLine("3 - Voltar");
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

            static (char type, int tempo)DigitarTempo()
            {
                Console.Clear();

                Console.WriteLine("Digite o tempo (ex: 10s ou 2m):");
                string data = Console.ReadLine()!.ToLower();
                char type = char.Parse(data.Substring(data.Length - 1, 1));
                int tempo = int.Parse(data.Substring(0, data.Length - 1));
                return (type, tempo);
            }

            static (int typeMulti, int tempo) Checagem()
            {
                var dados = DigitarTempo();
                int multiplicador = 0;

                if (dados.type == 'm') 
                    multiplicador = 60;
                else
                    multiplicador = 1;
                
                return (multiplicador, dados.tempo);
            }


            static void Progressivo()
            {
                var dados = Checagem();
                
                int tempoAtual = 0;
                int tempo = dados.tempo;
                int tempoFinal = tempo * dados.typeMulti;
                Console.WriteLine("Digite o tempo que deseja contar em segundos");

                while (tempoAtual != tempoFinal)
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
                var dados = Checagem();


                int tempoAtual = 0;
                int tempo = dados.tempo;
                int tempoFinal = tempo * dados.typeMulti;
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
}
