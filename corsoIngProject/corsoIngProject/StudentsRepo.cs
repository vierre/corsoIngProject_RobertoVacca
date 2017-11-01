using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using corsoIngProject.Dal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace corsoIngProject
{
    public class StudentsRepo : IStudentsRepo
    {

        private readonly MongoDbContext dbContext = null;

        public StudentsRepo(IOptions<Settings> options)
        {
            this.dbContext = new MongoDbContext(options);
        }

        public async Task<CreatedResult> CreateStudent(Student student)
        {
            await this.dbContext.Students.InsertOneAsync(student);
            return new CreatedResult("mongodb", true);
        }

        public async Task DeleteAllStudents()
        {
            await dbContext.Students.DeleteManyAsync(new BsonDocument());
        }

        public async Task DeleteStudent(Guid Id)
        {
            await dbContext.Students.DeleteOneAsync(s => s.Id.Equals(Id));
        }

        public async Task<Student> GetStudent(Guid Id)
        {
            var result = await dbContext.Students.FindAsync(s => s.Id.Equals(Id));
            return result.FirstOrDefault();
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            var result =  await dbContext.Students.AsQueryable().ToListAsync();
            return result;
        }

        public async Task UpdateStudent(Student student)
        {
            await dbContext.Students.ReplaceOneAsync(s => s.Id.Equals(student.Id), student);
        }
    }
}
