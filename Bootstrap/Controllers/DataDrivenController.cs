using System.Web.Mvc;
using LINQ.Entities;

namespace Bootstrap.Controllers
{
    public class DataDrivenController : Controller
    {
        // Data-Driven Horizontal Menu
        public ActionResult DataDriven01()
        {
            PDSAMenuItemManager1 mgr = new PDSAMenuItemManager1();

            mgr.Load();
            return View(mgr);
        }

        // GET: DataDriven
        public ActionResult Index()
        {
            return View();
        }
    }
}