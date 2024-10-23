using EjercicioAbstraccion;

public class OnzasAKilogramos : FormulaMatematica
{
    private double onzas;

    public OnzasAKilogramos(double onzas)
    {
        this.onzas = onzas;
    }

    public override double Calcular()
    {
        return onzas * 0.0283495; // Factor de conversión
    }

    public override void Imprimir()
    {
        Console.WriteLine($"{onzas} onzas equivalen a {Calcular()} kilogramos.");
    }
}