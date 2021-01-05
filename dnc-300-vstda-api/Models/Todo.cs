namespace dnc_300_vstda_api.Models
{
    public class Todo
    {
        public Todo(int todoItemId, string name, int priority, bool completed)
        {
            TodoItemId = todoItemId;
            Name = name;
            Priority = priority;
            Completed = completed;
        }

        public int TodoItemId { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
        public bool Completed { get; set; }
    }
}