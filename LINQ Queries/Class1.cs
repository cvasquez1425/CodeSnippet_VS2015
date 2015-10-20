using System;
using System.Collections.Generic;
using System.Linq;/// if we remove the using.system.Linq directive from our program, the query would not compile, because the Where, OrderBy, and Select methods would have nowhere to bind.
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.IO;

namespace LINQ_Queries
{
    public class Class1
    {
        static void Main()
        {
            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

            Regex wordCounter = new Regex(@"\b(\w|[-'])+\b");

            IEnumerable<string> query =
                from n in names
                where n.Contains("a")           // Filter elements
                orderby n.Length                // Sort elements
                select n.ToUpper();             // Translate each element (projection)

            //foreach (string name in query) 
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadKey();

            //SubQuery
            IEnumerable<string> outerQuery = names
                            .Where(n => n.Length == names.OrderBy(n2 => n2.Length)
                                                        .Select(n2 => n2.Length).First());
            // We can avoid this inefficiency by running the subquery separately ( so that it's no longer a subquery)
            int shortest = names.Min(n => n.Length);

            IEnumerable<string> query2 = from n in names
                                        where n.Length == shortest
                                        select n;

            // Composition Strategies - Progressive Query Building
            IEnumerable<string> query3 = names
                .Select(n => Regex.Replace(n, "[aeiou]", ""))
                .Where(n => n.Length > 2)
                .OrderBy(n => n);


            // Projection Strategies
            IEnumerable<TempProjectionItem> temp = from n in names
                                                   select new TempProjectionItem
                                                   {
                                                       Original = n,
                                                       Vowelless = n.Replace("a", "").Replace("e", "").Replace("i", "")
                                                                   .Replace("o", "").Replace("u", "")
                                                   };
            // the result is of Type IEnumerable<TempProjectionItem>, which we can subsequently query:
            IEnumerable<string> queryProjection = from item in temp
                                                  where item.Vowelless.Length > 2
                                                  select item.Original;
            //foreach (var item in queryProjection)
            //{
            //    Console.WriteLine(item);    // Dick, Harry, Mary
            //}

            // With Anonymous Types, we can eliminate the TempProjectionItem class
            // Anonymous types allow you to structure your intemediate results without writing special classes.
            var intermediate = from n in names
                               select new
                               {
                                   Original = n,
                                   Vowelless = n.Replace("a", "").Replace("e", "").Replace("i", "")
                                               .Replace("o", "").Replace("u", "")
                               };

            //IEnumerable<string> queryAnonymous = from item in intermediate
            //                                     where item.Vowelless.Length > 2
            //                                     select item.Original;
//            foreach (var item in queryProjection)
//            {
//                Console.WriteLine(item);    // Dick, Harry, Mary
//            }

            // IQueryable Implementation LINQ to SQL Sample code
            string ConnectionString = "Data Source=gm-atl-tessdb;Initial Catalog=tess_dev;User ID=sa;Password=t3sspr0d@dm1n;";
            DataContext dataContext = new DataContext(ConnectionString);
            Table<state> states = dataContext.GetTable<state>();

            IQueryable<string> queryState = from c in states
                                            where   c.state_name.Contains("a")
                                            orderby c.state_name.Length
                                            select  c.state_name.ToUpper();

            //foreach (string name in queryState)
            //{
            //    Console.WriteLine(name);
            //}


            // Select Subqueries and Object Hierarchies
            DirectoryInfo[] dirs = new DirectoryInfo(@"c:\Users\u748\Documents").GetDirectories();

            var queryDirs = from d in dirs
                            where (d.Attributes & FileAttributes.System) == 0
                            select new
                                {
                                    DirectoryName = d.FullName,
                                    Created = d.CreationTime,

                                    Files = from f in d.GetFiles()        // the inner portion of this query can be called a correlated subquery. it is correlated because it references an object in the outer query -- in this case, it references d.
                                            where (f.Attributes & FileAttributes.Hidden) == 0
                                            select new { FileName = f.Name, f.Length, }
                                };

            foreach (var dirFiles in queryDirs)
            {
                Console.WriteLine("Directory: " + dirFiles.DirectoryName);
                foreach (var file in dirFiles.Files)
                {
                    Console.WriteLine(" " + file.FileName + " Len: " + file.Length);
                }
            }

            Console.ReadKey();

        }
    }


    [Table] public class state
    {
        [Column(IsPrimaryKey=true)] public int state_id;
        [Column]               public string state_name;
        [Column]               public string state_code;
 
    }

    public class TempProjectionItem
    {
        public string Original { get; set; }
        public string Vowelless { get; set; }
    }

}
