//using PatientData.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using MongoDB.Driver.Linq;
//using MongoDB.Bson;
//using System.Threading.Tasks;

//namespace PatientData
//{
//    public static class MongoConfig
//    {
//        //public async static Task<Patient> Seed()
//        //{
//        //    var patients = PatientDb.Open();

//            //To insert multiple documents, you can use the InsertManyAsync method.
//            var documents = Enumerable.Range(0, 100).Select(i => new BsonDocument("counter", i));

//            //I can take a Mongo Collection, turn it into something that is Querable, and then I can run LINQ statements against it. 
//            //if (!patients.AsQueryable().Any(p => p.Name == "Scott"))
//            //{
//                //var data = new List<Patient>()
//                //{
//                //new Patient { Name = "Scott",
//                //              Ailments    = new List<Ailment>() { new Ailment {Name = "Crazy" }},
//                //              Medications = new List<Medication> { new Medication { Name = "Aspirin", Doses = 2 }}
//                //            },
//                //new Patient { Name = "Joy",
//                //              Ailments    = new List<Ailment>() { new Ailment {Name = "Loco"}},
//                //              Medications = new List<Medication> { new Medication {Name = "Aspirin", Doses = 3}}
//                //            },
//                //new Patient { Name = "Sarah",
//                //              Ailments    = new List<Ailment>() { new Ailment {Name = "Cucu"}},
//                //              Medications = new List<Medication> { new Medication {Name = "Tylenol", Doses = 4}}
//                //            }
//                //};
////                patients.InsertManyAsync(data);

//            //var document = new BsonDocument ( "Name", "Scott" );
//            //var document = new Patient { 
//            //                                {"Name", "Scott"}
//            //                            };

//            //await patients.InsertOneAsync(document);

//        }             
//    }
//}