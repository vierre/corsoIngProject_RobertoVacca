using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace corsoIngProject.Dal
{
    public class Exam
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Subject { get; set; }
        public DateTime Date { get; set; }
        public int Grade { get; set; }
        public List<string> ArgumentList { get; set; }
    }
}
