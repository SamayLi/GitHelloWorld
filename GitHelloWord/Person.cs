using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitHelloWord
{
    class Person
    {
        string name;
        int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void getPerson()
        {
            Console.WriteLine(this.name+"的年龄为："+this.age);
        }
    }
}
