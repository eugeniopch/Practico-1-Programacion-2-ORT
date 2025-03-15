using System.Security.Cryptography;

namespace Practico1
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            string opcion = "";
            while (opcion != "0")
            {
                MostrarMenu();
                Console.Write("Ingrese una opcion -> ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        EjercicioUno();
                        break;
                    case "2":
                        EjercicioDos();
                        break;
                    //case "0":
                    //    Console.WriteLine("Saliendo...");
                    //    break;
                    default:
                        //MostrarError("ERROR: Opcion inválida");
                        break;
                }
            }

        }

        /*
        Ejercicio 1.
        Solicitar números hasta que ingrese el 0(fin del ingreso).Se debe comparar con un número random e indicar cuando son iguales.
        */

        static void EjercicioUno()
        {
            int numero = -1;
            while (numero != 0)
            {
                numero = PedirNumeros("Ingrese un número: ");
                int numeroRandom = NumeroRandom();
                if (numero == 0)
                {
                    Console.WriteLine("Finalizando");
                }
                else if (numero == numeroRandom)
                {
                    Console.WriteLine("Coinciden");
                }
                else
                {
                    Console.WriteLine("No coinciden");
                }
                PressToContinue();
                Console.Clear();
            }
        }

        static int NumeroRandom()
        {
            int numeroRandom = new Random().Next(1, 3);
            return numeroRandom;
        }

        /*
        Ejercicio 2  
        Solicitar un número y mostrar la tabla del mismo.
        */

        static void EjercicioDos() 
        {
            //Buscar la manera de optimizar este código
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("****** EJERCICIO 2 ******");
            Console.ForegroundColor = ConsoleColor.Gray;

            int numero = PedirNumeros("Ingrese un número: ");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{numero} X {i} = {numero * i}");
            }
            PressToContinue();
        }

        static void MostrarMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("****** MENU ******");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1 - Ejercicio 1");
            Console.WriteLine("2 - Ejercicio 2");
            Console.WriteLine("0 - Salir");
        }

        static int PedirNumeros(string mensaje)
        {
            bool exito = false;
            int numero = 0;
            while (!exito)
            {
                Console.Write(mensaje);
                exito = int.TryParse(Console.ReadLine(), out numero);

                //if (!exito) MostrarError("ERROR: Debe ingresar solo numeros");
            }

            return numero;
        }

        static void PressToContinue()
        {
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

    }
}
