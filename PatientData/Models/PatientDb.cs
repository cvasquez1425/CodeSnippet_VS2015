using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;

namespace PatientData.Models
{
    public static class PatientDb
    {
        public static IMongoCollection<Patient> Open()
        {
            var client = new MongoClient("mongodb://localhost");  // in order to connect to Mongo I need a MongoClient and I want to connect to a server running here on my machine on local host.
            //var server = client.GetServer();     part of the old API, simply call GetDatabase directly on the client to get an IMongoDatabase and GetCollection on it to get an IMongoCollection
            var db = client.GetDatabase("PatientDb");
            var collection = db.GetCollection<Patient>("Patients");
            return collection;
        }
    }
}