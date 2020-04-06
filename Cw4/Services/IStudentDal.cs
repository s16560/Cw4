using System.Collections.Generic;

namespace Cw4.Services
{
    public interface IStudentsDal
    {
        public IEnumerable<Student> GetStudents();
        public IEnumerable<Student> GetStudent(string indexNumber);
    }

}

