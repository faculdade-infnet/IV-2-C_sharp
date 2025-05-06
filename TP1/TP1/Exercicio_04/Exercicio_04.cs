using System;


namespace TP1
{
    internal class Exercicio_04
    {
        internal void Start()
        {
            TemperatureSensor sensor = new TemperatureSensor();
            sensor.TemperatureExceeded += AlertaTemperatura;

            Console.WriteLine("Digite as leituras de temperatura (digite 'sair' para encerrar):");

            while (true)
            {
                Console.Write("Temperatura: ");
                string entrada = Console.ReadLine()?.Trim().ToLower();

                if (entrada == "sair")
                {
                    Console.WriteLine("\nPrograma encerrado. Obrigado por usar o sistema de monitoramento.");
                    break;
                }

                if (double.TryParse(entrada.Replace(".", ","), out double temp))
                {
                    sensor.LerTemperatura(temp);
                }
                else
                {
                    Console.WriteLine("Valor inválido. Tente novamente.");
                }
            }
        }

        private void AlertaTemperatura(double temperatura)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nALERTA: Temperatura crítica registrada: {temperatura}°C\n");
            Console.ResetColor();
        }
    }
}
