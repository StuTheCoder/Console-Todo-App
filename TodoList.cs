using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TodoList
{
    private List<TodoItem> items;
    private int nextId;

    public TodoList()
    {
        items = new List<TodoItem>();
        nextId = 1;
    }

    public void AddItem(string description)
    {
        TodoItem item = new TodoItem
        {
            Id = nextId++,
            Description = description,
            IsDone = false
        };

        items.Add(item);
        nextId++;
        Console.WriteLine("Task added successfully.");
    }

    public void EditItem(int id, string newDescription)
    {
        TodoItem item = FindItemById(id);

        if (item != null)
        {
            item.Description = newDescription;
            Console.WriteLine("Task updated successfully.");
        }
        else
        {
            Console.WriteLine("Task not found");
        }
    }

    public void DeleteItem(int id)
    {
        TodoItem item = FindItemById(id);

        if (item != null )
        {
            items.Remove(item);
            Console.WriteLine("Task deleted successfully.");
        }
        else
        {
            Console.WriteLine("Task not found.");
        }
    }

    public void MarkAsDone(int id)
    {
        TodoItem item = FindItemById(id);

        if (item != null )
        {
            item.IsDone = true;
            Console.WriteLine("Task marked as done.");
        }
        else
        {
            Console.WriteLine("Task not found.");
        }
    }

    public void PrintTasks()
    {
        Console.WriteLine("Todo List: ");

        foreach (TodoItem item in items)
        {
            Console.WriteLine($"[{(item.IsDone ? "x" : " ")}] {item.Id}: {item.Description}");
        }
    }

    private TodoItem FindItemById(int id)
    {
        foreach (TodoItem item in items)
        {
            if (item.Id == id)
            {
                return item;
            }
        }

        return null;
    }
}