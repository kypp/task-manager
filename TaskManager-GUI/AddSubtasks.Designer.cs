namespace TaskManager_GUI
{
    partial class AddSubtasks
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
            this.labelNumber = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBoxSameName = new System.Windows.Forms.CheckBox();
            this.labelSubtasksName = new System.Windows.Forms.Label();
            this.textBoxSubtasksName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSubtasks = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panelSubtasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(13, 13);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(104, 13);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Number of subtasks:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(124, 13);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NeedsRefresh);
            // 
            // checkBoxSameName
            // 
            this.checkBoxSameName.AutoSize = true;
            this.checkBoxSameName.Checked = true;
            this.checkBoxSameName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSameName.Location = new System.Drawing.Point(200, 13);
            this.checkBoxSameName.Name = "checkBoxSameName";
            this.checkBoxSameName.Size = new System.Drawing.Size(175, 17);
            this.checkBoxSameName.TabIndex = 2;
            this.checkBoxSameName.Text = "Use same name for all subtasks";
            this.checkBoxSameName.UseVisualStyleBackColor = true;
            this.checkBoxSameName.CheckedChanged += new System.EventHandler(this.NeedsRefresh);
            // 
            // labelSubtasksName
            // 
            this.labelSubtasksName.AutoSize = true;
            this.labelSubtasksName.Location = new System.Drawing.Point(13, 46);
            this.labelSubtasksName.Name = "labelSubtasksName";
            this.labelSubtasksName.Size = new System.Drawing.Size(83, 13);
            this.labelSubtasksName.TabIndex = 3;
            this.labelSubtasksName.Text = "Subtasks name:";
            // 
            // textBoxSubtasksName
            // 
            this.textBoxSubtasksName.Location = new System.Drawing.Point(124, 43);
            this.textBoxSubtasksName.Name = "textBoxSubtasksName";
            this.textBoxSubtasksName.Size = new System.Drawing.Size(251, 20);
            this.textBoxSubtasksName.TabIndex = 4;
            this.textBoxSubtasksName.TextChanged += new System.EventHandler(this.NeedsRefresh);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(124, 74);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(251, 77);
            this.textBoxDescription.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Subtasks description:";
            // 
            // panelSubtasks
            // 
            this.panelSubtasks.AutoScroll = true;
            this.panelSubtasks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSubtasks.Controls.Add(this.label3);
            this.panelSubtasks.Controls.Add(this.label2);
            this.panelSubtasks.Location = new System.Drawing.Point(16, 157);
            this.panelSubtasks.Name = "panelSubtasks";
            this.panelSubtasks.Size = new System.Drawing.Size(359, 321);
            this.panelSubtasks.TabIndex = 7;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(285, 486);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(16, 486);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(94, 23);
            this.buttonAddTask.TabIndex = 8;
            this.buttonAddTask.Text = "Add Subtasks";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Names:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Time ratio:";
            // 
            // AddSubtasks
            // 
            this.AcceptButton = this.buttonAddTask;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(387, 521);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.panelSubtasks);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSubtasksName);
            this.Controls.Add(this.labelSubtasksName);
            this.Controls.Add(this.checkBoxSameName);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelNumber);
            this.MaximizeBox = false;
            this.Name = "AddSubtasks";
            this.Text = "Add Subtasks";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panelSubtasks.ResumeLayout(false);
            this.panelSubtasks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBoxSameName;
        private System.Windows.Forms.Label labelSubtasksName;
        private System.Windows.Forms.TextBox textBoxSubtasksName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSubtasks;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}