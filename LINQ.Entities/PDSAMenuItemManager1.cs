using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Entities
{
    /// <summary>
    /// Simple Mock Menu Manager Class
    /// </summary>
    public class PDSAMenuItemManager1
    {
        public PDSAMenuItemManager1()
        {
            Menus = new List<PDSAMenuItem1>();
        }

        public List<PDSAMenuItem1> Menus { get; set; }

        public void Load()
        {
            PDSAMenuItem1 entity = new PDSAMenuItem1();

            entity.MenuId = 1;
            entity.MenuTitle = "Home";
            entity.DisplayOrder = 10;
            entity.MenuAction = "/Home/Home";
            Menus.Add(entity);

            entity = new PDSAMenuItem1();
            entity.MenuId = 2;
            entity.MenuTitle = "Maintenance";
            entity.MenuAction = "/Maintenance/Maintenance";
            entity.DisplayOrder = 20;
            Menus.Add(entity);

            entity = new PDSAMenuItem1();
            entity.MenuId = 3;
            entity.MenuTitle = "Reports";
            entity.MenuAction = "/Reports/Reports";
            entity.DisplayOrder = 30;
            Menus.Add(entity);

            entity = new PDSAMenuItem1();
            entity.MenuId = 4;
            entity.MenuTitle = "Lookup";
            entity.MenuAction = "/Lookup/Lookup";
            entity.DisplayOrder = 30;
            Menus.Add(entity);
        }
    }
}
