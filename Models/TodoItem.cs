namespace TodoItems.Models;

public class TodoItem {
    public long Id { get; set; } //will be primary key in an SQL DB
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}