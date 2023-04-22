namespace inclass_calculator
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
            this.tbxsecond = new System.Windows.Forms.TextBox();
            this.tbxfirst = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxsecond
            // 
            this.tbxsecond.Location = new System.Drawing.Point(366, 32);
            this.tbxsecond.Name = "tbxsecond";
            this.tbxsecond.Size = new System.Drawing.Size(365, 23);
            this.tbxsecond.TabIndex = 0;
            // 
            // tbxfirst
            // 
            this.tbxfirst.Location = new System.Drawing.Point(23, 32);
            this.tbxfirst.Name = "tbxfirst";
            this.tbxfirst.Size = new System.Drawing.Size(293, 23);
            this.tbxfirst.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 137);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxfirst);
            this.Controls.Add(this.tbxsecond);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbxsecond;
        private TextBox tbxfirst;
        private Button button1;
    }
}