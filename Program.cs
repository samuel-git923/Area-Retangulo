using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Calcula a area de um retângulo");
            Console.Write("Informe a altura do retângulo: ");
            retangulo.Altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a base/largura do retângulo: ");
            retangulo.Base = Convert.ToDouble(Console.ReadLine());
            retangulo.ExibeDados();

            Console.ReadKey();
        }
    }
}
