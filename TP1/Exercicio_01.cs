using System;


namespace TP1
{
    internal class Exercicio_01
    {
        public delegate double CalculateDiscount(double value);
        internal void Start()
        {

            Console.Write("Informe o preço original do produdo: ");
            string precoOriginal = Console.ReadLine();
            precoOriginal = precoOriginal.Replace(".", ",");

            if (double.TryParse(precoOriginal, out double preco))
            {
                // Corrigido: passa referência do método, sem invocá-lo
                CalculateDiscount parameterDelegate = new CalculateDiscount(CalcularDesconto);

                // Chama o delegate e imprime o resultado
                double precoFinal = parameterDelegate(preco);
                Console.WriteLine($"Valor final com desconto: {precoFinal:F2}");
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }


            Console.ReadKey();
        }

        private double CalcularDesconto(double value)
        {
            return value * 0.9;
        }
    }
}
