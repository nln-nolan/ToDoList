namespace Models
{
    public class ToDoItem
    {
        public string Id { get; init; }
        public string? Title { get; set; }
        public bool IsDone { get; set; }

        public ToDoItem(string title, bool isDone = false)
        {
            Id = Guid.NewGuid().ToString();
            Title = title;
            IsDone = isDone;
        }
    }
}


