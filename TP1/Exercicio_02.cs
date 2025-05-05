using System;
using System.Collections.Generic;


namespace TP1
{
    internal class Exercicio_02
    {
        internal void Start()
        {
            Console.WriteLine("Escolha um idioma (pt, en, es): ");
            string idioma = Console.ReadLine()?.Trim().ToLower();

            ExibirMensagem(idioma, "Samuel Hermany");

            Console.ReadKey();
        }

        void ExibirMensagem(string idioma, string nome)
        {
            // Dicionário com as ações encapsuladas em Action<string>
            Dictionary<string, Action<string>> mensagens = new Dictionary<string, Action<string>>
            {
                { "pt", MensagemPortugues },
                { "en", MensagemIngles },
                { "es", MensagemEspanhol }
            };

            if (mensagens.TryGetValue(idioma, out Action<string> mensagem))            
                mensagem(nome); // Chama o delegate            
            else            
                Console.WriteLine("Idioma não suportado. Use pt, en ou es.");            
        }

        void MensagemPortugues(string nome) => Console.WriteLine($"Bem-vindo, {nome}!");

        void MensagemIngles(string nome) => Console.WriteLine($"Welcome, {nome}!");

        void MensagemEspanhol(string nome) => Console.WriteLine($"¡Bienvenido, {nome}!");
    }
}
