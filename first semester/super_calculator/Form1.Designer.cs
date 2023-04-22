namespace super_calculator
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
            this.tbxFirstNumber = new System.Windows.Forms.TextBox();
            this.TbxSecondNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxFirstNumber
            // 
            this.tbxFirstNumber.Location = new System.Drawing.Point(136, 88);
            this.tbxFirstNumber.Name = "tbxFirstNumber";
            this.tbxFirstNumber.Size = new System.Drawing.Size(149, 23);
            this.tbxFirstNumber.TabIndex = 0;
            // 
            // TbxSecondNumber
            // 
            this.TbxSecondNumber.Location = new System.Drawing.Point(469, 88);
            this.TbxSecondNumber.Name = "TbxSecondNumber";
            this.TbxSecondNumber.Size = new System.Drawing.Size(149, 23);
            this.TbxSecondNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your first number in words";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter your second number in words";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxSecondNumber);
            this.Controls.Add(this.tbxFirstNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbxFirstNumber;
        private TextBox TbxSecondNumber;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}