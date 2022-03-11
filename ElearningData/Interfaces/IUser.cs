using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ElearningModels.Interfaces
{
    public interface IUser
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("username")]
        public string Username { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        public string Icon  { get; set; }

        public enum Role
        {
            Guest,
            Student,
            Teacher,
            Admin
        }
    }
}
