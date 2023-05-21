using Microsoft.AspNetCore.Components;
using Models;
using ToDoList.Models;

namespace ToDoList.Pages;

public partial class ToDoPage
{
    private List<ToDoItem> _tasks = new();

    private string? _newTaskTitle;

    private bool _displayBorders;

    private bool _addTasksXSec;

    protected override void OnInitialized()
    {
        //for (var i = 1; i <= 10; i++)
        //{
        //    _tasks.Add(new($"Entrez votre tâche n° {i}"));
        //}
        ToDoOptions.OnThemeChanged -= Update;
        ToDoOptions.OnThemeChanged += Update;
        ToDoOptions.OnDevModeChanged -= Update;
        ToDoOptions.OnDevModeChanged += Update;
        base.OnInitialized();
    }

    public void Update()
    {
        StateHasChanged();
    }

    private void AddTask()
    {
        if (!string.IsNullOrWhiteSpace(_newTaskTitle))
        {
            _tasks.Add(new ToDoItem(_newTaskTitle));
            _newTaskTitle = string.Empty;
        }
    }

    public void DeleteToDo(ToDoItem todoItem)
    {
        _tasks.Remove(todoItem);
        Update();
    }

    private void ClearTask()
    {
        _tasks.Clear();
    }

    private void AddTasks(int numberOfTasks)
    {
        var tasksCount = _tasks.Count;
        for (var i = 1; i <= numberOfTasks; i++)
        {
            _tasks.Add(new($"Entrez votre tâche n° {i + tasksCount}"));
        }
    }

    private void CheckAllTasks()
    {
        foreach (var task in _tasks)
        {
            task.IsDone = true;
        }
    }

    private void UncheckAllTasks()
    {
        foreach (var task in _tasks)
        {
            task.IsDone = false;
        }
    }

    private void ToggleBorders() 
    {
        _displayBorders = !_displayBorders;
    }

    private async Task ToggleAddTasksXSec()
    {
        _addTasksXSec = !_addTasksXSec;
        if (_addTasksXSec )
        {
            await ForceAddTasks();
        }
    }

    private async Task ForceAddTasks()
    {
        while (_addTasksXSec)
        {
            AddTasks(1);
            StateHasChanged();
            await Task.Delay(1000);
        }
    }

}