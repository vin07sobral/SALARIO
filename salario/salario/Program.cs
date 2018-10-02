using System;
using System.Globalization;
namespace introducao_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x = new Funcionario();
            double porcent;
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            x.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Desconto: ");
            x.desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Dados do funcionário: " + x);
            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.aumentarSalario(porcent);
            Console.WriteLine();
            Console.WriteLine("Dados do funcionário: " + x);
            Console.ReadLine();
        }
    }
}