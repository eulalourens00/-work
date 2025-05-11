namespace _35Pract_Bridge_Pattern_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWindowImp msImp = new MSWindowImp();
            IWindowImp macImp = new MacWindowImp();

            Window msWindow = new MSWindow(msImp);
            Window macWindow = new MacWindow(macImp);
            Window msWindowWithMacImp = new MSWindow(macImp);
            Window macWindowWithMsImp = new MacWindow(msImp);

            msWindow.Draw();
            Console.WriteLine();

            macWindow.Draw();
            Console.WriteLine();

            msWindowWithMacImp.Draw();
            Console.WriteLine();

            macWindowWithMsImp.Draw();
        }
    }
}
