﻿using System.Drawing;
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
                    case "3":
                        EjercicioTres();
                        break;
                    case "4":
                        EjercicioCuatro();
                        break;
                    case "5":
                        EjercicioCinco();
                        break;
                    case "6":
                        EjercicioSeis();
                        break;
                    case "0":
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        MostrarError("ERROR: Opcion inválida");
                        break;
                }
            }

        }

        /*
        Ejercicio 1.
        Solicitar números hasta que ingrese el 0(fin del ingreso).
        Se debe comparar con un número random e indicar cuando son iguales.
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

        /*Ejercicio 3.  
        Solicitar dos números y muestre todos los números entre los valores ingresados que sean pares.*/

        static void EjercicioTres()
        {
            int num1 = PedirNumeros("Ingrese un número: ");
            int num2 = PedirNumeros("Ingrese otro número: ");

            for (int i = num1; i < num2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            PressToContinue();
        }

        /*Ejercicio 4  
        Solicitar dos números y un valor, indicar si el valor está comprendido entre los números*/

        static void EjercicioCuatro()
        {
            int num1 = PedirNumeros("Ingrese un número: ");
            int num2 = PedirNumeros("Ingrese otro número: ");
            int valor = PedirNumeros("Ingrese un valor: ");

            for (int i = num1; i < num2; i++)
            {
                if (i == valor)
                {
                    Console.WriteLine("El valor se encuentra comprendido entre los dos números");
                }
            }

            //Ver respuesta en caso de que no se encuentre comprendido entre los dos números

            PressToContinue();
        }

        /*Ejercicio 5  
        Solicitar números hasta que se ingrese el 0. Se debe mostrar la suma de todos ellos.*/

        static void EjercicioCinco()
        {
            int sumatoria = 0;
            int numero;

            while (true) 
            {
                numero = PedirNumeros("ingrese un número: ");

                if (numero == 0)
                {
                    Console.WriteLine($"La sumatoria es: {sumatoria}");
                    break;
                }

                sumatoria += numero;
            }

            PressToContinue();
        }

        /*Ejercicio 6  
        Ingresar una palabra y mostrar la cantidad de vocales que tiene.*/

        static void EjercicioSeis()
        {
            string palabra = PedirPalabras("Ingresá una palabra: ");
            int cantidad = 0;

            for (int i = 0; i < palabra.Length; i++)
            {
                if (EsVocal(palabra[i])) cantidad++;
            }

            Console.WriteLine($"La palabra ingresada tiene {cantidad} vocales");
            PressToContinue();
        }

        static bool EsVocal(char letra)
        {
            string vocales = "aeiouáéíóú";
            return vocales.Contains(char.ToLower(letra));
        }

        /*Ejercicio 7  
        Ingresar una palabra y mostrarla en el otro sentido(Hola -> aloH).*/  

        static void MostrarMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("****** MENU ******");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1 - Ejercicio 1");
            Console.WriteLine("2 - Ejercicio 2");
            Console.WriteLine("3 - Ejercicio 3");
            Console.WriteLine("4 - Ejercicio 4");
            Console.WriteLine("5 - Ejercicio 5");
            Console.WriteLine("6 - Ejercicio 6");
            Console.WriteLine("7 - Ejercicio 7");
            Console.WriteLine("8 - Ejercicio 8");
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

                if (!exito) MostrarError("ERROR: Debe ingresar solo numeros");
            }

            return numero;
        }

        static string PedirPalabras(string mensaje)
        {
            Console.Write(mensaje);
            string dato = Console.ReadLine();
            return dato;
        }

        static void PressToContinue()
        {
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarError(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensaje);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
