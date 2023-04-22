namespace seminar4_homework
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
            this.btnroot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numinput)).BeginInit();
            this.SuspendLayout();
            // 
            // numinput
            // 
            this.numinput.Location = new System.Drawing.Point(290, 77);
            this.numinput.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numinput.Name = "numinput";
            this.numinput.Size = new System.Drawing.Size(147, 23);
            this.numinput.TabIndex = 0;
            // 
            // btnroot
            // 
            this.btnroot.Location = new System.Drawing.Point(290, 138);
            this.btnroot.Name = "btnroot";
            this.btnroot.Size = new System.Drawing.Size(147, 29);
            this.btnroot.TabIndex = 1;
            this.btnroot.Text = "square root";
            this.btnroot.UseVisualStyleBackColor = true;
            this.btnroot.Click += new System.EventHandler(this.btnroot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnroot);
            this.Controls.Add(this.numinput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numinput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numinput;
        private Button btnroot;
        private Label label1;
    }
}