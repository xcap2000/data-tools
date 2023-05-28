namespace CarpeDiem.DataTools.Tasks.Views
{
    partial class TaskView
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
            idLabel = new System.Windows.Forms.Label();
            idDisplayLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(3, 3);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 15);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID";
            // 
            // idDisplayLabel
            // 
            idDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            idDisplayLabel.Location = new System.Drawing.Point(3, 18);
            idDisplayLabel.Name = "idDisplayLabel";
            idDisplayLabel.Size = new System.Drawing.Size(250, 23);
            idDisplayLabel.TabIndex = 1;
            idDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TaskView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(idDisplayLabel);
            Controls.Add(idLabel);
            Name = "TaskView";
            Size = new System.Drawing.Size(256, 41);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label idDisplayLabel;
    }
}
