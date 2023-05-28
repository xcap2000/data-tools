namespace CarpeDiem.DataTools.Tasks.Views
{
    partial class TaskListView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tasksPanel = new System.Windows.Forms.Panel();
            SuspendLayout();
            // 
            // tasksPanel
            // 
            tasksPanel.AutoSize = true;
            tasksPanel.Dock = System.Windows.Forms.DockStyle.Top;
            tasksPanel.Location = new System.Drawing.Point(0, 0);
            tasksPanel.MinimumSize = new System.Drawing.Size(0, 10);
            tasksPanel.Name = "tasksPanel";
            tasksPanel.Size = new System.Drawing.Size(800, 10);
            tasksPanel.TabIndex = 0;
            // 
            // TaskListView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(tasksPanel);
            Name = "TaskListView";
            Size = new System.Drawing.Size(800, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel tasksPanel;
    }
}
