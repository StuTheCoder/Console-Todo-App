using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        TodoList todoList = new TodoList();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Todo List Application");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Edit Task");
            Console.WriteLine("3. Delete Task");
            Console.WriteLine("4. Mark Task as Done");
            Console.WriteLine("5. Print Tasks");
            Console.WriteLine("6. Exit");
            Console.WriteLine();

            Console.Write("Enter your choice (1-6): ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter task description: ");
                    string description = Console.ReadLine();
                    todoList.AddItem(description);
                    break;
                case "2":
                    Console.WriteLine("Enter task ID: ");
                    int editId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter new description: ");
                    string newDescription = Console.ReadLine();
                    todoList.EditItem(editId, newDescription);
                    break;
                case "3":
                    Console.WriteLine("Enter task ID: ");
                    int deletedId = int.Parse(Console.ReadLine());
                    todoList.DeleteItem(deletedId);
                    break;
                case "4":
                    Console.WriteLine("Enter task ID: ");
                    int doneId = int.Parse(Console.ReadLine());
                    todoList.MarkAsDone(doneId);
                    break;
                case "5":
                    todoList.PrintTasks();
                    break;
                case "6":
                    Console.WriteLine("Thank you for using the todo app.");
                    return;
                default:
                    Console.WriteLine("Invalid choose. Please enter a valid option.");
                    break;
            }
        }
    }
}