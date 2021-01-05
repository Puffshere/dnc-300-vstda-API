using dnc_300_vstda_api.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace dnc_300_vstda_api.Controllers
{
    public class TodosController : Controller
    {
        // GET: TodoItems
        public ActionResult Index()
        {
            List<Todo> mockTodos = new List<Todo>();
            mockTodos.Add(new Todo(0, "an item", 3, false));
            mockTodos.Add(new Todo(1, "another item", 2, false));
            mockTodos.Add(new Todo(2, "a done item", 1, true));
            return View(mockTodos);
            {
                throw new NotImplementedException();
            }
        }

        // GET: TodoItems/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TodoItems/Create
        public ActionResult Create(int todoItemId, string name, int priority, bool completed)
        {
            return View();
        }

        // POST: TodoItems/Create
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

        // GET: TodoItems/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TodoItems/Edit/5
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

        // GET: TodoItems/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TodoItems/Delete/5
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
        }
    }
}