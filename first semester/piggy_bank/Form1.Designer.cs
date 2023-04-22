namespace piggy_bank
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
            this.tbx1pound = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxpound2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxpound5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxpound10 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxpound20 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbx1pound
            // 
            this.tbx1pound.Location = new System.Drawing.Point(12, 57);
            this.tbx1pound.Name = "tbx1pound";
            this.tbx1pound.Size = new System.Drawing.Size(138, 23);
            this.tbx1pound.TabIndex = 0;
            this.tbx1pound.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx1pound_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "number of 1pound coins";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(324, 127);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(155, 93);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "number of 2pound coins";
            // 
            // tbxpound2
            // 
            this.tbxpound2.Location = new System.Drawing.Point(179, 57);
            this.tbxpound2.Name = "tbxpound2";
            this.tbxpound2.Size = new System.Drawing.Size(138, 23);
            this.tbxpound2.TabIndex = 3;
            this.tbxpound2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxpound2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "number of 5pound coins";
            // 
            // tbxpound5
            // 
            this.tbxpound5.Location = new System.Drawing.Point(341, 57);
            this.tbxpound5.Name = "tbxpound5";
            this.tbxpound5.Size = new System.Drawing.Size(138, 23);
            this.tbxpound5.TabIndex = 5;
            this.tbxpound5.TextChanged += new System.EventHandler(this.tbxpound5_TextChanged);
            this.tbxpound5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxpound5_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "number of 10pound coins";
            // 
            // tbxpound10
            // 
            this.tbxpound10.Location = new System.Drawing.Point(495, 57);
            this.tbxpound10.Name = "tbxpound10";
            this.tbxpound10.Size = new System.Drawing.Size(138, 23);
            this.tbxpound10.TabIndex = 7;
            this.tbxpound10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxpound10_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(650, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "number of 20pound coins";
            // 
            // tbxpound20
            // 
            this.tbxpound20.Location = new System.Drawing.Point(650, 57);
            this.tbxpound20.Name = "tbxpound20";
            this.tbxpound20.Size = new System.Drawing.Size(138, 23);
            this.tbxpound20.TabIndex = 9;
            this.tbxpound20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxpound20_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 276);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxpound20);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxpound10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxpound5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxpound2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx1pound);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbx1pound;
        private Label label1;
        private Button btnCalculate;
        private Label label2;
        private TextBox tbxpound2;
        private Label label3;
        private TextBox tbxpound5;
        private Label label4;
        private TextBox tbxpound10;
        private Label label5;
        private TextBox tbxpound20;
    }
}