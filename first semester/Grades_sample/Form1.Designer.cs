namespace Grades_sample
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
            this.numinput = new System.Windows.Forms.NumericUpDown();
            this.btnsubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numinput)).BeginInit();
            this.SuspendLayout();
            // 
            // numinput
            // 
            this.numinput.DecimalPlaces = 1;
            this.numinput.Location = new System.Drawing.Point(278, 66);
            this.numinput.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numinput.Name = "numinput";
            this.numinput.Size = new System.Drawing.Size(120, 23);
            this.numinput.TabIndex = 0;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(307, 103);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 1;
            this.btnsubmit.Text = "button1";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.numinput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numinput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NumericUpDown numinput;
        private Button btnsubmit;
    }
}