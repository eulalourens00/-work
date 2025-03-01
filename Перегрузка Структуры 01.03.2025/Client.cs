using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перегрузка_Структуры_01._03._2025
{
    public struct Client
    {
        public int CodeClient;
        public string ClientFirstName;
        public string ClientLastName;
        public string AdressClient;
        public int PhoneClient;
        public int Orders;
        public double SummaOrders;

        public ClientType Type;

        public Client(int code, string fname, string lname, string adress, int phone, int orders, double summa, ClientType type)
        {
            CodeClient = code;
            ClientFirstName = fname;
            ClientLastName = lname;
            AdressClient = adress;
            PhoneClient = phone;
            Orders = orders;
            SummaOrders = summa;
            Type = type;
        }

        public override string ToString()
        {
            return $" Code: {CodeClient}\n Name: {ClientFirstName} {ClientLastName}\n Position: {Type}";
        }
    }
    public enum ClientType
    {
        MainAdmin, Admin, UserPro, UserSimple, NoName
    }
}
