using ToDo.Data;
using ToDo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ToDo.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ToDoContext _context;
        public ToDoController(ToDoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<ToDoModel> objTodoList = _context.ToDos;
            return View(objTodoList);
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(ToDoModel todo)
        {
            if (todo.TaskName != null) {
                _context.ToDos.Add(todo);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(todo);
        }
        public IActionResult Edit(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var todoForDb = _context.ToDos.Find(id);

            if (todoForDb == null)
                return NotFound();

            return View(todoForDb);
        }
        [HttpPost]
        public IActionResult Edit(ToDoModel todo)
        {
            if (todo.TaskName != string.Empty)
            {
                _context.ToDos.Update(todo);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(todo);
        }
        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var todoForDb = _context.ToDos.Find(id);

            if (todoForDb == null)
                return NotFound();

            return View(todoForDb);
        }
        [HttpPost]
        public IActionResult Delete(ToDoModel todo)
        {
            _context.ToDos.Remove(todo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Complete (int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var todoForDb = _context.ToDos.Find(id);

            if (todoForDb == null)
                return NotFound();

            todoForDb.IsCompleted = true;
            _context.ToDos.Update(todoForDb);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
