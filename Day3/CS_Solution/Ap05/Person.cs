using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ap05
{
    class Person
    {
        //field, member variable(成員變數)
        protected string _id, _name;

        //method(方法:操作類別的方法)
        public virtual void Display()
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

    class Employee: Person
    {
        private int _salary;
        public Employee(string id, string name, int salary) : base(id, name)
        {
            _salary = salary;
        }
        public override void Display()
        {
            Console.WriteLine($"Id:{_id}, Name:{_name}, Salary:{_salary}");
        }
    }
}
