namespace Pattern_Интерпритатор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Interoreter
            Context context = new Context
            {
                Vocabulary = 'a',
                Source = "aaa"
            };

            var expression = new NonterminalExpression();
            expression.Interpret(context);
            Console.WriteLine(context.Result);
        }
    }
}
