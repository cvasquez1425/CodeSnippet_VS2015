using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using LINQ.Entities;

namespace Bootstrap.DataContext
{
    public class DataDrivenDb: DbContext
    {
        public DataDrivenDb() :base("DefaultConnection")
        {

        }

        public DbSet<PDSAMenuItem1> PDSAMenuItem1s { get; set; }
        public DbSet<PDSAMenuItemManager1> PDSAMenuItemManager1s { get; set; }

    }
}