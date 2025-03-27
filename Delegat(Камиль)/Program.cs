using System.Windows.Forms;
namespace Delegat_Камиль_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.
            Operation operation = new Operation();
            Operation.OperationDelegate sumDelegate = operation.Summa;
            Console.WriteLine($"Sum: {sumDelegate(5, 3)}");

            // 2.
            Filter filter = new Filter();
            filter.Check();

            //3.
            ButtonCL button = new ButtonCL();
            Clicked clicked = new Clicked();
            button.ClickButton += clicked.Message;

            MouseEventArgs mouseEvent = new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0);
            button.ClickMouse(mouseEvent);
        }
    }
}
