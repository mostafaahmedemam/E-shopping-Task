using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace E_Shopping_App.Entities
{
   
    public class Product 
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }   
        public string Name { get; set; }    
        public string Type { get; set; }
        public string Size { get; set; }
        
    }

}