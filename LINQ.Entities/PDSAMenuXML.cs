using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Entities
{
    /// <summary>
    /// Base Class for all "Injector" classes.
    /// </summary>
    public abstract class PDSAMenuXML
    {
        public PDSAMenuXML()
        {

        }
        
        public string Location { get; set; }

        public abstract List<PDSAMenuItem1> Load();
    }
}
