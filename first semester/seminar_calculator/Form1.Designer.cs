namespace seminar_calculator
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.btnplus = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnmulitiply = new System.Windows.Forms.Button();
            this.btnpower = new System.Windows.Forms.Button();
            this.btnremainder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(149, 95);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 23);
            this.num1.TabIndex = 0;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(492, 95);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 23);
            this.num2.TabIndex = 1;
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(149, 172);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(75, 56);
            this.btnplus.TabIndex = 2;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btndivide
            // 
            this.btndivide.Location = new System.Drawing.Point(149, 265);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(75, 56);
            this.btndivide.TabIndex = 3;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = true;
            this.btndivide.Click += new System.EventHandler(this.btndivide_Click);
            // 
            // btnminus
            // 
            this.btnminus.Location = new System.Drawing.Point(322, 172);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(75, 56);
            this.btnminus.TabIndex = 4;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btnmulitiply
            // 
            this.btnmulitiply.Location = new System.Drawing.Point(517, 172);
            this.btnmulitiply.Name = "btnmulitiply";
            this.btnmulitiply.Size = new System.Drawing.Size(75, 56);
            this.btnmulitiply.TabIndex = 5;
            this.btnmulitiply.Text = "*";
            this.btnmulitiply.UseVisualStyleBackColor = true;
            this.btnmulitiply.Click += new System.EventHandler(this.btnmulitiply_Click);
            // 
            // btnpower
            // 
            this.btnpower.Location = new System.Drawing.Point(322, 265);
            this.btnpower.Name = "btnpower";
            this.btnpower.Size = new System.Drawing.Size(75, 56);
            this.btnpower.TabIndex = 6;
            this.btnpower.Text = "^";
            this.btnpower.UseVisualStyleBackColor = true;
            this.btnpower.Click += new System.EventHandler(this.btnpower_Click);
            // 
            // btnremainder
            // 
            this.btnremainder.Location = new System.Drawing.Point(517, 265);
            this.btnremainder.Name = "btnremainder";
            this.btnremainder.Size = new System.Drawing.Size(75, 56);
            this.btnremainder.TabIndex = 7;
            this.btnremainder.Text = "%%";
            this.btnremainder.UseVisualStyleBackColor = true;
            this.btnremainder.Click += new System.EventHandler(this.btnremainder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnremainder);
            this.Controls.Add(this.btnpower);
            this.Controls.Add(this.btnmulitiply);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox num1;
        private TextBox num2;
        private Button btnplus;
        private Button btndivide;
        private Button btnminus;
        private Button btnmulitiply;
        private Button btnpower;
        private Button btnremainder;
    }
}