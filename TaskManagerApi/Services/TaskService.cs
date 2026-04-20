using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using TaskManagerApi.Models;

namespace TaskManagerApi.Services;

public class TaskService : ITaskService
{
    private readonly List<TaskItem> _tasks = [new(0, "test")];
    private int _nextId = 1;

    public TaskItem AddTask(string details)
    {
        var task = new TaskItem(_nextId, details);
        _tasks.Add(task);
        _nextId++;

        return task;
    }

    public IReadOnlyList<TaskItem> GetAllTasks() => _tasks;

    public bool DeleteTask(int id)
    {
        var item = _tasks.FirstOrDefault(x => x.Id == id);
        if (item is null)
            return false;

        _tasks.Remove(item);
        return true;

    }

    public TaskItem? GetTask(int id) => _tasks.FirstOrDefault(x => x.Id == id);
    public bool MarkTaskAsDone(int id)
    {
        var task = _tasks.FirstOrDefault(x => x.Id == id);
        if (task is null)
            return false;

        task.MarkAsDone();
        return true;
    }
}
