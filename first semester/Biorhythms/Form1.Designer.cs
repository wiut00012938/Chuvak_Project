namespace Biorhythms
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
            this.firstDate = new System.Windows.Forms.DateTimePicker();
            this.secondDate = new System.Windows.Forms.DateTimePicker();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstDate
            // 
            this.firstDate.Location = new System.Drawing.Point(12, 12);
            this.firstDate.Name = "firstDate";
            this.firstDate.Size = new System.Drawing.Size(200, 23);
            this.firstDate.TabIndex = 0;
            this.firstDate.ValueChanged += new System.EventHandler(this.firstDate_ValueChanged);
            // 
            // secondDate
            // 
            this.secondDate.Location = new System.Drawing.Point(307, 12);
            this.secondDate.Name = "secondDate";
            this.secondDate.Size = new System.Drawing.Size(200, 23);
            this.secondDate.TabIndex = 1;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(179, 67);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(156, 62);
            this.btnsubmit.TabIndex = 2;
            this.btnsubmit.Text = "submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 176);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.secondDate);
            this.Controls.Add(this.firstDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker firstDate;
        private DateTimePicker secondDate;
        private Button btnsubmit;
    }
}