using dnc_300_vstda_api.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace dnc_300_vstda_api.Controllers
{
    public class TodoItemsController : Controller
    {
        // GET: TodoItems
        public ActionResult Index()
        {
            List<Todos> completeList = new List<Todos>()
            {
                new Todos
                {
                    todoItemId = 0,
                    name = "an item",
                    priority = 3,
                    completed = false
                },
                new Todos
                {
                    todoItemId = 1,
                    name = "another item",
                    priority = 2,
                    completed = false
                },
                new Todos
                {
                    todoItemId = 2,
                    name = "a done item",
                    priority = 1,
                    completed = true
                },
            };
            return View(completeList);
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
        public ActionResult Create()
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