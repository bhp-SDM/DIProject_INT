using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIProject_INT.Model
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }

        public Student()
        { }

        public Student(int id, string name, string email)
        {
            ID = id;
            Name = name;
            Email = email;
        }
    }

}
