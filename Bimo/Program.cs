using System;
using Figgle;

namespace Bimo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, operação, sair;
            string nomeOS, arquiteturaOS;

            nomeOS = System.Runtime.InteropServices.RuntimeInformation.OSDescription;
            arquiteturaOS = System.Runtime.InteropServices.RuntimeInformation.OSArchitecture.ToString();

            do
            {
                Console.Clear();

                Console.WriteLine($"Bimo: Olá usuário, qual é o seu nome?");
                nome = Console.ReadLine();

                Console.Clear();
                Console.WriteLine($"Bimo: Olá {nome}!\n");
                Console.WriteLine($"Bimo: Eu sou Bimo, eu fui programado para te auxiliar e com isso hoje serei seu assistente virtual.");
                Console.WriteLine($"Bimo: Vamos Começar!");

                Console.WriteLine();
                Console.Write("Pressione Enter para continuar...");
                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("Bimo: Este programa irá detectar e mostrar a você qual é sua versão do windows");
                Console.WriteLine("e tambem irá mostrar sua arquitetura do seu sistema operacional 🙂");
                Console.WriteLine();

                Console.WriteLine("Bimo: Abaixo teremos uma lista de qual operação você desejar");
                Console.WriteLine();

                Console.WriteLine("(1) Exibir somente a versão do Windows?");
                Console.WriteLine("(2) Exibir somente a sua arquitetura do Windows?");
                Console.WriteLine("(3) Exibir a versão e a arquitetura?\n");
                Console.Write("Bimo: Qual operação você deseja realizar? ");
                operação = Console.ReadLine();

                if (operação == "1")
                {
                    Console.Clear();

                    Console.WriteLine($"Bimo: {nome}, a versão do seu windows é a: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(FiggleFonts.Big.Render($"{nomeOS}"));
                    Console.ResetColor();
                }

                else if (operação == "2")
                {
                    Console.Clear();

                    Console.WriteLine($"Bimo: {nome}, a versão da sua arquitetura é a: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(FiggleFonts.Big.Render($"{arquiteturaOS} BITS"));
                    Console.ResetColor();
                }

                else if (operação == "3")
                {
                    Console.Clear();

                    Console.WriteLine($"Bimo: {nome}, a versão do seu windows é a: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(FiggleFonts.Big.Render($"{nomeOS}"));
                    Console.ResetColor();

                    Console.WriteLine($"Bimo: e a sua arquitetura é a: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(FiggleFonts.Big.Render($"{arquiteturaOS} BITS"));
                    Console.ResetColor();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Bimo: {nome}, você digitou algo invalido!");
                    Console.WriteLine();
                }

                Console.WriteLine($"Bimo: {nome}, você deseja sair? S/N");
                sair = Console.ReadLine().ToUpper();
            }
            while (sair != "S" && sair != "SIM");
            {
                Console.Clear();
                Console.WriteLine($"Bimo: Obrigado {nome} e volte sempre :)");

            }
        }
    }
}