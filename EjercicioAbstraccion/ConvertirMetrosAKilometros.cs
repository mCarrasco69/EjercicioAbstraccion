
namespace EjercicioAbstraccion
{
    internal class ConvertirMetrosAKilometros(double metros) : FormulaMatematica
    {
        public override double Calcular()
        {
            return metros / 1000;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"{metros} metros equivalen a {Calcular()} kilómetros.");
        }

    }
}
