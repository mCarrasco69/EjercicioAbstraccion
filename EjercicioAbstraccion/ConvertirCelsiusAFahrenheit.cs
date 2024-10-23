using System;

namespace EjercicioAbstraccion
{
    public class  ConvertirCelsiusAFahrenheit : FormulaMatematica
    {
        private double celsius;
        private double fahrenheit;

        public ConvertirCelsiusAFahrenheit(double celsius)
        {
            this.celsius = celsius;
        }

        public override double Calcular()
        {
          return fahrenheit = (celsius * 9 / 5) + 32;
           
        }

        public override void Imprimir()
        {
            Console.WriteLine($"{celsius} grados Celsius equivalen a {fahrenheit} grados Fahrenheit");
        }
    }
}
