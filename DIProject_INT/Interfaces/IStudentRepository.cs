using DIProject_INT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIProject_INT.Interfaces
{
    public interface IStudentRepository
    {
        void Add(Student s);
        void Update(Student s);
        void Delete(Student s);
        List<Student> GetAll();
        Student GetByID(int id);
    }
}
