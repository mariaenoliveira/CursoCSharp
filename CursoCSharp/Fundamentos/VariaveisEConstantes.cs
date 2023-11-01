using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            string nome = "Malcon";
            var sobreNome = "Batman"; // variável coringa (pode ser qaulquer tipo (double, bool, string...))
            int idade = 38;
            double altura = 1.60;
            bool casado = false;

            const double pi = 3.14; // constante

            //concatenando
            Console.WriteLine($"Olá, eu sou {nome} tenho {idade} anos de idade, tenho {altura} de altura e é {casado} que sou casado");
        }
    }
}
