namespace _37Pract_Composite_Pattern_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGraphic circle = new Graphic("Круг");
            IGraphic square = new Graphic("Квадрат");
            IGraphic triangle = new Graphic("Треугольник");

            IGraphic picture1 = new Picture("Изображение 1");
            IGraphic picture2 = new Picture("Изображение 2");
            IGraphic mainPicture = new Picture("Главное изображение");

            picture1.Add(circle);
            picture1.Add(square);

            picture2.Add(triangle);
            picture2.Add(new Graphic("Линия"));

            mainPicture.Add(picture1);
            mainPicture.Add(picture2);
            mainPicture.Add(new Graphic("Кошмар"));

            mainPicture.Draw();

            picture2.Draw();
            mainPicture.GetChild(0).Draw();
        }
    }
}
