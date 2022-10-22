using MongoDB.Bson.Serialization.Attributes;

namespace Blazor_Control_Work.Data
{
    [BsonIgnoreExtraElements]
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
