using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstApproach.Models;


namespace CodeFirstApproach.Controllers
{
    public class NorthwindController : Controller
    {
        NorthWindContext Db = new NorthWindContext();
        public ActionResult Index()
        {

            Db.CategoriesTable.ToList();
            Db.ProductsTable.ToList();
            return View();
        }
    }
}