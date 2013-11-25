using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskManager;

namespace TaskManager_GUI
{
    public partial class AddTask : Form
    {
        public bool Success { get; private set; }
        public Task TaskResult { get; private set; }
        
        private List<TaskCategory> Categories;

        public AddTask(List<TaskCategory> Categories)
        {
            InitializeComponent();
            this.Categories = Categories;
            foreach (TaskCategory cat in Categories)
                categoryChooser.Items.Add(cat.Name);
            categoryChooser.Text = (string) categoryChooser.Items[0];
            Success = false;
        }

        public AddTask(Task task, List<TaskCategory> Categories) : this(Categories)
        {
            textBoxTaskName.Text = task.Name;
            textBoxTaskDescription.Text = task.Description;
            deadlinePicker.Value = task.Deadline;
            durationPicker.Value = durationPicker.Value.Add(task.Duration);
            TaskResult = task;
            categoryChooser.Text = task.Category.Name;
            this.buttonAddTask.Text = "Save";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            Success = true;
                
            TaskCategory cat = Categories.Find( (c) => c.Name==categoryChooser.Text);
            if (TaskResult == null)
                TaskResult = new Task(textBoxTaskName.Text, textBoxTaskDescription.Text, cat, 0, 0, deadlinePicker.Value, durationPicker.Value.TimeOfDay, null);
            else
            {
                TaskResult.Update(textBoxTaskName.Text, textBoxTaskDescription.Text, cat, deadlinePicker.Value, durationPicker.Value.TimeOfDay, TaskResult.Priority, TaskResult.Weight);
            }
            
            this.Close();
        }
    }
}
