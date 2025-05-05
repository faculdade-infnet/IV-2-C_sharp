using System;

namespace TP1
{
    internal class TemperatureSensor
    {
        public delegate void TemperatureExceededHandler(double temperatura);
        public event TemperatureExceededHandler TemperatureExceeded;

        // Dispara o evento se a temperatura for alta
        public void LerTemperatura(double temperatura)
        {
            Console.WriteLine($"Temperatura: {temperatura}°C");

            // dispara o evento
            if (temperatura > 100)
                TemperatureExceeded?.Invoke(temperatura);
        }
    }
}
