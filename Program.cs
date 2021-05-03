using System;
using System.Collections.Generic;

namespace _netTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strList = new List<string>();
            
            strList.Add("test");
            strList.Add("vv");
            strList.Add("iksetrash");

            foreach(var str in strList){
                 Console.WriteLine(str);
            }

           

        }
    }
}
