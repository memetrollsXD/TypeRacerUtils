
namespace TypeRacerUtils
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
            this.hookBtn = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.shortBox = new System.Windows.Forms.CheckBox();
            this.capsBox = new System.Windows.Forms.CheckBox();
            this.shiftBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // hookBtn
            // 
            this.hookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.hookBtn.Location = new System.Drawing.Point(12, 12);
            this.hookBtn.Name = "hookBtn";
            this.hookBtn.Size = new System.Drawing.Size(360, 54);
            this.hookBtn.TabIndex = 0;
            this.hookBtn.Text = "Unhook";
            this.hookBtn.UseVisualStyleBackColor = true;
            this.hookBtn.Click += new System.EventHandler(this.hookBtn_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 358);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(360, 22);
            this.outputBox.TabIndex = 1;
            // 
            // shortBox
            // 
            this.shortBox.AutoSize = true;
            this.shortBox.Checked = true;
            this.shortBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.shortBox.Location = new System.Drawing.Point(12, 72);
            this.shortBox.Name = "shortBox";
            this.shortBox.Size = new System.Drawing.Size(305, 21);
            this.shortBox.TabIndex = 2;
            this.shortBox.Text = "Disable Save and Print Shortcuts (CTRL+S)";
            this.shortBox.UseVisualStyleBackColor = true;
            // 
            // capsBox
            // 
            this.capsBox.AutoSize = true;
            this.capsBox.Checked = true;
            this.capsBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.capsBox.Location = new System.Drawing.Point(12, 99);
            this.capsBox.Name = "capsBox";
            this.capsBox.Size = new System.Drawing.Size(242, 21);
            this.capsBox.TabIndex = 3;
            this.capsBox.Text = "Disable Caps Lock (Experimental)";
            this.capsBox.UseVisualStyleBackColor = true;
            // 
            // shiftBox
            // 
            this.shiftBox.AutoSize = true;
            this.shiftBox.Location = new System.Drawing.Point(12, 126);
            this.shiftBox.Name = "shiftBox";
            this.shiftBox.Size = new System.Drawing.Size(136, 21);
            this.shiftBox.TabIndex = 4;
            this.shiftBox.Text = "1 Character Shift";
            this.shiftBox.UseVisualStyleBackColor = true;
            this.shiftBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 392);
            this.Controls.Add(this.shiftBox);
            this.Controls.Add(this.capsBox);
            this.Controls.Add(this.shortBox);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.hookBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TypeRacer Utils";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hookBtn;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.CheckBox shortBox;
        private System.Windows.Forms.CheckBox capsBox;
        private System.Windows.Forms.CheckBox shiftBox;
    }
}

