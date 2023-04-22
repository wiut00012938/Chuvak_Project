namespace textAnalysis
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
            this.tbxinput = new System.Windows.Forms.TextBox();
            this.btnenter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxinput
            // 
            this.tbxinput.Location = new System.Drawing.Point(12, 12);
            this.tbxinput.Name = "tbxinput";
            this.tbxinput.Size = new System.Drawing.Size(424, 23);
            this.tbxinput.TabIndex = 0;
            // 
            // btnenter
            // 
            this.btnenter.Location = new System.Drawing.Point(170, 41);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(75, 23);
            this.btnenter.TabIndex = 1;
            this.btnenter.Text = "enter";
            this.btnenter.UseVisualStyleBackColor = true;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 214);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.tbxinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbxinput;
        private Button btnenter;
    }
}