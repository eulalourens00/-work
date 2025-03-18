namespace _20_Pract_Classes_WebSite__Journal__Store_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            WebSite webSite = new WebSite();
            webSite.AddData();
            Console.WriteLine(webSite.ToString());
            webSite.GetDiscription();
            webSite.GetID();

            Console.WriteLine();

            //2.
            Magazine magazine = new Magazine();
            magazine.AddData();
            Console.WriteLine(magazine.ToString());
            magazine.GetContact();

            Console.WriteLine();

            //3.
            Store store = new Store();
            store.AddData();
            Console.WriteLine(store.ToString());
            store.GetContact();


        }
    }
}
