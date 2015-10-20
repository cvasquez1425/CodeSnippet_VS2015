using Books.Entities;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Books.Web.DataContexts
{
    public class BooksDb : DbContext
    {
        public BooksDb()
            :base("DefaultConnection")
        {
            // Logging. I do that in the constructor, so every instance goes thru this
            Database.Log = sql => Debug.Write(sql);  //it'll appear in the VS Debug output when I am running with the debugger in the system.Diagnostics Namespace
        }

        /// <summary>
        /// I can override OnModelCreating and I can tell the model builder that everything on this DbContext has a DEFAULT Schema which is no DBO, it'll be the library schema
        /// </summary>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("library");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Book> Books { get; set; }
    }
}