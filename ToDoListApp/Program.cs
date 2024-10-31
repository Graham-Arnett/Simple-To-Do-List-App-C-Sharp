namespace ToDoListApp

{
    using System;
    using System.Collections.Generic;
    using System.Net;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TO DO LIST");

            List<Task> tasks = new List<Task>();
            string command = "";

            while (command != "exit")
            {
                Console.Write("Please enter a command (add, list, complete, exit): ");
                command = Console.ReadLine();
                switch (command.ToLower())
                {
                    case "add":
                        Console.Write("Enter task name: ");
                        string taskName = Console.ReadLine();
                        tasks.Add(new Task(taskName));
                        break;
                    case "list":
                        Console.WriteLine();
                        foreach (var task in tasks)
                        {
                            Console.WriteLine(task);
                        }
                        break;
                    case "complete":
                    Console.Write("Enter the index of the task to complete: ");
                    if(int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < tasks.Count)
                        {
                            tasks[index].IsCompleted = true;
                            Console.WriteLine($"\n{tasks[index].Name} completed");
                        }
                        else
                        {
                            Console.WriteLine("Invalid index.");
                        }
                        break;
                    case "exit":
                        Console.WriteLine("\n\nThank you for using the To Do app");
                        break;

                    default:
                        Console.Write("\nUnknown command. Please enter 'add', 'list', 'complete', or 'exit'");
                        break;

                }
            }
        }
    }
}
