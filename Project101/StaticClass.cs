using System;
using System.Collections.Generic;
using System.Text;

namespace Project101
{
    public static class StaticClass
    {
        // bu statik metod test edilecek bir başka metot içinde kullanıldığında mocklanamayacağı için bir ara katmana ihtiyaç duyulacaktır. bunun için interfaceten türeyen 
        // bir wrapper class oluşturmak yeterli olacaktır. 
        public static string WriteMessage(string message)
        {
            return message;
        }
    }
}
