using dnc_300_vstda_api.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace dnc_300_vstda_api.Controllers
{
    public class TodoItemsController : Controller
    {
        //private TodosController tc = new TodosController();

        private List<Todo> mockTodos = new List<Todo>()
        {
            new Todo(0, "an item", 3, false),
            new Todo(1, "another item", 2, false),
            new Todo(2, "a done item", 1, true),
        };

        public ActionResult Get()
        {
            //List<Todo> todos = (List<Todo>)tc.Get();
            return View(mockTodos);
        }

        //public ActionResult GetByID()
        //{
        //    Todo todo = tc.Get(1);
        //    return View(todo);
        //}

        //public ActionResult Post()
        //{
        //    Todo mockTodo = new Todo(3, "yet another item", 3, false);
        //    Todo newTodo = tc.Post(mockTodo);
        //    return View();
        //}

        //public ActionResult Put()
        //{
        //    Todo mockTodo = new Todo(0, "an updated item", 2, false);
        //    Todo updatedTodo = tc.Put(mockTodo.todoItemId, mockTodo);
        //    return View(updatedTodo);
        //}

        //public ActionResult Delete()
        //{
        //    Todo mockTodo = new Todo(0, "an updated item", 2, false);
        //    Todo deletedTodo = tc.Delete(0);
        //    return View(deletedTodo);
        //}
    }
}