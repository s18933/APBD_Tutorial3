using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_3.Models;

namespace Task_3.DAL
{
    public class MockDbService : IDbService
    {
        private static IEnumerable<Student> _students;

        static MockDbService() 
        {
            _students = new List<Student>
            {
                new Student{IdStudent = 1, FirstName="Jan", LastName="Kowalski"},
                new Student{IdStudent = 2, FirstName="Anna", LastName="Malewski"},
                new Student{IdStudent = 3, FirstName="Andrzei", LastName="Andrzejewicz"}
            };
        }
        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}
