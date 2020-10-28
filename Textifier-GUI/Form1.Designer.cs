namespace Textifier_GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.effectSelectBox = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Effect";
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(13, 33);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(357, 27);
            this.messageBox.TabIndex = 4;
            // 
            // effectSelectBox
            // 
            this.effectSelectBox.BackColor = System.Drawing.Color.White;
            this.effectSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.effectSelectBox.FormattingEnabled = true;
            this.effectSelectBox.Items.AddRange(new object[] {
            "Random Capitalization",
            "Regional Indicators"});
            this.effectSelectBox.Location = new System.Drawing.Point(13, 90);
            this.effectSelectBox.Name = "effectSelectBox";
            this.effectSelectBox.Size = new System.Drawing.Size(357, 28);
            this.effectSelectBox.TabIndex = 5;
            // 
            // submitButton
            // 
            this.submitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.submitButton.Location = new System.Drawing.Point(0, 136);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(382, 49);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Apply and Copy";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 185);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.effectSelectBox);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Textifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.ComboBox effectSelectBox;
        private System.Windows.Forms.Button submitButton;
    }
}

