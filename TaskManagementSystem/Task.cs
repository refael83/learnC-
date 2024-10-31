using System;

namespace TaskManagement{
    public class Task
{
    public int TaskId { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public int Priority { get; private set; }
    public DateTime Deadline { get; private set; }
    public Status Status { get; private set; }
    public User? Assignee { get; set; } 
    public List<Task> Subtasks { get; private set; }
    public List<Task> Dependencies { get; private set; }

    public Task(int taskId, string title, string description, int priority, DateTime deadline)
    {
        TaskId = taskId;
        Title = title;
        Description = description;
        Priority = priority;
        Deadline = deadline;
        Status = Status.Backlog; // Default status
        Subtasks = new List<Task>();
        Dependencies = new List<Task>();
    }

    public void AddSubtask(Task subtask)
    {
        Subtasks.Add(subtask);
    }

    public void AddDependency(Task dependency)
    {
        Dependencies.Add(dependency);
    }

    public void UpdateStatus(Status status)
    {
        Status = status;
    }

    public void UpdateTaskDetails(string title, string description, int priority, DateTime deadline)
    {
        Title = title;
        Description = description;
        Priority = priority;
        Deadline = deadline;
    }
}
}