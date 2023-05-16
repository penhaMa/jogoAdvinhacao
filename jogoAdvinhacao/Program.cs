using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoAdvinhacao
{
    class Program
    {
        static void Main()
        {
            bool jogarNovamente = true;

            Console.WriteLine("\nBem-vindo ao jogo de adivinhação!");

            while (jogarNovamente)
            {
                Random random = new Random();
                int numeroAleatorio = random.Next(1, 101);

                bool acertou = false;
                int tentativas = 0;
                const int maxTentativas = 10; // Define o número máximo de tentativas como uma constante

                Console.WriteLine("\nTente adivinhar o número entre 1 e 100. Você tem {0} tentativas.", maxTentativas);

                while (!acertou && tentativas < maxTentativas)
                {
                    Console.Write("\nTentativa {0}: Digite um número: ", tentativas + 1); // Exibe o número da tentativa atual
                    string input = Console.ReadLine();

                    int palpite;
                    if (!int.TryParse(input, out palpite))
                    {
                        Console.WriteLine("\nEntrada inválida. Por favor, digite um número válido.");
                        continue;
                    }

                    tentativas++;

                    if (palpite > numeroAleatorio)
                    {
                        Console.WriteLine("\nTente um número menor. Tentativas restantes: {0}", maxTentativas - tentativas);
                    }
                    else if (palpite < numeroAleatorio)
                    {
                        Console.WriteLine("\nTente um número maior. Tentativas restantes: {0}", maxTentativas - tentativas);
                    }
                    else
                    {
                        Console.WriteLine("\nParabéns! Você acertou em {0} tentativa(s)!", tentativas);
                        acertou = true;
                    }
                }

                if (!acertou)
                {
                    Console.WriteLine("\nVocê não acertou o número. O número correto era {0}.", numeroAleatorio);
                }

                Console.Write("\nDeseja jogar novamente? (S/N): ");
                string resposta = Console.ReadLine();

                jogarNovamente = resposta.Equals("S", StringComparison.OrdinalIgnoreCase);

                if (jogarNovamente)
                {
                    Console.Clear(); // Limpa a tela do console antes de iniciar um novo jogo
                }
            }

            Console.WriteLine("\nObrigado por jogar. Até a próxima!");
            Console.ReadLine();
        }
    }
}
