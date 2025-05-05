namespace Aulas
{
    internal class TiposSyntax
    {
        public void Start()
        {
            QuerySyntax();
            Console.Write("\n");
            MethodSyntax();
        }

        public void QuerySyntax()
        {
            Console.Write("Query Syntax\n");

            int[] values = [18, 97, 92, 81, 60];
            IEnumerable<int> resultQuery =
                from value in values
                where value > 80
                select value;

            foreach (int i in resultQuery)
            {
                Console.Write(i + " ");
            }
        }


        public void MethodSyntax()
        {
            Console.Write("\nMethod Syntax\n");

            int[] values = [18, 97, 92, 81, 60];
            IEnumerable<int> resultQuery = values
                                           .Where(v => v > 80)
                                           .Select(v => v);

            foreach (int i in resultQuery)
            {
                Console.Write(i + " ");
            }
        }
    }
}
