using System;

class Program
{
    static void Main()
    {
        bool encerrar = false;

        while (!encerrar)
        {
            Console.WriteLine("1 Somar");
            Console.WriteLine("2 Subtrair");
            Console.WriteLine("3 Multiplicar");
            Console.WriteLine("4 Dividir");
            Console.WriteLine("0 Sair");
            Console.Write("Escolha: ");

            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 0)
            {
                encerrar = true;
                Console.WriteLine("Encerrando...");
                continue;
            }

            Console.Write("Digite o primeiro número: ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            float y = float.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:

                    Console.WriteLine("Resultado: " + (x + y));
                    break;

                case 2:

                    Console.WriteLine("Resultado: " + (x - y));
                    break;

                case 3:

                    Console.WriteLine("Resultado: " + (x * y));
                    break;

                case 4:

                    if (y == 0)
                        Console.WriteLine("Erro: divisão por zero não permitida!");
                    else
                        Console.WriteLine("Resultado: " + (x / y));
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}






