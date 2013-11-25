using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaskManager_GUI
{
    public partial class AddSubtasks : Form
    {
        List<TextBox> Names;
        List<TrackBar> Weights;

        public bool Success { get; private set; }
        public List<string> SubNames;
        public string Description { get; private set; }
        public List<int> SubWeights;

        public AddSubtasks(string name)
        {
            InitializeComponent();
            Names = new List<TextBox>();
            Weights = new List<TrackBar>();
            textBoxSubtasksName.Text = name;
            refreshList();
            last = 0;
            Success = false;
        }

        public AddSubtasks(string name, string description, List<string> SubNames, List<int> SubWeights) : this(name)
        {
            numericUpDown1.Value = SubNames.Count;
            checkBoxSameName.Checked = false;
            refreshList();
            for (int i = 0; i < SubNames.Count; i++)
            {
                Names[i].Text = SubNames[i];
                Weights[i].Value = SubWeights[i];
            }
            this.buttonAddTask.Text = "Save";
        }
        

        private int last;

        private void NeedsRefresh(object sender, EventArgs e)
        {
            refreshList();
            refreshBars(null, null);
        }

        private void refreshBars(object sender, EventArgs e)
        {
            if (Weights.Count > 1)
            {
                TrackBar bar = (sender as TrackBar);
                int sum = 0;
                int max = Weights.Count * 50;

                foreach (TrackBar tbar in Weights)
                    sum += tbar.Value;

                while (sum > max)
                {
                    last = (last + 1) % Weights.Count;
                    var tbar = Weights[last];

                    if (tbar != bar && tbar.Value > 0)
                    {
                        tbar.Value--;
                        sum--;
                    }
                }

                while (sum < max)
                {
                    last = (last + 1) % Weights.Count;
                    var tbar = Weights[last];

                    if (tbar != bar && tbar.Value < 100)
                    {
                        tbar.Value++;
                        sum++;
                    }
                }
            }
        }

        private void refreshList()
        {
            int c = (int)numericUpDown1.Value;
            while (c < Names.Count)
            {
                Names[c].Dispose();
                Names.RemoveAt(c);
                Weights[c].Dispose();
                Weights.RemoveAt(c);
            }
            while (c > Names.Count)
            {
                TextBox box =   new TextBox();
                box.Parent  =   panelSubtasks;
                box.Left    =   10;
                box.Top     =   25 + 30 * Names.Count;
                box.Show();

                Names.Add(box);

                TrackBar bar =  new TrackBar();
                bar.Parent  =   panelSubtasks;
                bar.Left = box.Width + 20;
                bar.Top = 25 + 30 * Weights.Count;
                bar.Width = 200;

                bar.Minimum = 0;
                bar.Maximum = 100;
                bar.Value = 50;
                bar.BringToFront();
                bar.Show();

                bar.Scroll += new System.EventHandler(refreshBars);

                Weights.Add(bar);
            }
            
            bool b = checkBoxSameName.Checked;
            textBoxSubtasksName.Enabled = b;
            int i = 1;
            foreach (TextBox name in Names)
            {
                name.Enabled = !b;
                if (b) name.Text = textBoxSubtasksName.Text + ' ' + i.ToString();
                i++;
            }
            
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            Success = true;
            SubNames = new List<string>();
            SubWeights = new List<int>();
            foreach (TextBox box in Names)
                SubNames.Add(box.Text);
            foreach (TrackBar bar in Weights)
                SubWeights.Add(bar.Value);
            Description = textBoxDescription.Text;
            this.Close();
        }

    }
}
