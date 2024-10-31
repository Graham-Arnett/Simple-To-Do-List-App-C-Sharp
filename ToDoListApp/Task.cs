using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    public class Task
    {
        public string Name {  get; set; }
        public bool IsCompleted { get; set; }

        public Task(String name) 
        {
        Name = name;
        IsCompleted = false;
        }
        public override string ToString() 
        {
            return $"{(IsCompleted ? "[X]" : "[ ]")} {Name}";
        }
    }

}
