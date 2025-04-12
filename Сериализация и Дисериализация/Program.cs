using System.Xml.Serialization;
using System.Text.Json;

namespace Сериализация_и_Дисериализация
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person("Ivan", 20);
            //XmlSerializer serializer = new XmlSerializer(typeof(Person));

            //using (FileStream fs = new FileStream("person.xml", FileMode.OpenOrCreate))
            //{
            //    serializer.Serialize(fs, person);
            //    Console.WriteLine("Object has been serialized.");
            //}
            //using (FileStream fs = new FileStream("person.xml", FileMode.Open))
            //{
            //    Person p = serializer.Deserialize(fs) as Person;
            //    Console.WriteLine(p);
            //}

            //List<Person> list = new List<Person>()
            //{
            //    new Person(){Name = "Leeky", Age = 17},
            //    new Person(){Name = "Suya", Age = 16},
            //    new Person(){Name = "Poor", Age = 21}
            //};

            //XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Person>));

            //try
            //{
            //    using (Stream fs = File.Create("test.xml"))
            //    {
            //        xmlFormat.Serialize(fs, list);
            //    }
            //    Console.WriteLine("XmlSerialize OKAY\n");
            //    List<Person> pers = null;
            //    using (Stream fs = File.OpenRead("test.xml"))
            //    {
            //        list = (List<Person>)xmlFormat.Deserialize(fs);
            //    }
            //    foreach (Person item in list) { Console.WriteLine(item); }
            //}
            //catch (Exception ex) { Console.WriteLine(ex.Message); }

            //Person ivan = new Person("Ivan", 17);
            //string json = JsonSerializer.Serialize(ivan);
            //Console.WriteLine(json);

            //Person? res = JsonSerializer.Deserialize<Person>(json);
            //Console.WriteLine(res?.Name);


            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            using(FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
            {
                Person ivan = new Person("Ivan", 17);
                JsonSerializer.Serialize<Person>(fs, ivan);
                Console.WriteLine("Save");
            }
            using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
            {
                Person? res = JsonSerializer.Deserialize<Person>(fs);
                Console.WriteLine($"{res.Name} - {res.Age}");
            }
        }
    }
}
