namespace CruelGame
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
            this.rdless21 = new System.Windows.Forms.RadioButton();
            this.rdbetween21and35 = new System.Windows.Forms.RadioButton();
            this.rdmore35 = new System.Windows.Forms.RadioButton();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdless21
            // 
            this.rdless21.AutoSize = true;
            this.rdless21.Location = new System.Drawing.Point(353, 175);
            this.rdless21.Name = "rdless21";
            this.rdless21.Size = new System.Drawing.Size(45, 19);
            this.rdless21.TabIndex = 0;
            this.rdless21.TabStop = true;
            this.rdless21.Text = "<21";
            this.rdless21.UseVisualStyleBackColor = true;
            // 
            // rdbetween21and35
            // 
            this.rdbetween21and35.AutoSize = true;
            this.rdbetween21and35.Location = new System.Drawing.Point(353, 216);
            this.rdbetween21and35.Name = "rdbetween21and35";
            this.rdbetween21and35.Size = new System.Drawing.Size(126, 19);
            this.rdbetween21and35.TabIndex = 1;
            this.rdbetween21and35.TabStop = true;
            this.rdbetween21and35.Text = "Between 21 and  35";
            this.rdbetween21and35.UseVisualStyleBackColor = true;
            // 
            // rdmore35
            // 
            this.rdmore35.AutoSize = true;
            this.rdmore35.Location = new System.Drawing.Point(353, 254);
            this.rdmore35.Name = "rdmore35";
            this.rdmore35.Size = new System.Drawing.Size(95, 19);
            this.rdmore35.TabIndex = 2;
            this.rdmore35.TabStop = true;
            this.rdmore35.Text = "More than 35";
            this.rdmore35.UseVisualStyleBackColor = true;
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(353, 294);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(94, 32);
            this.btnconfirm.TabIndex = 3;
            this.btnconfirm.Text = "Send";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter you age:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.rdmore35);
            this.Controls.Add(this.rdbetween21and35);
            this.Controls.Add(this.rdless21);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rdless21;
        private RadioButton rdbetween21and35;
        private RadioButton rdmore35;
        private Button btnconfirm;
        private Label label1;
    }
}