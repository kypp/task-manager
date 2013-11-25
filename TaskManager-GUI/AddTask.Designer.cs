namespace TaskManager_GUI
{
    partial class AddTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTaskName = new System.Windows.Forms.Label();
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.labelTaskDescription = new System.Windows.Forms.Label();
            this.textBoxTaskDescription = new System.Windows.Forms.TextBox();
            this.deadlinePicker = new System.Windows.Forms.DateTimePicker();
            this.labelDeadline = new System.Windows.Forms.Label();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelDuration = new System.Windows.Forms.Label();
            this.durationPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryChooser = new System.Windows.Forms.ComboBox();
            this.addTaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.addTaskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTaskName
            // 
            this.labelTaskName.AutoSize = true;
            this.labelTaskName.Location = new System.Drawing.Point(13, 13);
            this.labelTaskName.Name = "labelTaskName";
            this.labelTaskName.Size = new System.Drawing.Size(63, 13);
            this.labelTaskName.TabIndex = 0;
            this.labelTaskName.Text = "Task name:";
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.Location = new System.Drawing.Point(83, 13);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(200, 20);
            this.textBoxTaskName.TabIndex = 1;
            // 
            // labelTaskDescription
            // 
            this.labelTaskDescription.AutoSize = true;
            this.labelTaskDescription.Location = new System.Drawing.Point(13, 40);
            this.labelTaskDescription.Name = "labelTaskDescription";
            this.labelTaskDescription.Size = new System.Drawing.Size(63, 13);
            this.labelTaskDescription.TabIndex = 2;
            this.labelTaskDescription.Text = "Description:";
            // 
            // textBoxTaskDescription
            // 
            this.textBoxTaskDescription.Location = new System.Drawing.Point(83, 40);
            this.textBoxTaskDescription.Multiline = true;
            this.textBoxTaskDescription.Name = "textBoxTaskDescription";
            this.textBoxTaskDescription.Size = new System.Drawing.Size(200, 85);
            this.textBoxTaskDescription.TabIndex = 3;
            // 
            // deadlinePicker
            // 
            this.deadlinePicker.Location = new System.Drawing.Point(83, 165);
            this.deadlinePicker.Name = "deadlinePicker";
            this.deadlinePicker.Size = new System.Drawing.Size(200, 20);
            this.deadlinePicker.TabIndex = 4;
            // 
            // labelDeadline
            // 
            this.labelDeadline.AutoSize = true;
            this.labelDeadline.Location = new System.Drawing.Point(13, 165);
            this.labelDeadline.Name = "labelDeadline";
            this.labelDeadline.Size = new System.Drawing.Size(52, 13);
            this.labelDeadline.TabIndex = 5;
            this.labelDeadline.Text = "Deadline:";
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(16, 227);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(94, 23);
            this.buttonAddTask.TabIndex = 6;
            this.buttonAddTask.Text = "Add Task";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(193, 227);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(13, 196);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(50, 13);
            this.labelDuration.TabIndex = 8;
            this.labelDuration.Text = "Duration:";
            // 
            // durationPicker
            // 
            this.durationPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.durationPicker.Location = new System.Drawing.Point(83, 196);
            this.durationPicker.Name = "durationPicker";
            this.durationPicker.ShowUpDown = true;
            this.durationPicker.Size = new System.Drawing.Size(200, 20);
            this.durationPicker.TabIndex = 9;
            this.durationPicker.Value = new System.DateTime(2012, 6, 10, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Category:";
            // 
            // categoryChooser
            // 
            this.categoryChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryChooser.FormattingEnabled = true;
            this.categoryChooser.Location = new System.Drawing.Point(83, 138);
            this.categoryChooser.Name = "categoryChooser";
            this.categoryChooser.Size = new System.Drawing.Size(200, 21);
            this.categoryChooser.TabIndex = 11;
            // 
            // addTaskBindingSource
            // 
            this.addTaskBindingSource.DataSource = typeof(TaskManager_GUI.AddTask);
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(295, 262);
            this.Controls.Add(this.categoryChooser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.durationPicker);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.labelDeadline);
            this.Controls.Add(this.deadlinePicker);
            this.Controls.Add(this.textBoxTaskDescription);
            this.Controls.Add(this.labelTaskDescription);
            this.Controls.Add(this.textBoxTaskName);
            this.Controls.Add(this.labelTaskName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddTask";
            this.Text = "AddTask";
            ((System.ComponentModel.ISupportInitialize)(this.addTaskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTaskName;
        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.Label labelTaskDescription;
        private System.Windows.Forms.TextBox textBoxTaskDescription;
        private System.Windows.Forms.DateTimePicker deadlinePicker;
        private System.Windows.Forms.Label labelDeadline;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.DateTimePicker durationPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryChooser;
        private System.Windows.Forms.BindingSource addTaskBindingSource;
    }
}