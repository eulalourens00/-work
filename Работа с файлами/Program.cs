namespace Работа_с_файлами
{
    //Для работы с папками (каталогами)
    //Directory DirectoryInfo

    //Для работы с файлами
    //FileInfo Info
    internal class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo dir = new DirectoryInfo(".");
            //Console.WriteLine ($"Full path to the directory:\n{dir.FullName}");
            //Console.WriteLine($"Time of creation: {dir.CreationTime}");

            //Console.WriteLine("\n\tAll directory files:");
            //FileInfo[] files = dir.GetFiles(); //все файлы из каталога

            //foreach (FileInfo file in files) { Console.WriteLine(file.Name); }

            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives) { 
                Console.WriteLine(drive.Name);
                Console.WriteLine(drive.DriveType);

                if (drive.IsReady)
                {
                    Console.WriteLine(drive.TotalSize);
                    Console.WriteLine(drive.TotalFreeSpace);
                    Console.WriteLine(drive.VolumeLabel);
                }
            }


            
        }
    }
}
