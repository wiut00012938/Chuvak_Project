namespace Circle
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
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.lblCircule = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(30, 57);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(161, 23);
            this.tbxInput.TabIndex = 0;
            // 
            // lblCircule
            // 
            this.lblCircule.AutoSize = true;
            this.lblCircule.Location = new System.Drawing.Point(30, 24);
            this.lblCircule.Name = "lblCircule";
            this.lblCircule.Size = new System.Drawing.Size(161, 15);
            this.lblCircule.TabIndex = 1;
            this.lblCircule.Text = "Enter the radius of the circule";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enter for calculating c and area";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCircule);
            this.Controls.Add(this.tbxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbxInput;
        private Label lblCircule;
        private Button button1;
    }
}