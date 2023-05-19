namespace CarpeDiem.DataTools.Calculator.Views
{
    partial class CalculatorView
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
            components = new System.ComponentModel.Container();
            messageLabel = new System.Windows.Forms.Label();
            sumButton = new System.Windows.Forms.Button();
            resultLabel = new System.Windows.Forms.Label();
            value2TextBox = new System.Windows.Forms.TextBox();
            value1TextBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            errorProvider = new System.Windows.Forms.ErrorProvider(components);
            closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // messageLabel
            // 
            messageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            messageLabel.ForeColor = System.Drawing.Color.Red;
            messageLabel.Location = new System.Drawing.Point(12, 135);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(760, 23);
            messageLabel.TabIndex = 15;
            messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sumButton
            // 
            sumButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            sumButton.AutoSize = true;
            sumButton.Location = new System.Drawing.Point(616, 524);
            sumButton.Name = "sumButton";
            sumButton.Size = new System.Drawing.Size(75, 25);
            sumButton.TabIndex = 14;
            sumButton.Text = "Sum";
            sumButton.UseVisualStyleBackColor = true;
            // 
            // resultLabel
            // 
            resultLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            resultLabel.Location = new System.Drawing.Point(12, 112);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new System.Drawing.Size(760, 23);
            resultLabel.TabIndex = 13;
            resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // value2TextBox
            // 
            value2TextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            value2TextBox.Location = new System.Drawing.Point(12, 71);
            value2TextBox.Name = "value2TextBox";
            value2TextBox.PlaceholderText = "Enter Value 2";
            value2TextBox.Size = new System.Drawing.Size(760, 23);
            value2TextBox.TabIndex = 12;
            // 
            // value1TextBox
            // 
            value1TextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            value1TextBox.Location = new System.Drawing.Point(12, 27);
            value1TextBox.Name = "value1TextBox";
            value1TextBox.PlaceholderText = "Enter Value 1";
            value1TextBox.Size = new System.Drawing.Size(760, 23);
            value1TextBox.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 97);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(42, 15);
            label3.TabIndex = 10;
            label3.Text = "Result:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 53);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 15);
            label2.TabIndex = 9;
            label2.Text = "Value 2:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 15);
            label1.TabIndex = 8;
            label1.Text = "Value 1:";
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // closeButton
            // 
            closeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            closeButton.AutoSize = true;
            closeButton.Location = new System.Drawing.Point(697, 524);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(75, 25);
            closeButton.TabIndex = 16;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // CalculatorView
            // 
            AcceptButton = sumButton;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            CancelButton = closeButton;
            ClientSize = new System.Drawing.Size(784, 561);
            Controls.Add(closeButton);
            Controls.Add(messageLabel);
            Controls.Add(sumButton);
            Controls.Add(resultLabel);
            Controls.Add(value2TextBox);
            Controls.Add(value1TextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new System.Drawing.Size(800, 600);
            Name = "CalculatorView";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            Text = "Calculator";
            Load += WinFormsMiniCalcView_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox value2TextBox;
        private System.Windows.Forms.TextBox value1TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button closeButton;
    }
}