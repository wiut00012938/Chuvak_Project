namespace homework_calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnplus = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.btnpower = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnmultiply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(658, 23);
            this.textBox1.TabIndex = 0;
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(63, 81);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(117, 103);
            this.btnplus.TabIndex = 1;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            // 
            // btndivide
            // 
            this.btndivide.Location = new System.Drawing.Point(63, 206);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(117, 103);
            this.btndivide.TabIndex = 2;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = true;
            // 
            // btnpower
            // 
            this.btnpower.Location = new System.Drawing.Point(327, 206);
            this.btnpower.Name = "btnpower";
            this.btnpower.Size = new System.Drawing.Size(117, 103);
            this.btnpower.TabIndex = 5;
            this.btnpower.Text = "^";
            this.btnpower.UseVisualStyleBackColor = true;
            // 
            // btnminus
            // 
            this.btnminus.Location = new System.Drawing.Point(327, 81);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(117, 103);
            this.btnminus.TabIndex = 4;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(327, 335);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(117, 103);
            this.btncalculate.TabIndex = 9;
            this.btncalculate.Text = "calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(604, 206);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(117, 103);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnmultiply
            // 
            this.btnmultiply.Location = new System.Drawing.Point(604, 81);
            this.btnmultiply.Name = "btnmultiply";
            this.btnmultiply.Size = new System.Drawing.Size(117, 103);
            this.btnmultiply.TabIndex = 7;
            this.btnmultiply.Text = "*";
            this.btnmultiply.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnmultiply);
            this.Controls.Add(this.btnpower);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.textBox1);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}