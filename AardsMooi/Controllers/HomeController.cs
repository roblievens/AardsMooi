using AardsMooi.DAO;
using AardsMooi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AardsMooi.Controllers
{
    public class HomeController : Controller
    {
        private AMdbDataContext db = new AMdbDataContext();
        private Dao_Categorie daoCat = new Dao_Categorie();
        public ActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel();
            vm.Welkom = db.SP_GetPageByPageId(1).Single();
            vm.Behandelingen = db.SP_GetPageByPageId(2).Single();
            vm.Cadeaubon = db.SP_GetPageByPageId(3).Single();
            vm.ListCategories = daoCat.GetAllCategories().ToList();
            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}