using MuhammadHammad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuhammadHammad.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Product
        private EmpDb db = new EmpDb();


        public ActionResult Index(string search)
        {


            if (search != null)
            {
                return View(db.Emp.Where(x => x.Name.Contains(search)).ToList());
            }
                return View(db.Emp.ToList());
            
        }
        public ActionResult Create()
        {

            return View();

        }

        [HttpPost]
        public ActionResult Create(Employee e)
        {
            db.Emp.Add(e);
            db.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}