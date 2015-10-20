using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace PatientData.Models
{
    public class Patient
    {
        /// <summary>
        /// I just need to tell Mongo to map this its _Id, that is what it looks for in every document that you store in the Mongo Database
        /// </summary>
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<Ailment>    Ailments { get; set; }
        public ICollection<Medication> Medications { get; set; }
    }

    public class Medication
    {
        public string Name { get; set; }
        public int   Doses { get; set; }
    }

    public class Ailment
    {
        public string Name { get; set; }
    }
}