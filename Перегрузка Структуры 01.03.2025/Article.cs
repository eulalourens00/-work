using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перегрузка_Структуры_01._03._2025
{
    public struct Article
    {
        public int CodeGoods;
        public string NameGoods;
        public double Cost;
        public ArticleType Type;

        public Article(int codeGoods, string nameGoods, double cost, ArticleType type)
        {
            CodeGoods = codeGoods;
            NameGoods = nameGoods;
            Cost = cost;
            Type = type;
        }
        public override string ToString()
        {
            return $" Code: {CodeGoods}\n Name: {NameGoods}\n Cost: {Cost}\n Type: {Type}";
        }
    }
    public enum ArticleType 
    { 
        Food, Books, Clothing, Electronics, Other
    }
}
