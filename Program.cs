using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        int menu;


        Console.WriteLine("----------------------------------");
        Console.WriteLine("-----------CALCULADORA------------");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("MENU\nDigite 1 para adição\nDigite 2 para subtração\nDigite 3 para multiplicação\nDigite 4 para a divisão\nDigite 0 para sair");
        menu = int.Parse(Console.ReadLine());
        switch (menu)
        {
            case (1):
                Soma();
                break;
            case (2):
                Subtracao();
                break;
            case (3):
                Multiplicacao();
                break;
            case (4):
                Divisao();
                break;
            case (0):
                Console.WriteLine("Saindo");
                System.Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opção inválida.");
                Menu();
                break;
        }

    }


    static void Soma()
    {
        Console.Clear();
        double num1;
        double num2;
        double resultado;

        Console.WriteLine("Digite o primeiro valor: ");
        num1 = double.Parse(Console.ReadLine());//Recebe o valor e alterr 

        Console.WriteLine("Digite outro valor: ");
        num2 = double.Parse(Console.ReadLine());

        resultado = num1 + num2;//Soma o valor

        Console.WriteLine($"A soma dos valores é : {resultado}"); // Exibe o valor e converte a string lida para double
                                                                  //Console.WriteLine("A soma dos valores é : " + resultado);
                                                                  //aa
        Console.ReadKey();
        Menu();
    }

    static void Subtracao()
    {
        double num1;
        double num2;
        double resultado;

        Console.WriteLine("Digite o valor do primeiro numero: ");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o outro valor: ");
        num2 = double.Parse(Console.ReadLine());

        resultado = num1 - num2;


        Console.WriteLine($"O resultado da subtração é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {
        double num1;
        double num2;
        double resultado;

        Console.WriteLine("Digite o valor do primeiro numero: ");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o outro valor: ");
        num2 = double.Parse(Console.ReadLine());

        resultado = num1 / num2;


        Console.WriteLine($"O resultado da divisão é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        double num1;
        double num2;
        double resultado;

        Console.WriteLine("Digite o valor do primeiro numero: ");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o outro valor: ");
        num2 = double.Parse(Console.ReadLine());

        resultado = num1 * num2;


        Console.WriteLine($"O resultado da multiplicação é: {resultado}");
        Console.ReadKey();
        Menu();
    }
}

