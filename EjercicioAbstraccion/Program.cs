using System;

namespace EjercicioAbstraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine();
                Console.WriteLine(":--------------Menu---------------:");
                Console.WriteLine();
                Console.WriteLine("Seleccione una formula matemática:");
                Console.WriteLine("1. Convertir Metros a Kilometros");
                Console.WriteLine("2. Convertir Celsius a Fahrenheit");
                Console.WriteLine("3. Convertir onzas a kilogramos");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese metros: ");
                        double metros = Convert.ToDouble(Console.ReadLine());
                        FormulaMatematica ConvertirMetrosAKilometros = new ConvertirMetrosAKilometros(metros);
                        ConvertirMetrosAKilometros.Calcular();
                        ConvertirMetrosAKilometros.Imprimir();
                        break;
                      
                    case 2:
                        Console.Write("Ingrese los grados Celsius: ");
                        double celsius = Convert.ToDouble(Console.ReadLine());
                        FormulaMatematica convertirCelsius = new ConvertirCelsiusAFahrenheit(celsius);
                        convertirCelsius.Calcular();
                        convertirCelsius.Imprimir();
                        break;
                
                    case 3:
                        Console.Write("Ingrese las onzas: ");
                        double onzas = Convert.ToDouble(Console.ReadLine());
                        FormulaMatematica OnzasAKilogramos = new OnzasAKilogramos(onzas);
                        OnzasAKilogramos.Calcular();
                        OnzasAKilogramos.Imprimir();
                        break;
                  
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                Console.WriteLine();
            } while (opcion != 0);
        }
    }
}
