using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Midfield:FootballPlayer
    {
       public Midfield(string name, int number, int age, double height) : base(name, number, age, height)
        {
            Name = name;
            Number = number;
            Age = age;
            Height = height;
        }
    }
}
