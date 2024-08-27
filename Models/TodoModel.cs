using System.ComponentModel.DataAnnotations;

namespace simple_aspnetcoremvc_todo.Models
{

    public enum TodoStatus
    {
        Done,
        NotDone
    }

    public class TodoModel
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public TodoStatus Status { get; set; }
    }
}