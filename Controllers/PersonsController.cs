using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project2.Services;

namespace Project2.Controllers
{
    public class PersonsController : Controller
    {

        private readonly PersonService personService;

        public PersonsController(PersonService personService)
        {
            this.personService = personService;
        }

        // GET: PersonsController
        public ActionResult Index()
        {
            return View(personService.Get());
        }

        // GET: PersonsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
