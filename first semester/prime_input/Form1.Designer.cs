namespace prime_input
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
            this.btncheck = new System.Windows.Forms.Button();
            this.lbldescription = new System.Windows.Forms.Label();
            this.txtguess = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(316, 256);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(124, 40);
            this.btncheck.TabIndex = 0;
            this.btncheck.Text = "check";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldescription.Location = new System.Drawing.Point(236, 130);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(317, 48);
            this.lbldescription.TabIndex = 1;
            this.lbldescription.Text = "Enter your number";
            // 
            // txtguess
            // 
            this.txtguess.Location = new System.Drawing.Point(316, 200);
            this.txtguess.Name = "txtguess";
            this.txtguess.Size = new System.Drawing.Size(124, 23);
            this.txtguess.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtguess);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.btncheck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btncheck;
        private Label lbldescription;
        private TextBox txtguess;
    }
}