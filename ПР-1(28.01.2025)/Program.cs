using System.ComponentModel;

namespace ПР_1_28._01._2025_
{
    internal class Program
    {
        // 1.
         static void number(){
            string user_number; Console.Write("Enter number: ");
            user_number = Console.ReadLine();            
            Console.WriteLine($"You entered {user_number}");
            // Convert.ToInt32 если нужно имеено int
         }
        // 2. 
        static void number2()
        {
            string user_number2;
            Console.Write("Enter number: "); user_number2 = Console.ReadLine();
            Console.WriteLine($"{user_number2} - it is your number");
        }
        // 3.
        static void square()
        {
            string side;
            int int_side; int perimetr;
            Console.Write("Enter a side of square: "); side = Console.ReadLine();
            int_side = Convert.ToInt32(side); perimetr = int_side * 4;
            Console.WriteLine($"Perimetr is {perimetr}");
        }
        // 4.
        static void diametr() {
                string r; int r_side;
                int diamtr; Console.Write("Enter radius: ");
                r = Console.ReadLine();            r_side = Convert.ToInt32(r );
                diamtr = r_side* 2;
                Console.WriteLine($"Radius is {r} and Diametr is {diamtr}");        
        }
        // 5.
        static void plotnost()
        {
            string m, v;
            double _m, _v; double _p;
            Console.Write("Enter M: "); m = Console.ReadLine();
            Console.Write("Enter V: "); v = Console.ReadLine();
            _m = Convert.ToDouble(m); _v = Convert.ToDouble(v);
            _p = _m / _v;
            Console.WriteLine($"Plotnost is {_p}. p = {_m} / {_v}");
        }
        // 6.
        static void trapet()
        {
            string osn1, osn2, hight;
            double _osn1, _osn2, _hight; double _perm;
            Console.Write("Enter the fisrt osnovanie: "); osn1 = Console.ReadLine();
            Console.Write("Enter the second osnovanie: "); osn2 = Console.ReadLine();
            Console.Write("Enter hight: "); hight = Console.ReadLine();
            _osn1 = Convert.ToDouble(osn1); _osn2 = Convert.ToDouble(osn2);
            _hight = Convert.ToDouble(hight);
            _perm = ((_osn1 + _osn2) / 2) * _hight; Console.WriteLine($"Result is {_perm}");
        }
        // 7.
         static void tonns(){
            string kg; int _kg;
            Console.Write("How much kg: "); 
            kg = Console.ReadLine();
            _kg = Convert.ToInt32(kg);
            _kg /= 1000;
            Console.WriteLine($"{_kg} tonns");
        }
        // 8.
        static void kilometrs(){
            string km; int _km;
            Console.Write("How much km: "); km = Console.ReadLine();
            _km = Convert.ToInt32(km); _km /= 1000;
            Console.WriteLine($"{_km} km");
         }
        // 9.
         static void dv_number(){
            Console.Write("Enter a two-digit number: "); 
            string t_d = Console.ReadLine();
            int t_digit = int.Parse(t_d);

            while (t_digit > 0){
                int des = t_digit / 10;
                Console.WriteLine($"Desyatkov is {des}"); 
                int ed = t_digit % 10;
                Console.WriteLine($"Edinits is {ed}");

                Console.WriteLine($"Summa is {des + ed}");
                Console.WriteLine($"Mult is {des * ed}");
                break;
            }
        }

        //10.
        static void threen()
        {
            Console.Write("Enter xxx number: ");
            string str = Console.ReadLine();
            int three = int.Parse(str);

            if (three < 99 || three > 1000)
            {
                Console.WriteLine("Invalid.");
            }

            string result = " ";
            while (three > 0)
            {
                result += three % 10;
                three /= 10;
            }
            Console.WriteLine($"{str} = {result}");
        }
        static void Main(string[] args)
        {
            // 1.
            number();
            // 2.
            number2();
            // 3. 
            square();
            // 4.
            diametr();
            // 5.
            plotnost();
            // 6.
            trapet();
            //7.
            tonns();
            //8.
            kilometrs();
            //9.
            dv_number();
            //10.
            threen();

        }
    }    
}
