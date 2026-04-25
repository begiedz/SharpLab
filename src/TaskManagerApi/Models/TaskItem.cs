using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagerApi.Models;

public class TaskItem
{
    public int Id { get; }
    public string? Details { get; private set; }
    public bool IsDone { get; private set; } = false;

    public TaskItem(int id, string details)
    {
        if (string.IsNullOrWhiteSpace(details))
            throw new ArgumentException("Details cannot be empty", nameof(details));

        Id = id;
        Details = details;
    } 

    public void MarkAsDone()
    {
        IsDone = true;
    }
}
