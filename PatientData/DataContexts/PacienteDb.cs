using Pacientes.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PatientData.Models
{
    public class PacienteDb : DbContext
    {
        public PacienteDb()
               :base("DefaultConnection")
        {
            Database.Log = sql => Debug.Write(sql);     // it's also useful to see the SQL queries that EF generates. To trace the SQL, add the following line of code to the constructor.
        }

        public DbSet<Paciente> Pacientes { get; set; }
    }
}