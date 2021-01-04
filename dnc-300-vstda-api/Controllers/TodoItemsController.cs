using System;
using System.Collections;
using System.Linq;
using System.Web.Mvc;
using dnc_300_vstda_api.Models;

namespace dnc_300_vstda_api.Controllers
{
    public class TodoItemsController : Controller
    {
        // GET: TodoItems
        public ActionResult Index(string i)
        {
            i = "hello worlds";

            ArrayList todoArrList = new ArrayList();
            todoArrList.Add(
                new Todos
                {
                    todoItemId = 0,
                    name = "Omelchenko",
                    priority = 3
                });
            todoArrList.Add(
                new Todos
                {
                    todoItemId = 1,
                    name = "O’Donnell",
                    priority = 2
                });
            todoArrList.Add(
                new Todos
                {
                    todoItemId = 2,
                    name = "Mortensen",
                    priority = 1
                });

            var list = from Todos todos in todoArrList
                       where todos.todoItemId == 0
                       select todos;

            foreach (Todos t in list)
                ViewBag.TodoList = t.name;
            return View();
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