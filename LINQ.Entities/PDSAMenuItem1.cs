using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Entities
{
    public class PDSAMenuItem1
    {
        public int    MenuId { get; set; }           // Unique Identifier
        public string MenuTitle { get; set; }        // Menu to Display
        public int    DisplayOrder { get; set; }     // Order in which to display menu
        public string MenuAction { get; set; }       // The route for the <a> tag

        public override string ToString()
        {
            return MenuTitle;
        }
    }
}
