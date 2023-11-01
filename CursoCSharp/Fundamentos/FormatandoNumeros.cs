using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumeros {
        public static void Executar(){
            //arredondar número
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));

            //transformar um valor monetário (moeda de acordo com o idioma da máquina)
            Console.WriteLine(valor.ToString("C"));

            //multiplica um valor por 100 e adiciona percentual
            Console.WriteLine(valor.ToString("P"));

            //formatando o número do jeito que quiser
            Console.WriteLine(valor.ToString("#.##"));
        }
    }
}
