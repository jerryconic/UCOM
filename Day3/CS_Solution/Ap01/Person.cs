using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ap01
{
    class Person
    {
        //field, member variable(成員變數)
        private string _id, _name;

        //method(方法:操作類別的方法)
        public void Display()
        {
            Console.WriteLine($"Id:{_id}, Name:{_name}");
        }

        //Constructor(建構函式)
        public Person(string id, string name)
        {
            _id = id;
            _name = name;
        }
        
    }
}
