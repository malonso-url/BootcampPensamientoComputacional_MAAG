using System;

namespace ConsoleApplication15
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            Console.Title = "Mini Calculadora"; //Sirve para agregarle un titulo a la ventana
            string resp = "";
            Aritmetica misOperaciones = new Aritmetica();
            do
            {

                //Aqui mostraremos los mensajes que apareceran en nuestra consola igual que el menu de seleccion.
                Console.WriteLine("Presione el simbolo para realizar la operacion:n");
                Console.WriteLine("+ para sumar");
                Console.WriteLine("- para restar");
                Console.WriteLine("* para multiplicar");
                Console.WriteLine("/ para dividir");
                Console.WriteLine("! Inspeccionar el buen funcionamiento de la calculadora");
                Console.Write("Eliga Una Opcion: \n "); //Aqui es donde indicaremos que operacion vamos a realizar
                resp = Console.ReadLine();
                
                //Aqui se agregaran los mensajes para poder ingresar los datos.
                Console.WriteLine("\nIngrese sus dos numeros\n");
                Console.Write("Valor1: ");
                string strTempVal1 = Console.ReadLine();

                Console.Write("Valor2: ");
                string strTempVal2 = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine(misOperaciones.Operar(resp, strTempVal1, strTempVal2));
               
                Console.Write("\n¿Desea Continuar? s/n: "); //Si para realizarlo de nuevo y no para salir.
                resp = Console.ReadLine();
            }
            while (resp.ToLower().Equals("s"));

            Console.WriteLine("\n¿Desea comprobar la calculadora? s/n\n");
            resp = Console.ReadLine();

            if (resp.ToLower().Equals("s")) {
                ValidarCalculadora(misOperaciones);
            }
            
        }

        static void ValidarCalculadora(Aritmetica operaciones) {

            Console.WriteLine("Validando operaciones de la calculadora");

            //Suma
            Console.WriteLine("Suma enteros positivos: 3 + 5 = " + operaciones.Suma(3,5));
            Console.WriteLine("Suma enteros negativos: (-3) + (-5) = " + operaciones.Suma(-3, -5));

            //Resta
            Console.WriteLine("Resta cuando minuendo > sustraendo: 10 - 5 = " + operaciones.Resta(10, 5));
            Console.WriteLine("Resta cuando minuendo < sustraendo: 10 - 55 = " + operaciones.Resta(10, 55));
            Console.WriteLine("Resta cuando minuendo es negativo y sustraendo positivo: (-10) - (55) = " + operaciones.Resta(-10, 55));
            Console.WriteLine("Resta cuando minuendo es positivo y sustraendo negativo: (10) - (-55) = " + operaciones.Resta(10, -55));

            //Multiplicacion
            Console.WriteLine("Multiplicacion de dos enteros positivos: 4 * 5 = " + operaciones.Multiplicacion(4,5));
            Console.WriteLine("Multiplicacion de dos enteros negativos: (-4) * (-5) = " + operaciones.Multiplicacion(-4, -5));

            //Division by zero
            try
            {
                Console.WriteLine("Division por 0 se debe manejar la excepción: 4 / 0 = " + operaciones.Division(4, 0));
            }
            catch (Exception e) {
                Console.WriteLine("Division por 0");
            }

            Console.WriteLine("Division cuando dividendo > divisor = " + operaciones.Division(4, 2));
            Console.WriteLine("Division cuando dividendo < divisor = " + operaciones.Division(5, 2));

            Console.WriteLine("Comprobar si 30 es número: " + operaciones.EsNumero("30"));
            Console.WriteLine("Comprobar si 30.5 es número: " + operaciones.EsNumero("30.5"));
            Console.WriteLine("Comprobar si AB30 es número: " + operaciones.EsNumero("AB30"));
            Console.WriteLine("Comprobar si HELLO es número: " + operaciones.EsNumero("HELLO"));
            Console.WriteLine("Comprobar si 4  0 es número: " + operaciones.EsNumero("4  0"));

        }
    }
}
