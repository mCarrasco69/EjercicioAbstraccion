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
                Console.WriteLine(":             Menu              :");
                Console.WriteLine();
                Console.WriteLine("Seleccione una formula matemática:");
                Console.WriteLine("1. Metros a Kilometros");
                Console.WriteLine("2. Convertir Celsius a Fahrenheit");
                //Console.WriteLine("3. Perímetro de un rectángulo");
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
                   
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            } while (opcion != 0);
        }
    }
}
