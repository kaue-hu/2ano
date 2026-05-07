using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario Func = new Funcionario();

            Console.Write("Nome: ");
            Func.Nome = Console.ReadLine();
            Console.Write("SalarioBruto: ");
            Func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            Func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");
            Console.WriteLine("Funcionario: " + Func);
            Console.WriteLine("");

            Console.WriteLine("Digite a porcentagem para aumentar o salario: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Func.AumentoSalario(porcent);

            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: " + Func);
        }
    }
}
