using System.Collections.Generic;

namespace Todo_List
{
    internal class Program
    { 
        enum UserChoice
        {
            AddTask = 1,
            DeleteTask,
            Exit
        }
        static void Main()
        {
            List<string> toDoList = new List<string>();
            while (true)
            {
                if(toDoList.Count > 0)
                {
                    Console.WriteLine("To-Do List: ");
                    for(int i = 0; i < toDoList.Count; i++)
                    {
                        Console.WriteLine("- " + toDoList[i]);
                    }
                    Console.WriteLine("");
                } else
                {
                    Console.WriteLine("Todo List is currently Empty.");
                    Console.WriteLine("");
                }
                Console.WriteLine("1. Add task");
                Console.WriteLine("2. Delete Task");
                Console.WriteLine("3. Exit");
                int choice = int.Parse(Console.ReadLine());
                if (choice == (int)UserChoice.AddTask)
                {
                    Console.Write("Enter task: ");
                    string task = Console.ReadLine();
                    toDoList.Add(task);
                    Console.Clear();
                    Console.WriteLine("Task added successfully!");
                } else if (choice == (int)UserChoice.Exit)
                {
                    break;
                } else if (choice == (int)UserChoice.DeleteTask)
                {
                    if(toDoList.Count > 0)
                    {
                        Console.WriteLine("Enter the Task Number you wish to Delete: ");
                        for(int i = 0; i < toDoList.Count;i++)
                        {
                            Console.WriteLine("(" + (i + 1) + ") " + toDoList[i]);
                        }
                        int taskNum = int.Parse(Console.ReadLine());
                        taskNum--;
                        if (taskNum >= 0 && taskNum < toDoList.Count)
                        {
                            toDoList.RemoveAt(taskNum);
                            Console.Clear();
                            Console.WriteLine("Task deleted successfully!");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid task number.");
                            Console.WriteLine("");
                        }
                    }
                }
            }
        }
    }
}