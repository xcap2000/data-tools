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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            descriptionLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            descriptionDisplayLabel = new System.Windows.Forms.Label();
            typeDisplayLabel = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(3, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 15);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID";
            // 
            // idDisplayLabel
            // 
            idDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            idDisplayLabel.Location = new System.Drawing.Point(3, 15);
            idDisplayLabel.Name = "idDisplayLabel";
            idDisplayLabel.Size = new System.Drawing.Size(250, 23);
            idDisplayLabel.TabIndex = 1;
            idDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            tableLayoutPanel1.Controls.Add(descriptionLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(typeLabel, 2, 0);
            tableLayoutPanel1.Controls.Add(descriptionDisplayLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(typeDisplayLabel, 3, 0);
            tableLayoutPanel1.Controls.Add(button1, 4, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1100, 163);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(3, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(67, 15);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(538, 0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(31, 15);
            typeLabel.TabIndex = 1;
            typeLabel.Text = "Type";
            // 
            // descriptionDisplayLabel
            // 
            descriptionDisplayLabel.AutoSize = true;
            descriptionDisplayLabel.Location = new System.Drawing.Point(103, 0);
            descriptionDisplayLabel.Name = "descriptionDisplayLabel";
            descriptionDisplayLabel.Size = new System.Drawing.Size(67, 15);
            descriptionDisplayLabel.TabIndex = 2;
            descriptionDisplayLabel.Text = "Description";
            // 
            // typeDisplayLabel
            // 
            typeDisplayLabel.AutoSize = true;
            typeDisplayLabel.Location = new System.Drawing.Point(638, 0);
            typeDisplayLabel.Name = "typeDisplayLabel";
            typeDisplayLabel.Size = new System.Drawing.Size(31, 15);
            typeDisplayLabel.TabIndex = 3;
            typeDisplayLabel.Text = "Type";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(1073, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(23, 23);
            button1.TabIndex = 4;
            button1.Text = "v";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            tableLayoutPanel1.SetColumnSpan(panel1, 5);
            panel1.Controls.Add(idLabel);
            panel1.Controls.Add(idDisplayLabel);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(3, 32);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1094, 128);
            panel1.TabIndex = 5;
            // 
            // TaskView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(tableLayoutPanel1);
            Name = "TaskView";
            Size = new System.Drawing.Size(1106, 169);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label idDisplayLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label descriptionDisplayLabel;
        private System.Windows.Forms.Label typeDisplayLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}
