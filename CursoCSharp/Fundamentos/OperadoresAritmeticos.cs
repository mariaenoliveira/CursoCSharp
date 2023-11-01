using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritmeticos {
        public static void Executar(){
            /*
            Console.WriteLine("Escreva um número: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva outro número: ");
            int num2 = int.Parse(Console.ReadLine());

            int soma = num + num2;
            Console.WriteLine($"A soma dos números é: {soma}");
            */

            Console.WriteLine("Informe a altura: ");
            var altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a base: ");
            var largura = double.Parse(Console.ReadLine());

            var area = altura * largura / 2;

            Console.WriteLine($"A área do triângulo é: {area}");
        }
    }
}
