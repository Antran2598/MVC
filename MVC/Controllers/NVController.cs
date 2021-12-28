using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class NVController : Controller
    {
        MydbDataContext dc = new MydbDataContext(); 
        // GET: NV
        public ActionResult Index()
        {
            var nvdetails = from x in dc.ChitietNVs select x;
            return View(nvdetails);
        }

        // GET: NV/Details/5
        public ActionResult Details(int id)
        {
            var getnvdetails = dc.ChitietNVs.Single(x => x.Manv == id);
            return View(getnvdetails);
        }

        // GET: NV/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: NV/Create
        [HttpPost]
        public ActionResult Create(ChitietNV collection)
        {
            try
            {
                // TODO: Add insert logic here
                dc.ChitietNVs.InsertOnSubmit(collection);
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NV/Edit/5
        public ActionResult Edit(int id)
        {
            var getnvdetails = dc.ChitietNVs.Single(x => x.Manv == id);
            return View(getnvdetails);
        }

        // POST: NV/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ChitietNV collection)
        {
            try
            {
                // TODO: Add update logic here
                ChitietNV nvupdate = dc.ChitietNVs.Single(x => x.Manv == id);
                nvupdate.Ten = collection.Ten;
                nvupdate.Chucvu = collection.Chucvu;
                nvupdate.Phongban = collection.Phongban;
                nvupdate.Chuthich = collection.Chuthich;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NV/Delete/5
        public ActionResult Delete(int id)
        {
            var getnvdetails = dc.ChitietNVs.Single(x => x.Manv == id);
            return View(getnvdetails);
        }

        // POST: NV/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ChitietNV collection)
        {
            try
            {
                // TODO: Add delete logic here
                var nvdel = dc.ChitietNVs.Single(x => x.Manv == id);
                dc.ChitietNVs.DeleteOnSubmit(nvdel);
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
