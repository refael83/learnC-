using System;

namespace TaskManagement{
    public class User
{
    public int UserId { get; private set; }
    public string Name { get; private set; }

    public User(int userId, string name)
    {
        UserId = userId;
        Name = name;
    }

    public void AssignTask(Task task)
    {
        task.Assignee = this;
    }
}
}