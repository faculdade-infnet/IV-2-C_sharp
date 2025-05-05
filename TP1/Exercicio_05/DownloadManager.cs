using System;
using System.Threading;

namespace TP1
{
    internal class DownloadManager
    {
        public event Action DownloadCompleted;
        
        public void IniciarDownload()
        {
            // Simula o tempo do download (5 segundos)
            int tempoTotal = 10; // tempo em segundos
            for (int i = 1; i <= tempoTotal; i++)
            {
                Console.WriteLine($"Baixando... {i * 10}%");
                Thread.Sleep(1000); // espera 1 segundo
            }

            // Após o "download" ser concluído, dispara o evento
            OnDownloadCompleted();
        }

        // Dispara o método DownloadConcluido
        void OnDownloadCompleted()
        {
            DownloadCompleted?.Invoke();
        }
    }
}
