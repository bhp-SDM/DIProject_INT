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
            if (student == null)
            {
                throw new ArgumentNullException();
            }

            ThrowsIfInvalidStudentProperty(student);

            repository.Add(student);
        }

        private void ThrowsIfInvalidStudentProperty(Student student)
        {
            if (student.ID <= 0)
                throw new ArgumentException("Invalid ID: ID must be positive");
            if (student.Name == null)
                throw new ArgumentException("Invalid Name: Name is missing");
            if (student.Name == "")
                throw new ArgumentException("Invalid Name: Name cannot be empty");
            if (student.Email == "")
                throw new ArgumentException("Invalid Email: Email cannot be empty");
        }
    }
}
