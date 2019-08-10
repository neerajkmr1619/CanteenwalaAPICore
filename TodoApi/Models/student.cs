using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace TodoApi.Controllers
{
  public class Student
  {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("name")]
    public string Name { get; set; }
    [BsonElement("email")]
    public string Email{get; set;}
    [BsonElement("contact")]
    public string Contact{get;set;}
    [BsonElement("courseCount")]
    public BsonDouble CourseCount{get;set;}
    [BsonElement("isVerified")]
    public BsonBoolean IsVerified{get;set;}

  }
}