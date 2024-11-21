using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BDwAS_projekt.Models;

public class Rating()
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    [Key]
    public string Id { get; set; }

    public int Value { get; set; }

    [BsonIgnore]
    public Post Post { get; set; }

    [BsonIgnore]
    public User Author { get; set; }

    [NotMapped]
    public string AuthorId { get; set; }
}