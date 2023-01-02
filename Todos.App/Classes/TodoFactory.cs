﻿using System.Diagnostics.CodeAnalysis;

namespace Todos.App.Classes;

public class TodoFactory
{
 
    List<Todo> todos = new() { new Todo { Id = 1, Completed = false, Description = "Cum is a Dressing to your Sub" } };

    public List<Todo> Get() => todos.GetRange(0 , todos.Count);

    public bool Update(bool completed, Todo todo) 
    {
        try
        {
            todo.Completed = completed;
        }
        catch
        {
            return false;
        }
        return true;
    }

    public void Delete(Todo todo) => todos.Remove(todo);

    public void Add(string descrption)
    {
        if (descrption.Length.Equals(0)) throw new ArgumentException("Illegal to-do description");

        try
        {

        var id = todos.Count().Equals(0) ? 1 : todos.Max(t => t.Id) + 1;
        var todo = new Todo { Id = id, Completed = false, Description = descrption };
        todos.Add(todo);

        }
        catch
        {
            throw;
        }

    }
}
