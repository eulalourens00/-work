namespace Pattern_Command_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.Run();

            Console.WriteLine();
            invoker.Cancel();
        }
    }
}
