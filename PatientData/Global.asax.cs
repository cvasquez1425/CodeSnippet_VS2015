using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using MongoDB.Driver;
using MongoDB.Bson;
using PatientData.Models;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization;

namespace PatientData
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            //GlobalConfiguration.Configuration.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);

            BsonClassMap.RegisterClassMap<Patient>(cm =>
            {
                cm.MapMember(c => c.Id);
                cm.MapMember(c => c.Name);
                cm.MapMember(c => c.Ailments);
                cm.MapMember(c => c.Medications);
            });

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // to see the db with some initial data when the application starts up
            //MongoConfig.Seed();
        }
    }
}
