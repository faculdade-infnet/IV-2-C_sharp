namespace Aulas
{
    internal class ExemploSelectComplexo
    {
        public void Start()
        {
            List<Pessoa> pessoas = new()
            {
                new() {Nome = "Juca", Sobrenome = "Bala", Cpf = "001.001.001-99" , Idade = 39 },
                new() {Nome = "Tião", Sobrenome = "Veneno", Cpf = "007.007.007-91" , Idade = 43},
                new() {Nome = "Jussara", Sobrenome = "Chumbinho", Cpf = "004.004.004-88" , Idade = 39},
                new() {Nome = "Fulgêncio", Sobrenome = "Fogueira", Cpf = "009.009.009-81" , Idade = 22}
            };

            QuerySyntax(pessoas);
            Console.Write("\n");

            QuerySyntaxNewObject(pessoas);
            Console.Write("\n");

            MethodSyntax(pessoas);
        }

        /// <summary>
        /// Example Prints the values of the list of people using Query Syntax
        /// </summary>
        /// <param name="pessoas"></param>
        public void QuerySyntax(List<Pessoa> pessoas)
        {
            // Query Syntax
            var result = pessoas
                        .Where(p => p.Idade > 35)
                        .Select(s => s)
                        .OrderBy(p => p.Idade).ThenBy(y => y.Nome)
                        .ToList();

            Console.WriteLine("\n");
            PrintValues(result);
        }

        /// <summary>
        /// Example Prints the values of the list of people using Query Syntax with NewObject
        /// </summary>
        /// <param name="pessoas"></param>
        public void QuerySyntaxNewObject(List<Pessoa> pessoas)
        {
            // Query Syntax
            var result = pessoas
                        .Where(p => p.Idade > 40)
                        .Select(s => new { PrimeiroNome = s.Nome, Idade = s.Idade })
                        .ToList();

            Console.WriteLine("\n");

            foreach (var item in result)
            {
                Console.WriteLine($"Nome: {item.PrimeiroNome} / Idade: {item.Idade}");
            }
        }





        /// <summary>
        /// Example Prints the values of the list of people using Method Syntax
        /// </summary>
        /// <param name="pessoas"></param>
        private void MethodSyntax(List<Pessoa> pessoas)
        {
            var result = from p in pessoas
                         where p.Idade > 35
                         orderby p.Idade, p.Nome
                         select p;

            // Valor default = null
            var d = result.Where(p => p.Idade == 37).FirstOrDefault();

            Console.WriteLine("\n");

            foreach (Pessoa item in result)
            {
                Console.WriteLine($"Nome: {item.Nome} / Idade: {item.Idade}");
            }
        }


        /// <summary>
        /// Prints the values of the list of people
        /// </summary>
        /// <param name="result"></param>
        public void PrintValues(List<Pessoa> result)
        {
            foreach (Pessoa item in result)
            {
                Console.WriteLine($"Nome: {item.Nome} / Idade: {item.Idade}");
            }
        }
    }



    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }

        public Pessoa() { }

        public Pessoa(string nome, string sobrenome, string cpf, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            Idade = idade;
        }

    }
}
