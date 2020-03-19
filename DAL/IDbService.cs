using System.Collections.Generic;
using cw3___v2.Models;

namespace cw3___v2.DAL
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}