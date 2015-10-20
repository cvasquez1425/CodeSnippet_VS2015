namespace Linq_EntityFramework_part1
{
    using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

    public class MovieReviews : DbContext
    {
        // Your context has been configured to use a 'MovieReviews' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Linq_EntityFramework_part1.MovieReviews' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MovieReviews' 
        // connection string in the application configuration file.
        public MovieReviews()
            : base("name=MovieReviews")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }

    }

    public class Movie
    {
        // Primary Key  Code First infers is a primary key if a property on a class is named "ID" (not case sensitive), or the class name followed by "ID"
        public int MovieID            { get; set; }
        public string Title           { get; set; }
        public DateTime Release_Date  { get; set; }

        // Navigation Properties
        public virtual ICollection<Review> Reviews { get; set; } 
    }

    public class Review
    {
        // Primary Key
        public int ReviewID   { get; set; }

        public string Summary  { get; set; }
        public int Rating      { get; set; }
        public string Comment   { get; set; }
        public string Reviewer { get; set; }

        // Foreign Key
        public int MovieID { get; set; }
    }
}