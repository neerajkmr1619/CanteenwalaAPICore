using System;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using TodoApi.Controllers;

namespace TodoApi.Services
{
 public class Services
 {
     private readonly IMongoCollection<Student> _student;
     public Services(IStudentDatabaseSettings settings)
     { 
         var client = new MongoClient(settings.ConnectionString);
         var database = client.GetDatabase(settings.DatabaseName);
         _student = database.GetCollection<Student>(settings.StudentCollectionName);
     }

     public List<Student> Get() =>
            _student.Find(student => true).ToList();

     public Student Get(string id) =>
            _student.Find<Student>(student => student.Id == id).FirstOrDefault();

        public Student Create(Student student)
        {
            _student.InsertOne(student);
            return student;
        }

        public void Update(string id, Student studentIn) =>
            _student.ReplaceOne(student => student.Id == id, studentIn);

        public void Remove(Student studentIn) =>
            _student.DeleteOne(student => student.Id == studentIn.Id);

        public void Remove(string id) => 
            _student.DeleteOne(student => student.Id == id);       
 }
}