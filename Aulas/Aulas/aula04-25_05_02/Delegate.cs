namespace Aulas
{
    internal class Delegate
    {
        public delegate void TesteDelegate();
        public delegate void TesteDelegateParameter(string blah);

        internal void Simples()
        {
            Console.WriteLine($"{new string('-', 20)}Delegates primários {new string('-', 20)}");
            Console.WriteLine("Delegate Simples");

            TesteDelegate simplesDelegate = new TesteDelegate(ProcessarTexto);
            simplesDelegate();
        }

        internal void ComParametro()
        {
            TesteDelegateParameter parameterDelegate = new TesteDelegateParameter(ProcessarParametro);
            TesteDelegateParameter outroParameterDelegate = new TesteDelegateParameter(OutroProcessarParametro);
            Console.WriteLine("Delegate com Parâmetro");

            parameterDelegate("Método com parâmetro chamado por delegate");
            outroParameterDelegate("Método diferente com parâmetro, chamado por delegate");

            Console.WriteLine();
        }

        internal void PorFunc()
        {
            Console.WriteLine($"{new string('-', 20)}Delegates por Func {new string('-', 20)}");

            Func<double, double, double> Calcular = Adicionar;
            double resultadoSoma = Calcular(9, 9);

            Console.WriteLine("Delegate: " + resultadoSoma);
            Console.WriteLine($"{new string('-', 20)}Fim Delegates por Func {new string('-', 20)}");

            Console.WriteLine();
        }

        internal void PorFuncAnonimo()
        {
            Console.WriteLine($"{new string('-', 20)}Delegates por Func anônimo {new string('-', 20)}");

            Func<double, double, double> CalcularAnonimo = delegate (double n1, double n2)
            {
                return n1 + n2;
            };

            double resultadoSoma2 = CalcularAnonimo(1, 9);
            Console.WriteLine("Delegate anônimo: " + resultadoSoma2);
            Console.WriteLine($"{new string('-', 20)}Fim Delegates por Func anônimo {new string('-', 20)}");
        }

        public static void ProcessarTexto()
        {
            Console.WriteLine("Método chamado através de delegate");
        }

        public static void ProcessarParametro(string blah)
        {
            Console.WriteLine(blah);
        }

        public static void OutroProcessarParametro(string blah)
        {
            Console.WriteLine(blah);
        }

        private static double Adicionar(double n1, double n2)
        {
            return n1 + n2;
        }
    }
}
