using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TaskManager;
using BrightIdeasSoftware;

namespace TaskManager_GUI
{
    public partial class Form1 : Form
    {
        public List<Task> Tasks;
        public List<TaskCategory> Categories;

        public Task ActiveTarget;

        public Form1()
        {
            Tasks = ProgramState.Instance.Tasks;
            Categories = ProgramState.Instance.Categories;
            Categories.Add(new TaskCategory("General"));
            InitializeComponent();
            //tasksTreeView.SetObjects(Tasks);
            CategoriesList.SetObjects(Categories);
            tasksTreeView.CanExpandGetter = delegate(object x)
            {
                return (x is Task) && (x as Task).HasSubtasks();
            };
            tasksTreeView.ChildrenGetter = delegate(object x)
            {
                return (x as Task).Subtasks;
            };
            taskDurationColumn.AspectToStringConverter = delegate(object x)
            {
                var ts = (TimeSpan)x;
                return string.Format("{0:00}:{1:00}:{2:00}", (int)ts.TotalHours, ts.Minutes, ts.Seconds);
            };

            RefreshView();
        }

        private void RefreshView()
        {
            List<Task> ActiveTasks = Tasks.FindAll((x) => x.Category.Visible);
            if (ActiveTasks != null && ActiveTasks.Count > 0) tasksTreeView.SetObjects(ActiveTasks);
            else tasksTreeView.SetObjects(null);
            tasksTreeView.Refresh();
        }

        private void tasksTreeView_ItemActivate(object sender, EventArgs e)
        {
            sender.ToString();
        }

        private void tasksTreeView_FormatRow(object sender, FormatRowEventArgs e)
        {           
            {
                Task t = e.Model as Task;
                if (t.Percentage == 0) e.Item.BackColor = Color.LightCoral;
                else if (t.Percentage == 100) e.Item.BackColor = Color.GreenYellow;
                else if (t.Percentage >= 50) e.Item.BackColor = Color.Yellow;
                else e.Item.BackColor = Color.LemonChiffon;
            }
        }

        private void tasksTreeView_FormatCell(object sender, FormatCellEventArgs e)
        {
            if (e.ColumnIndex == taskDeadlineColumn.Index)
            {
                Task task = e.Model as Task;
                if (task.IsSubtask()) e.SubItem.Text = "";
            }

        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            var AddTaskForm = new AddTask(Categories);
	        	 
            AddTaskForm.ShowDialog();
            if (AddTaskForm.Success)
                Tasks.Add(AddTaskForm.TaskResult);

            RefreshView();
        }

        private void tasksTreeView_CellRightClick(object sender, CellRightClickEventArgs e)
        {
            if (e.Model != null)
            {
                e.MenuStrip = contextMenuItem;
                ActiveTarget = (Task)e.Model;
            }
        }

        private void optionComplete_Click(object sender, EventArgs e)
        {
            if (ActiveTarget.Percentage == 100) ActiveTarget.Uncomplete();
            else ActiveTarget.Complete();
            tasksTreeView.Refresh();
        }
        
        private void contextMenuItem_Opening(object sender, CancelEventArgs e)
        {
            if (ActiveTarget.Percentage == 100) optionComplete.Text = "Uncomplete";
            else optionComplete.Text = "Complete";
        }

        private void optionEdit_Click(object sender, EventArgs e)
        {
            var AddTaskForm = new AddTask(ActiveTarget, Categories);
            AddTaskForm.ShowDialog();

            tasksTreeView.RefreshObject(ActiveTarget);
        }

        private void optionRemove_Click(object sender, EventArgs e)
        {
            if (ActiveTarget.IsSubtask())
            {
                Task parent = ActiveTarget.ParentTask;
                parent.Subtasks.Remove(ActiveTarget);
                tasksTreeView.RefreshObject(parent);
            }
            else
            {
                Tasks.Remove(ActiveTarget);
                RefreshView();
            }
        }

        private void optionAdd_Click(object sender, EventArgs e)
        {
            var AddSubtasksForm = new AddSubtasks(ActiveTarget.Name);
            AddSubtasksForm.ShowDialog();
            if (AddSubtasksForm.Success) ActiveTarget.AddSubtasks(AddSubtasksForm.SubNames.Count, AddSubtasksForm.SubNames.ToArray(), AddSubtasksForm.Description, AddSubtasksForm.SubWeights.ToArray(), AddSubtasksForm.SubWeights.ToArray());

            tasksTreeView.RefreshObject(ActiveTarget);
        }

        private void optionEditSubtasks_Click(object sender, EventArgs e)
        {
            if (ActiveTarget.HasSubtasks())
            {
                List<string> Names = new List<string>();
                List<int> Weights = new List<int>();
                foreach (Task task in ActiveTarget.Subtasks)
	            {
                    Names.Add(task.Name);
                    Weights.Add(task.Weight);
	            }
                var AddSubtasksForm = new AddSubtasks(ActiveTarget.Name, ActiveTarget.Description, Names, Weights);
                AddSubtasksForm.ShowDialog();
                if (AddSubtasksForm.Success)
                {
                    ActiveTarget.Subtasks.Clear();
                    ActiveTarget.AddSubtasks(AddSubtasksForm.SubNames.Count, AddSubtasksForm.SubNames.ToArray(), AddSubtasksForm.Description, AddSubtasksForm.SubWeights.ToArray(), AddSubtasksForm.SubWeights.ToArray());
                }
                tasksTreeView.RefreshObject(ActiveTarget);
            }
        }

        private void CategoriesList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            RefreshView();
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            CategoriesList.FinishCellEdit();

            TaskCategory tk = new TaskCategory("");
            Categories.Insert(0, tk);
            CategoriesList.SetObjects(Categories);
            
            CategoriesList.EditSubItem(CategoriesList.ModelToItem(Categories[0]), 0);
        }

        private void CategoriesList_CellRightClick(object sender, CellRightClickEventArgs e)
        {
            if (e.ListView.SelectedObjects.Count > 0)
            {
                e.MenuStrip = contextMenuCategories;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TaskCategory cat in CategoriesList.SelectedObjects)
            {
                Categories.Remove(cat);
            }
            CategoriesList.SetObjects(Categories);
        }
    }
}
