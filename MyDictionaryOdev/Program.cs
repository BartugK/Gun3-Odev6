using System;

namespace MyDictionaryOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> staff = new MyDictionary<int, string>();

            staff.Add(1, "Ali");
            staff.Add(2, "Helin");
            staff.Add(3, "Sarper");
            staff.Add(4, "Deniz");
            staff.Add(5, "Şükrü");



            for (int i = 0; i < staff.Key.Length; i++)
            {
                Console.WriteLine("Staff number is : " + staff.Key[i] + ", Employee name is : " + staff.Value[i]);
            }


        }
    }
}
