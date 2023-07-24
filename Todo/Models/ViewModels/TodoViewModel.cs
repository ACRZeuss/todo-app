using System.Collections.Generic;

namespace Todo.Models.ViewModels
{
    public class TodoViewModel
    {
        public List<TodoModel> TodoList { get; set; }
        public TodoModel Todo { get; set; }
    }
}
