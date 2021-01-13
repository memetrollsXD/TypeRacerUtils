
namespace TypeRacerUtils
{
    partial class TypeRacerUtils
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
            this.topBox = new System.Windows.Forms.CheckBox();
            this.backBox = new System.Windows.Forms.CheckBox();
            this.mouseBox = new System.Windows.Forms.CheckBox();
            this.ctrlbRadio = new System.Windows.Forms.RadioButton();
            this.ctrlaRadio = new System.Windows.Forms.RadioButton();
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
            this.capsBox.Size = new System.Drawing.Size(147, 21);
            this.capsBox.TabIndex = 3;
            this.capsBox.Text = "Disable Caps Lock";
            this.capsBox.UseVisualStyleBackColor = true;
            // 
            // topBox
            // 
            this.topBox.AutoSize = true;
            this.topBox.Location = new System.Drawing.Point(12, 331);
            this.topBox.Name = "topBox";
            this.topBox.Size = new System.Drawing.Size(107, 21);
            this.topBox.TabIndex = 5;
            this.topBox.Text = "Stay on Top";
            this.topBox.UseVisualStyleBackColor = true;
            this.topBox.CheckedChanged += new System.EventHandler(this.topBox_CheckedChanged);
            // 
            // backBox
            // 
            this.backBox.AutoSize = true;
            this.backBox.Checked = true;
            this.backBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.backBox.Location = new System.Drawing.Point(12, 126);
            this.backBox.Name = "backBox";
            this.backBox.Size = new System.Drawing.Size(130, 21);
            this.backBox.TabIndex = 6;
            this.backBox.Text = "One Backspace";
            this.backBox.UseVisualStyleBackColor = true;
            // 
            // mouseBox
            // 
            this.mouseBox.AutoSize = true;
            this.mouseBox.Checked = true;
            this.mouseBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mouseBox.Location = new System.Drawing.Point(12, 153);
            this.mouseBox.Name = "mouseBox";
            this.mouseBox.Size = new System.Drawing.Size(205, 21);
            this.mouseBox.TabIndex = 7;
            this.mouseBox.Text = "Disable Mouse while Typing";
            this.mouseBox.UseVisualStyleBackColor = true;
            // 
            // ctrlbRadio
            // 
            this.ctrlbRadio.AutoSize = true;
            this.ctrlbRadio.Location = new System.Drawing.Point(244, 126);
            this.ctrlbRadio.Name = "ctrlbRadio";
            this.ctrlbRadio.Size = new System.Drawing.Size(117, 21);
            this.ctrlbRadio.TabIndex = 8;
            this.ctrlbRadio.Text = "CTRL + BACK";
            this.ctrlbRadio.UseVisualStyleBackColor = true;
            // 
            // ctrlaRadio
            // 
            this.ctrlaRadio.AutoSize = true;
            this.ctrlaRadio.Checked = true;
            this.ctrlaRadio.Location = new System.Drawing.Point(148, 126);
            this.ctrlaRadio.Name = "ctrlaRadio";
            this.ctrlaRadio.Size = new System.Drawing.Size(90, 21);
            this.ctrlaRadio.TabIndex = 9;
            this.ctrlaRadio.TabStop = true;
            this.ctrlaRadio.Text = "CTRL + A";
            this.ctrlaRadio.UseVisualStyleBackColor = true;
            // 
            // TypeRacerUtils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 392);
            this.Controls.Add(this.ctrlaRadio);
            this.Controls.Add(this.ctrlbRadio);
            this.Controls.Add(this.mouseBox);
            this.Controls.Add(this.backBox);
            this.Controls.Add(this.topBox);
            this.Controls.Add(this.capsBox);
            this.Controls.Add(this.shortBox);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.hookBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TypeRacerUtils";
            this.Text = "TypeRacer Utils";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hookBtn;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.CheckBox shortBox;
        private System.Windows.Forms.CheckBox capsBox;
        private System.Windows.Forms.CheckBox topBox;
        private System.Windows.Forms.CheckBox backBox;
        private System.Windows.Forms.CheckBox mouseBox;
        private System.Windows.Forms.RadioButton ctrlbRadio;
        private System.Windows.Forms.RadioButton ctrlaRadio;
    }
}

