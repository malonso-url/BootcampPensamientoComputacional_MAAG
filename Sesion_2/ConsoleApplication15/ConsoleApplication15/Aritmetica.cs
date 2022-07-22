using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Aritmetica
    {
        public int Suma(int valor1, int valor2) {
            return valor1 + valor2;
        }

        public int Resta(int valor1, int valor2) {
            return valor1 - valor2;
        }

        public int Multiplicacion(int valor1, int valor2) {
            return valor1 * valor2;
        }

        public int Division(int valor1, int valor2) {
            return valor1 / valor2;
        }

        public string Operar(string operador, string valor1, string valor2) {

            if (!EsNumero(valor1)) {
                return "El valor 1 no es un número por lo tanto no se puede operar";
            }

            if (!EsNumero(valor2))
            {
                return "El valor 2 no es un número por lo tanto no se puede operar";
            }

            string resultado = "";

            try
            {
                switch (operador)
                {
                    case "+":
                        resultado = "El resultado de la suma es:\r\n";
                        resultado += valor1 + " + " + valor2 + " = " + Suma(Convert.ToInt32(valor1), Convert.ToInt32(valor2));
                        break;
                    case "-":
                        resultado = "El resultado de la resta es:";
                        resultado += valor1 + " - " + valor2 + " = " + Resta(Convert.ToInt32(valor1), Convert.ToInt32(valor2));
                        break;
                    case "*":
                        resultado = "El resultado de la multiplicacion es:";
                        resultado += valor1 + " * " + valor2 + " = " + Multiplicacion(Convert.ToInt32(valor1), Convert.ToInt32(valor2));
                        break;
                    case "/":
                        resultado = "El resultado de la division es:";
                        resultado += valor1 + " / " + valor2 + " = " + Division(Convert.ToInt32(valor1), Convert.ToInt32(valor2));
                        break;
                    default:
                        resultado = "El operador ingresado no es válido";
                        break;
                }
            }
            catch (Exception e) {
                resultado = "Ha ocurrido un error: " + e.Message;
            }

            return resultado;
        }

        public bool EsNumero(string valor) {
            foreach (char a in valor) {
                if (!"0123456789".Contains(a)) {
                    return false;
                }
            }
            return true;
        }
    }
}
