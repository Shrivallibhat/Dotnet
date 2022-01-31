using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs
   
{
    class Program
    {
        class ComparisionEquals
        {
            static void Main4(string[] args)
            {
                string name = "Shrivalli";
                string Myname = name;

                var doubleeql = (name == Myname);//true
                var eql = name.Equals(Myname);//true
                Console.WriteLine(doubleeql);
                Console.WriteLine(eql);
                Console.WriteLine("====================================");
                object nameObj = "Shrivalli";
                char[] values = { 'S', 'h', 'r', 'i', 'v', 'a','l','l','i' };
                object myName = new string(values);
                var doubleeql2 = (nameObj == myName);//false
                var eql2 = nameObj.Equals(myName);//true
                Console.WriteLine(doubleeql2);
                Console.WriteLine(eql2);
            }
        }
    }
}
