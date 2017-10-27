using corsoIngProject.Dal;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace corsoIngProject
{
    interface IStudentsRepo
    {
        Task<IEnumerable<Student>> GetStudents();
        Task<Student> GetStudent(Guid Id);
        Task<CreatedResult> CreateStudent(Student student);
        Task DeleteStudent(Guid Id);
        Task UpdateStudent(Student student);
        Task DeleteAllStudents(); 
    }
}
