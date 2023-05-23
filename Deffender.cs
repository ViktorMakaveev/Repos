using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Deffender:FootballPlayer
    {
       public Deffender(string name, int number, int age, double height) : base(name, number, age, height)
        {
            Name = name;
            Number = number;
            Age = age;
            Height = height;
        }
    }
}
