namespace TodoConsoleApp
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public bool IsCompleted { get; set; } = false;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
