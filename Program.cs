using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Oque deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair da Calculadora");

            Console.WriteLine("------------");
            Console.WriteLine("Selecione uma opção");
            short resposta = short.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 1:
                    Soma();
                    break;

                case 2:
                    Subtracao();
                    break;

                case 3:
                    Multiplicacao();
                    break;

                case 4:
                    Divisao();
                    break;

                case 5:
                    System.Environment.Exit(0);
                    break;

                default:
                    Menu();
                    break;
            }
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());


            Console.WriteLine("Segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            float soma = primeiroValor + segundoValor;

            Console.WriteLine(" ");
            Console.WriteLine($"O Resultado da soma é: {soma}");
            Console.ReadKey();
            Menu();


        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            float subtracao = primeiroValor - segundoValor;

            Console.WriteLine(" ");
            Console.WriteLine($"O resultado da subtração é: {subtracao}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            float multiplicacao = primeiroValor * segundoValor;

            Console.WriteLine(" ");
            Console.WriteLine($"O resultado da multiplicação é: {multiplicacao}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            float divisao = primeiroValor / segundoValor;

            Console.WriteLine(" ");
            Console.WriteLine($"O resultado da divisão é: {divisao}");
            Console.ReadKey();
            Menu();
        }
    }
}
