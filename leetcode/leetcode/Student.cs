using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    public class Student
    {
        private string _name ;
        public string Name { get; set; }
        //public string Name
        //{
        //    get
        //    {
        //        return _name;
        //    }
        //    set
        //    {
        //        _name = value;
        //    }
        //}
        public int age { get; set; }
        public Student(string Name)
        {
            Console.WriteLine("Hello A New Student Has Been Inicialized ");
            Console.WriteLine($"His Name Is {Name}");
        }
    }
}
