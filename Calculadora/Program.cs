using System;

namespace Calculadora
{
    class Program
    {
        enum Menu
        {
            Soma = 1, Subtracao = 2, Divisao, Multiplicacao, Potencia, Raiz, Sair
        }
        static void Main(string[] args) {

            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Seja bem vindo. Selecione uma opção:");
                Console.WriteLine("1-Soma\n2-Subtracao\n3-Divisao\n4-Multiplicacao" +
                    "\n5-Potencia\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Sub();
                        break;
                    case Menu.Multiplicacao:
                        Multi();
                        break;
                    case Menu.Divisao:
                        Div();
                        break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }
                Console.Clear();
            }
        }
        static void Soma()
        {
            Console.WriteLine("Soma de 2 números");
            Console.WriteLine("Digite um número");
            int numA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            int numB = int.Parse(Console.ReadLine());
            int resultado = numA + numB;
            Console.WriteLine("Soma: " + resultado);

            Console.WriteLine("Aperte um botão para voltar para o menu");
            Console.ReadLine();
        }
        static void Sub()
        {
            Console.WriteLine("Subtração de 2 números");
            Console.WriteLine("Digite um número");
            int numA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            int numB = int.Parse(Console.ReadLine());
            int resultado = numA - numB;
            Console.WriteLine("Subtração: " + resultado);

            Console.WriteLine("Aperte um botão para voltar para o menu");
            Console.ReadLine();
        }
        static void Multi()
        {
            Console.WriteLine("Multiplicação de 2 números");
            Console.WriteLine("Digite um número");
            int numA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            int numB = int.Parse(Console.ReadLine());
            int resultado = numA * numB;
            Console.WriteLine("Multiplicação: " + resultado);

            Console.WriteLine("Aperte um botão para voltar para o menu");
            Console.ReadLine();
        }
        static void Div()
        {
            Console.WriteLine("Divisão de 2 números");
            Console.WriteLine("Digite um número");
            int numA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            int numB = int.Parse(Console.ReadLine());
            float resultado = (float)numA / (float)numB;
            Console.WriteLine("Divisão: " + resultado);

            Console.WriteLine("Aperte um botão para voltar para o menu");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("Potencia de 1 número");
            Console.WriteLine("Digite a base");
            int numA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente");
            int numB = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(numA, numB);
            Console.WriteLine("Potencia: " + resultado);

            Console.WriteLine("Aperte um botão para voltar para o menu");
            Console.ReadLine();
        } 
        static void Raiz()
        {
            Console.WriteLine("Raiz de 1 número");
            Console.WriteLine("Digite o número");
            int numA = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(numA);
            Console.WriteLine("Raiz: " + resultado);

            Console.WriteLine("Aperte um botão para voltar para o menu");
            Console.ReadLine();
        }
    }
}
