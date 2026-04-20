using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using TaskManagerApi.Models;
using TaskManagerApi.Services;

namespace TaskManagerApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TasksController : ControllerBase
{
    private readonly ITaskService _taskService;
    public TasksController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    [HttpGet]
    public ActionResult<IReadOnlyList<TaskItem>> GetAll()
    {
        var tasks = _taskService.GetAllTasks();
        return Ok(tasks);
    }

    [HttpGet("{id:int}")]
    public ActionResult<TaskItem> Get(int id)
    {
        var task = _taskService.GetTask(id);
        if (task is null)
            return NotFound();

        return task;
    }

    [HttpPatch("{id:int}/done")]
    public ActionResult<TaskItem> MarkAsDone(int id)
    {
        var task = _taskService.MarkTaskAsDone(id);

        if (task is false)
            return NotFound();

        return Ok(task);
    }

    [HttpDelete("{id:int}")]
    public ActionResult<TaskItem> Delete(int id)
    {
        var deleted = _taskService.DeleteTask(id);

        if (!deleted)
            return NotFound();

        return NoContent();
    }

    [HttpPost]
    public ActionResult<TaskItem> Create([FromBody] string details)
    {
        var task = _taskService.AddTask(details);

        return task;
    }
}
