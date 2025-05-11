using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37Pract_Composite_Pattern_
{
    public class Graphic : IGraphic
    {
        private string _name;

        public Graphic(string name)
        { _name = name; }
  
        public void Draw()
        { Console.WriteLine($"Рисуем графический элемент: {_name}");}

        public void Add(IGraphic graphic)
        { throw new NotImplementedException("Нельзя добавить элемент к простому графическому объекту");}

        public void Remove(IGraphic graphic)
        { throw new NotImplementedException("Нельзя удалить элемент из простого графического объекта");}

        public IGraphic GetChild(int index)
        { throw new NotImplementedException("Простые графические объекты не содержат дочерних элементов");}
    }
}
