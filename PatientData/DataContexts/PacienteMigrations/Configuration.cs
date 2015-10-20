namespace PatientData.DataContexts.PacienteMigrations
{
using Pacientes.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PatientData.Models.PacienteDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DataContexts\PacienteMigrations";
        }

        protected override void Seed(PatientData.Models.PacienteDb context)
        {
                    //  This method will be called after migrating to the latest version.
                    
                    var data = new List<Paciente>()
                    {
                        new Paciente { Name = "Scott",
                                       Ailments    =  new List<Ailment>()    { new  Ailment { Name = "Crazy"}},
                                       Medications =  new List<Medication>() { new Medication {   Name = "Aspirin", Doses = 1}}
                        }
                    };

                    //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
                    //  to avoid creating duplicate seed data. E.g.
                    context.Pacientes.AddOrUpdate(p => p.Name,
                                new Paciente()
                                {
                                    Name = "Scott",
                                    Ailments = new List<Ailment>() { new Ailment {Name = "Crazy" } },
                                    Medications = new List<Medication>() { new Medication {  Name = "Aspirin", Doses = 1 } }
                                },
                                new Paciente()
                                {
                                    Name = "Jane",
                                    Ailments = new List<Ailment>() { new Ailment { Name = "Crazy" } },
                                    Medications = new List<Medication>() { new Medication { Name = "Tylennol", Doses = 2 } }
                                },
                                new Paciente()
                                {
                                    Name = "Sarah",
                                    Ailments = new List<Ailment>() { new Ailment { Name = "Crazy" } },
                                    Medications = new List<Medication>() { new Medication { Name = "Advil", Doses = 3 } }
                                }
                    );
        }
    }
}
