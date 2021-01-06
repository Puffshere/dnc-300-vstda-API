using dnc_300_vstda_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace dnc_300_vstda_api.Controllers
{
    public class TodosController : Controller
    {
        public ActionResult TodoItems()
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

        public ActionResult GetByID()
        {
            return View();
        }

        public ActionResult Post()
        {
            return View();
        }

        public ActionResult Put()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}