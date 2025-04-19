using DadosPessoais;
using DadosPessoais.Financeiro;

namespace Aula_07
{
    public class Aula07
    {
        /// <summary>
        /// Metodo para instanciar uma class que tem outro projeto como referencia
        /// </summary>
        internal void InstanciaDeClass()
        {
            Console.WriteLine("\n########### Instancia de Class Aula 07 ###########");

            Address endereco = new Address();

            endereco.Logradouro = "Rua Blah";
            endereco.Complemento = "Bloco 1";
            endereco.Bairro = "Centro";

            ContaBancaria contaBancaria = new ContaBancaria();
            contaBancaria.Instituicao = "CEF";
            contaBancaria.Conta = 112233;
            contaBancaria.Digito = 2;
            contaBancaria.Poupanca = false;

            Person pessoa = new Person();
            pessoa.Nome = "Roberval Firmino";
            pessoa.Endereco = endereco;
            pessoa.ContaBancaria = contaBancaria;
            pessoa.Nascimento = new DateTime(1971, 07, 20);

            var (Years, Months, Days) = pessoa.RetornarIdadeCompleta();

            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Idade: {pessoa.RetornarIdade()}");
            Console.WriteLine($"Idade {Years} anos | {Months} meses | {Days} dias");
            Console.WriteLine($"Logradouro: {pessoa.Endereco.Logradouro} | Bairro: {pessoa.Endereco.Bairro}");
            Console.WriteLine($"Nascimento: {pessoa.Nascimento:d}");
            Console.WriteLine($"Banco: {pessoa.ContaBancaria.Instituicao}");
            Console.WriteLine();
        }
    }
}