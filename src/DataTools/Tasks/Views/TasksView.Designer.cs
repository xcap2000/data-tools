namespace CarpeDiem.DataTools.Tasks.Views
{
    partial class TasksView
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
            idLabel = new System.Windows.Forms.Label();
            taskIdTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            taskDataGridView = new System.Windows.Forms.DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskDataGridView).BeginInit();
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
            // taskIdTextBox
            // 
            taskIdTextBox.Location = new System.Drawing.Point(3, 18);
            taskIdTextBox.Name = "taskIdTextBox";
            taskIdTextBox.Size = new System.Drawing.Size(220, 23);
            taskIdTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(256, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(39, 15);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(256, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(220, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button1.Location = new System.Drawing.Point(682, 47);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Filter";
            button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel1.Controls.Add(idLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(taskIdTextBox, 0, 1);
            tableLayoutPanel1.Controls.Add(button1, 2, 2);
            tableLayoutPanel1.Controls.Add(nameLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(760, 74);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // taskDataGridView
            // 
            taskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            taskDataGridView.Location = new System.Drawing.Point(12, 92);
            taskDataGridView.Name = "taskDataGridView";
            taskDataGridView.RowTemplate.Height = 25;
            taskDataGridView.Size = new System.Drawing.Size(760, 150);
            taskDataGridView.TabIndex = 7;
            // 
            // TasksView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(784, 561);
            Controls.Add(taskDataGridView);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new System.Drawing.Size(800, 600);
            Name = "TasksView";
            Text = "Tasks";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)taskDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox taskIdTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView taskDataGridView;
    }
}