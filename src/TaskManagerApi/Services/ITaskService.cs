using System;
using System.Collections.Generic;
using System.Text;
using TaskManagerApi.Models;

namespace TaskManagerApi.Services;

public interface ITaskService
{
    public TaskItem AddTask(string details);
    public TaskItem? GetTask(int id);
    public IReadOnlyList<TaskItem> GetAllTasks();
    public bool DeleteTask(int id);
    public bool MarkTaskAsDone(int id);
}
