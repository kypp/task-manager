using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace TaskManager
{
    public class Task
    {
        public string           Name { get; private set; }
        public string           Description { get; private set; }
        public TaskCategory     Category;
        public int              Priority { get; private set; }           //  Priority of a (sub)task determines preferable execution order
        public int              Weight { get; private set; }             //  Weight of a subtask is it's time relation to other subtasks
        public DateTime         Deadline { get; private set; }
        public List<Task>       Subtasks;
        
        public Task ParentTask;        //  Parent of the task (only exists if the task is a subtask, otherwise null)

        private int Progress;
        public int Percentage
        {
            get 
            {
                if (HasSubtasks())
                {
                    int sum = 0;
                    int weights = 0;
                    foreach (Task task in Subtasks)
                    {
                        weights += task.Weight;
                        sum += task.Weight * task.Percentage;
                    }
                    return (int) sum / weights;
                }                
                else return Progress; 
            }
            set { Progress = value; }
        }

        private TimeSpan TimeLength;
        public TimeSpan Duration
        {
            get 
            {
                if (IsSubtask())
                {
                    var t = new TimeSpan((long)Weight * (ParentTask.Duration.Ticks / ParentTask.SubtasksWeights()));
                    return t.Subtract(new TimeSpan(t.Milliseconds));
                }
                else return TimeLength; 
            }
            set { TimeLength = value; }
        }

        public void Complete()
        {
            if (HasSubtasks())
            {
                foreach (Task task in Subtasks)
                {
                    task.Complete();
                }
            }
            else Percentage = 100;
        }
        public void Uncomplete()
        {
            if (HasSubtasks())
            {
                foreach (Task task in Subtasks)
                {
                    task.Uncomplete();
                }
            }
            else Percentage = 0;
        }

        public void Update(string Name, string Description, TaskCategory Category, DateTime Deadline, TimeSpan Duration, int Priority, int Weight)
        {
            this.Name = Name;
            this.Deadline = Deadline;
            this.Category = Category;
            this.Description = Description;
            this.Duration = Duration;
            this.Priority = Priority;
            this.Weight = Weight;
        }
        public bool HasSubtasks()
        {
            if (Subtasks == null) return false;
            return !(Subtasks.Count == 0);
        }
        public bool IsSubtask()
        {
            return !(ParentTask == null);
        }
        public int SubtasksWeights()
        {
            int w = 0;
            foreach (Task task in Subtasks)
            {
                w += task.Weight;
            }
            return w;
        }

        public Task(string Name, string Description, TaskCategory Category, int Priority, int Weight, DateTime Deadline, TimeSpan Duration, Task Parent)
        {
            this.Name = Name;
            this.Description = Description;
            this.Category = Category;
            this.Priority = Priority;
            this.Weight = Weight;
            this.Deadline = Deadline;
            this.Duration = Duration;
            ParentTask = Parent;
            this.Subtasks = new List<Task>();
            Percentage = 0;
        }

        public void AddSubtask(string Name, string Description, int Priority, int Weight)
        {
            Subtasks.Add(new Task(Name, Description, Category, Priority, Weight, Deadline, Duration, this));
        }
        public void AddSubtasks(int count, string[] Name, string Description, int[] Priorities, int[] Weights)
        {
            for (int i = 0; i < count; i++)
            {
                Subtasks.Add(new Task(Name[i], Description, this.Category, Priorities[i], Weights[i], Deadline, Duration, this));
            }
        }
    }
}
