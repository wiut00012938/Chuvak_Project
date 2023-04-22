namespace homework_advancedhomework
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
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnmultiply = new System.Windows.Forms.Button();
            this.btnpower = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.btnremainder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(128, 75);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 23);
            this.txtnum1.TabIndex = 0;
            this.txtnum1.TextChanged += new System.EventHandler(this.txtnum1_TextChanged);
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(545, 75);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 23);
            this.txtnum2.TabIndex = 1;
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(128, 132);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(75, 34);
            this.btnplus.TabIndex = 2;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnmultiply
            // 
            this.btnmultiply.Location = new System.Drawing.Point(128, 237);
            this.btnmultiply.Name = "btnmultiply";
            this.btnmultiply.Size = new System.Drawing.Size(75, 34);
            this.btnmultiply.TabIndex = 3;
            this.btnmultiply.Text = "*";
            this.btnmultiply.UseVisualStyleBackColor = true;
            // 
            // btnpower
            // 
            this.btnpower.Location = new System.Drawing.Point(128, 350);
            this.btnpower.Name = "btnpower";
            this.btnpower.Size = new System.Drawing.Size(75, 34);
            this.btnpower.TabIndex = 4;
            this.btnpower.Text = "*";
            this.btnpower.UseVisualStyleBackColor = true;
            // 
            // btnminus
            // 
            this.btnminus.Location = new System.Drawing.Point(555, 132);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(75, 34);
            this.btnminus.TabIndex = 5;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            // 
            // btndivide
            // 
            this.btndivide.Location = new System.Drawing.Point(555, 246);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(75, 34);
            this.btndivide.TabIndex = 6;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = true;
            // 
            // btnremainder
            // 
            this.btnremainder.Location = new System.Drawing.Point(555, 350);
            this.btnremainder.Name = "btnremainder";
            this.btnremainder.Size = new System.Drawing.Size(75, 34);
            this.btnremainder.TabIndex = 7;
            this.btnremainder.Text = "%";
            this.btnremainder.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnremainder);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnpower);
            this.Controls.Add(this.btnmultiply);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtnum1;
        private TextBox txtnum2;
        private Button btnplus;
        private Button btnmultiply;
        private Button btnpower;
        private Button btnminus;
        private Button btndivide;
        private Button btnremainder;
    }
}