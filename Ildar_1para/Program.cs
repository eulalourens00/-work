namespace Ildar_1para
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            //Car car = new Car();
            //car.Move();
            //3.
            //Crow crow = new Crow();
            //crow.Fly();
            //crow.Run();
            //4.
            Warrior charactr = new Warrior("Leeky Suya");
            Enemy mage = new Mage();
            while(charactr.HP > 0 && mage.HP > 0)
            {
                charactr.Attack(mage);
                if (mage.HP <= 0) { Console.WriteLine("Mage is dead!"); break; }

                //mage.Take_Damage(charactr.Power);
                mage.Fight();
                charactr.TakeDamage(mage.Power);

                if(charactr.HP <= 0) { Console.WriteLine("Warrior is dead!"); break; }
            }
        }
    }
}
