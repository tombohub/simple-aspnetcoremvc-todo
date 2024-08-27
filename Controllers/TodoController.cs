using Microsoft.AspNetCore.Mvc;
using simple_aspnetcoremvc_todo.Models;


namespace simple_aspnetcoremvc_todo.Controllers
{
    public class TodoController : Controller
    {
        private TodoDbContext _context;

        public TodoController(TodoDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var ViewModel = new TodoIndexViewModel
            {
                Todos = _context.Todos.ToList(),
                NewTodo = new TodoModel()
            };

            return View(ViewModel);
        }


        public IActionResult Create(TodoIndexViewModel viewModel)
        {
            Console.WriteLine("kokods");
            if (ModelState.IsValid)
            {
                _context.Todos.Add(viewModel.NewTodo);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            viewModel.Todos = _context.Todos.ToList();
            return View("Index", viewModel);
        }

        public IActionResult Delete(int id)
        {
            var todo = _context.Todos.Find(id);
            if (todo != null)
            {
                _context.Todos.Remove(todo);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult ToggleStatus(int id)
        {
            var todo = _context.Todos.Find(id);
            if (todo != null)
            {
                todo.Status = todo.Status == TodoStatus.Done ? TodoStatus.NotDone : TodoStatus.Done;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
