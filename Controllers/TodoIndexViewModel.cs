using simple_aspnetcoremvc_todo.Models;

namespace simple_aspnetcoremvc_todo.Controllers
{
    public class TodoIndexViewModel
    {
        public IEnumerable<TodoModel>? Todos { get; set; }
        public TodoModel? NewTodo { get; set; }
    }
}
