using CarWorkshop.MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarWorkshop.MVC.Controllers
{
    public class PersonController : Controller
    {
        private static IList<Person> model = new List<Person>
        {
            new Person
            {
                Id = 1,
                FirstName = "Adam",
                LastName = "Niewie"
            },
            new Person
            {
                Id = 2,
                FirstName = "Dima",
                LastName = "Danilovich"
            }
        };
        // GET: PersonController
        public ActionResult Index()
        {
            return View(model);
        }

        // GET: PersonController/Details/5
        public ActionResult Details(int id)
        {
            return View(model.FirstOrDefault(x => x.Id == id));
        }

        // GET: PersonController/Create
        public ActionResult Create()
        {
            return View(new Person());
        }

        // POST: PersonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Person person)
        {
            person.Id = model.Count + 1;
            model.Add(person);
            return RedirectToAction(nameof(Index));
        }

        // GET: PersonController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(model.FirstOrDefault(x => x.Id == id));
        }

        // POST: PersonController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Person person)
        {
            Person peson = model.FirstOrDefault(x => x.Id == id);
            peson.FirstName = person.FirstName;
            peson.LastName = person.LastName;
            return RedirectToAction(nameof(Index));
        }

        // GET: PersonController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(model.FirstOrDefault(x => x.Id == id));
        }

        // POST: PersonController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Person person)
        {
            Person peson = model.FirstOrDefault(x => x.Id == id);
            model.Remove(peson);
            return RedirectToAction(nameof(Index));
        }


    }
}
