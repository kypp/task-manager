namespace TaskManager_GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tasksTreeView = new BrightIdeasSoftware.TreeListView();
            this.taskNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.taskPercentageColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.taskDeadlineColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.taskDurationColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.taskCategoryColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.taskDescriptionColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addCategoryButton = new System.Windows.Forms.ToolStripButton();
            this.addTaskButton = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.CategoriesList = new BrightIdeasSoftware.ObjectListView();
            this.CategoryColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.contextMenuItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.optionComplete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.optionEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.optionAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.optionEditSubtasks = new System.Windows.Forms.ToolStripMenuItem();
            this.optionRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuCategories = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tasksTreeView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesList)).BeginInit();
            this.contextMenuItem.SuspendLayout();
            this.contextMenuCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // tasksTreeView
            // 
            this.tasksTreeView.AllColumns.Add(this.taskNameColumn);
            this.tasksTreeView.AllColumns.Add(this.taskPercentageColumn);
            this.tasksTreeView.AllColumns.Add(this.taskDeadlineColumn);
            this.tasksTreeView.AllColumns.Add(this.taskDurationColumn);
            this.tasksTreeView.AllColumns.Add(this.taskCategoryColumn);
            this.tasksTreeView.AllColumns.Add(this.taskDescriptionColumn);
            this.tasksTreeView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.tasksTreeView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskNameColumn,
            this.taskPercentageColumn,
            this.taskDeadlineColumn,
            this.taskDurationColumn,
            this.taskCategoryColumn,
            this.taskDescriptionColumn});
            this.tasksTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksTreeView.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksTreeView.Location = new System.Drawing.Point(0, 0);
            this.tasksTreeView.Name = "tasksTreeView";
            this.tasksTreeView.OwnerDraw = true;
            this.tasksTreeView.ShowGroups = false;
            this.tasksTreeView.Size = new System.Drawing.Size(800, 453);
            this.tasksTreeView.TabIndex = 0;
            this.tasksTreeView.UseCellFormatEvents = true;
            this.tasksTreeView.UseCompatibleStateImageBehavior = false;
            this.tasksTreeView.View = System.Windows.Forms.View.Details;
            this.tasksTreeView.VirtualMode = true;
            this.tasksTreeView.CellRightClick += new System.EventHandler<BrightIdeasSoftware.CellRightClickEventArgs>(this.tasksTreeView_CellRightClick);
            this.tasksTreeView.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.tasksTreeView_FormatCell);
            this.tasksTreeView.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.tasksTreeView_FormatRow);
            this.tasksTreeView.ItemActivate += new System.EventHandler(this.tasksTreeView_ItemActivate);
            // 
            // taskNameColumn
            // 
            this.taskNameColumn.AspectName = "Name";
            this.taskNameColumn.Text = "Name";
            this.taskNameColumn.Width = 151;
            // 
            // taskPercentageColumn
            // 
            this.taskPercentageColumn.AspectName = "Percentage";
            this.taskPercentageColumn.AspectToStringFormat = "{0}%";
            this.taskPercentageColumn.Text = "Percentage";
            this.taskPercentageColumn.Width = 82;
            // 
            // taskDeadlineColumn
            // 
            this.taskDeadlineColumn.AspectName = "Deadline";
            this.taskDeadlineColumn.AspectToStringFormat = "{0:d}";
            this.taskDeadlineColumn.Text = "Deadline";
            this.taskDeadlineColumn.Width = 77;
            // 
            // taskDurationColumn
            // 
            this.taskDurationColumn.AspectName = "Duration";
            this.taskDurationColumn.AspectToStringFormat = "";
            this.taskDurationColumn.IsEditable = false;
            this.taskDurationColumn.Text = "Duration";
            // 
            // taskCategoryColumn
            // 
            this.taskCategoryColumn.AspectName = "Category.Name";
            this.taskCategoryColumn.IsEditable = false;
            this.taskCategoryColumn.Text = "Category";
            this.taskCategoryColumn.Width = 77;
            // 
            // taskDescriptionColumn
            // 
            this.taskDescriptionColumn.AspectName = "Description";
            this.taskDescriptionColumn.FillsFreeSpace = true;
            this.taskDescriptionColumn.Text = "Description";
            this.taskDescriptionColumn.Width = 71;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCategoryButton,
            this.addTaskButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(964, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.addCategoryButton.Image = ((System.Drawing.Image)(resources.GetObject("addCategoryButton.Image")));
            this.addCategoryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(98, 22);
            this.addCategoryButton.Text = "Add category";
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // addTaskButton
            // 
            this.addTaskButton.Image = ((System.Drawing.Image)(resources.GetObject("addTaskButton.Image")));
            this.addTaskButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(73, 22);
            this.addTaskButton.Text = "Add task";
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(964, 482);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tasksTreeView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.CategoriesList);
            this.splitContainer2.Size = new System.Drawing.Size(964, 453);
            this.splitContainer2.SplitterDistance = 800;
            this.splitContainer2.TabIndex = 1;
            // 
            // CategoriesList
            // 
            this.CategoriesList.AllColumns.Add(this.CategoryColumn);
            this.CategoriesList.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.CategoriesList.CheckBoxes = true;
            this.CategoriesList.CheckedAspectName = "Visible";
            this.CategoriesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CategoryColumn});
            this.CategoriesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoriesList.HasCollapsibleGroups = false;
            this.CategoriesList.Location = new System.Drawing.Point(0, 0);
            this.CategoriesList.Name = "CategoriesList";
            this.CategoriesList.ShowGroups = false;
            this.CategoriesList.Size = new System.Drawing.Size(160, 453);
            this.CategoriesList.TabIndex = 0;
            this.CategoriesList.UseCompatibleStateImageBehavior = false;
            this.CategoriesList.View = System.Windows.Forms.View.Details;
            this.CategoriesList.CellRightClick += new System.EventHandler<BrightIdeasSoftware.CellRightClickEventArgs>(this.CategoriesList_CellRightClick);
            this.CategoriesList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.CategoriesList_ItemChecked);
            // 
            // CategoryColumn
            // 
            this.CategoryColumn.AspectName = "Name";
            this.CategoryColumn.FillsFreeSpace = true;
            this.CategoryColumn.Groupable = false;
            this.CategoryColumn.Text = "Category";
            this.CategoryColumn.Width = 149;
            // 
            // contextMenuItem
            // 
            this.contextMenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionComplete,
            this.toolStripSeparator1,
            this.optionEdit,
            this.optionAdd,
            this.optionEditSubtasks,
            this.optionRemove});
            this.contextMenuItem.Name = "contextMenuStrip1";
            this.contextMenuItem.ShowImageMargin = false;
            this.contextMenuItem.Size = new System.Drawing.Size(126, 120);
            this.contextMenuItem.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuItem_Opening);
            // 
            // optionComplete
            // 
            this.optionComplete.Name = "optionComplete";
            this.optionComplete.Size = new System.Drawing.Size(125, 22);
            this.optionComplete.Text = "Complete task";
            this.optionComplete.Click += new System.EventHandler(this.optionComplete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
            // 
            // optionEdit
            // 
            this.optionEdit.Name = "optionEdit";
            this.optionEdit.Size = new System.Drawing.Size(125, 22);
            this.optionEdit.Text = "Edit task";
            this.optionEdit.Click += new System.EventHandler(this.optionEdit_Click);
            // 
            // optionAdd
            // 
            this.optionAdd.Name = "optionAdd";
            this.optionAdd.Size = new System.Drawing.Size(125, 22);
            this.optionAdd.Text = "Add subtasks";
            this.optionAdd.Click += new System.EventHandler(this.optionAdd_Click);
            // 
            // optionEditSubtasks
            // 
            this.optionEditSubtasks.Name = "optionEditSubtasks";
            this.optionEditSubtasks.Size = new System.Drawing.Size(125, 22);
            this.optionEditSubtasks.Text = "Edit subtasks";
            this.optionEditSubtasks.Click += new System.EventHandler(this.optionEditSubtasks_Click);
            // 
            // optionRemove
            // 
            this.optionRemove.Name = "optionRemove";
            this.optionRemove.Size = new System.Drawing.Size(125, 22);
            this.optionRemove.Text = "Remove Task";
            this.optionRemove.Click += new System.EventHandler(this.optionRemove_Click);
            // 
            // contextMenuCategories
            // 
            this.contextMenuCategories.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuCategories.Name = "contextMenuCategories";
            this.contextMenuCategories.Size = new System.Drawing.Size(153, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 482);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Simple Task Manager";
            ((System.ComponentModel.ISupportInitialize)(this.tasksTreeView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesList)).EndInit();
            this.contextMenuItem.ResumeLayout(false);
            this.contextMenuCategories.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.TreeListView tasksTreeView;
        private BrightIdeasSoftware.OLVColumn taskNameColumn;
        private BrightIdeasSoftware.OLVColumn taskDescriptionColumn;
        private BrightIdeasSoftware.OLVColumn taskDeadlineColumn;
        private BrightIdeasSoftware.OLVColumn taskDurationColumn;
        private BrightIdeasSoftware.OLVColumn taskPercentageColumn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton addTaskButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionComplete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem optionEdit;
        private System.Windows.Forms.ToolStripMenuItem optionAdd;
        private System.Windows.Forms.ToolStripMenuItem optionEditSubtasks;
        private System.Windows.Forms.ToolStripMenuItem optionRemove;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private BrightIdeasSoftware.ObjectListView CategoriesList;
        private BrightIdeasSoftware.OLVColumn CategoryColumn;
        private BrightIdeasSoftware.OLVColumn taskCategoryColumn;
        private System.Windows.Forms.ToolStripButton addCategoryButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuCategories;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;






    }
}

