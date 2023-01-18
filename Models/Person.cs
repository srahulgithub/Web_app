//using Project2.CustomAttributes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Project2.Models
{
    public class Person
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        [Required]
        public string Name { get; set; }

        [BsonElement("Country")]
        [Required]
        public string Country { get; set; }

    }
}
