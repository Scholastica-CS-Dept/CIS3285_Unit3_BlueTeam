using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CIS3285_Unit3Sample_2024.Controllers
{
    public class RoomController : Controller
    {
        // GET: RoomController
        // Changes for Sprint 2 -- User Story 2b -- Sophie E
        public ActionResult Index()
        {
            return View();
        }

        // GET: RoomController/Details/5
        // Changes for Sprint 1 -- User Story -- Sophie E 

        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RoomController/Create
        // Changes for Sprint 1 -- User Story -- Sophie E
        // Changes for Sprint 2 -- User Story 2b -- Sophie E
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        // Changes for Sprint 2 -- User Story 2d -- Sophie E

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

        // GET: RoomController/Edit/5
        // Changes for Sprint 1 -- User Story -- Sophie E
        // Changes for Sprint 2 -- User Story 2d -- Sophie E
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RoomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        // Changes for Sprint 1 -- User Story -- Sophie E
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

        // GET: RoomController/Delete/5
        public ActionResult Delete(int id)
        // Changes for Sprint 1 -- User Story -- Sophie E
        {
            return View();
        }

        // POST: RoomController/Delete/5
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
