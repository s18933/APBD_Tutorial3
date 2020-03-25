using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_3.Models;

namespace Task_3.DAL
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}
