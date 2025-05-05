using System;
using System.Threading;


namespace TP1
{
    internal class Exercicio_05
    {
        internal void Start()
        {            
            DownloadManager downloadManager = new DownloadManager();
            downloadManager.DownloadCompleted += DownloadConcluido;
            
            Console.WriteLine("Iniciando o download...");
            downloadManager.IniciarDownload();
            
            Console.ReadKey();
        }
        
        void DownloadConcluido()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nDownload concluído com sucesso!");
            Console.ResetColor();
        }
    }
}
