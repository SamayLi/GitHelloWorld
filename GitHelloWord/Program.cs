using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitHelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //string helloWord = "Hello World!!!";
            //Console.WriteLine(helloWord);

            Person p = new Person("小李",21);
            p.getPerson();
            Console.ReadLine();
        }
    }
}
