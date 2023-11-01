using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            Console.WriteLine("Qual seu nome?");

            //armazenar a entrada de dados pelo usuário
            string nome = Console.ReadLine();

            //numeros inteiros e reais precisam ser convertidos com o PARSE
            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua altura?");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"Olá variável {nome}, você tem {idade} anos e {altura} de altura!");
        }
    }
}
