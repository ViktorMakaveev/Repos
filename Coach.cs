using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Coach:Person
    {
       public Coach(string name,int age):base(name,age) 
        {
            Name = name;
            Age = age;
        }
    }
}
