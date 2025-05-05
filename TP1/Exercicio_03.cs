using System;


namespace TP1
{
    internal class Exercicio_03
    {
        internal void Start()
        {
            Console.WriteLine("Informe as dimensões para cálculo da área de uma retângulo:");

            Console.Write("Insira a dimensão da base do retângulo: ");
            string dimensaoBase = Console.ReadLine();
            dimensaoBase = dimensaoBase.Replace(".", ",");

            Console.Write("Insira a dimensão da altura do retângulo: ");
            string dimensaoAltura = Console.ReadLine();
            dimensaoAltura = dimensaoAltura.Replace(".", ",");

            if (double.TryParse(dimensaoBase, out double valueBase) && double.TryParse(dimensaoAltura, out double valueAltura))
            {
                Func<double, double, double> Calcular = CalcularArea;
                double resultado = Calcular(valueBase, valueAltura);

                Console.WriteLine($"\nÀrea do retângulo {valueBase}X{valueAltura} = {resultado}m\u00B2");
            }
            else
            {
                Console.WriteLine("\nValores inválidos.");
            }
        }

        private double CalcularArea(double arg1, double arg2)
        {
            return arg1 * arg2;
        }
    }
}
