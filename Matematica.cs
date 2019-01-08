using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucaoConflito
{
    public class Matematica
    {

        public double Soma(double valor1, double valor2)
        {
            var resultado = valor1 + valor2;
            return resultado;
        }

        public double Subtracao(double valor1, double valor2)
        {
            var resultado = valor1 - valor2;
            return resultado;
        }

        public double Multiplicacao(double valor1, double valor2)
        {
            var resultado = valor1 * valor2;
            return resultado;
        }
        
        public double Divisao(double valor1, double valor2)
        {
            var resultado = valor1 / valor2;
            return resultado;
        }
    }
}
