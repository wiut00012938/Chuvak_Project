namespace seminar5_homework
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
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.btnenter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(22, 39);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(339, 23);
            this.tbx1.TabIndex = 0;
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(22, 93);
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(339, 23);
            this.tbx2.TabIndex = 1;
            // 
            // btnenter
            // 
            this.btnenter.Location = new System.Drawing.Point(144, 156);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(75, 23);
            this.btnenter.TabIndex = 2;
            this.btnenter.Text = "enter";
            this.btnenter.UseVisualStyleBackColor = true;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 265);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.tbx2);
            this.Controls.Add(this.tbx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbx1;
        private TextBox tbx2;
        private Button btnenter;
    }
}