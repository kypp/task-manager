using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskManager
{
    public class TaskCategory
    {
        public string Name;
        public bool Visible;

        public TaskCategory(string Name)
        {
            this.Name = Name;
            this.Visible = true;
        }
    }
}
