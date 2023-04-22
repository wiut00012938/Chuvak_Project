namespace The_sum
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
            this.btn_even = new System.Windows.Forms.Button();
            this.btn_odd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_even
            // 
            this.btn_even.Location = new System.Drawing.Point(61, 33);
            this.btn_even.Name = "btn_even";
            this.btn_even.Size = new System.Drawing.Size(181, 80);
            this.btn_even.TabIndex = 0;
            this.btn_even.Text = "even number";
            this.btn_even.UseVisualStyleBackColor = true;
            this.btn_even.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_odd
            // 
            this.btn_odd.Location = new System.Drawing.Point(61, 166);
            this.btn_odd.Name = "btn_odd";
            this.btn_odd.Size = new System.Drawing.Size(181, 80);
            this.btn_odd.TabIndex = 1;
            this.btn_odd.Text = "odd number";
            this.btn_odd.UseVisualStyleBackColor = true;
            this.btn_odd.Click += new System.EventHandler(this.btn_odd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 305);
            this.Controls.Add(this.btn_odd);
            this.Controls.Add(this.btn_even);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_even;
        private Button btn_odd;
    }
}