using System.Web.Mvc;

namespace HST.Controllers
{
    public class HomeController : Controller
    {
        // GET: HSTHome
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserPage()
        {
            return View();
        }
        public ActionResult Manager()
        {
            return View();
        }
        public ActionResult Administrator()
        {
            return View();
        }


        public ActionResult Robot()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }

        /*
        // GET: HSTHome/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HSTHome/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HSTHome/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HSTHome/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HSTHome/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HSTHome/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HSTHome/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }*/
    }
}
