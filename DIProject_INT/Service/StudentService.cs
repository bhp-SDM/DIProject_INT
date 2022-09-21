using DIProject_INT.Interfaces;
using DIProject_INT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIProject_INT.Service
{
    public class StudentService
    {
        private IStudentRepository repository;

        public StudentService(IStudentRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException();
            }

            this.repository = repository;
        }

        public void AddStudent(Student student)
        {
            repository.Add(student);
        }
    }
}
