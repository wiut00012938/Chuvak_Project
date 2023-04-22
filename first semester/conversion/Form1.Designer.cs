namespace conversion
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
            this.lblEnter = new System.Windows.Forms.Label();
            this.btnInch = new System.Windows.Forms.Button();
            this.btnMile = new System.Windows.Forms.Button();
            this.btnFeet = new System.Windows.Forms.Button();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnter.Location = new System.Drawing.Point(100, 34);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(233, 22);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Enter the distance in meters";
            // 
            // btnInch
            // 
            this.btnInch.Location = new System.Drawing.Point(12, 119);
            this.btnInch.Name = "btnInch";
            this.btnInch.Size = new System.Drawing.Size(101, 71);
            this.btnInch.TabIndex = 1;
            this.btnInch.Text = "Convert meteres to inches";
            this.btnInch.UseVisualStyleBackColor = true;
            this.btnInch.Click += new System.EventHandler(this.btnInch_Click);
            // 
            // btnMile
            // 
            this.btnMile.Location = new System.Drawing.Point(150, 119);
            this.btnMile.Name = "btnMile";
            this.btnMile.Size = new System.Drawing.Size(101, 71);
            this.btnMile.TabIndex = 2;
            this.btnMile.Text = "Convert to miles";
            this.btnMile.UseVisualStyleBackColor = true;
            this.btnMile.Click += new System.EventHandler(this.btnMile_Click);
            // 
            // btnFeet
            // 
            this.btnFeet.Location = new System.Drawing.Point(292, 119);
            this.btnFeet.Name = "btnFeet";
            this.btnFeet.Size = new System.Drawing.Size(101, 71);
            this.btnFeet.TabIndex = 3;
            this.btnFeet.Text = "Convert to foots";
            this.btnFeet.UseVisualStyleBackColor = true;
            this.btnFeet.Click += new System.EventHandler(this.btnFeet_Click);
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(82, 75);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(262, 23);
            this.tbxInput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 264);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.btnFeet);
            this.Controls.Add(this.btnMile);
            this.Controls.Add(this.btnInch);
            this.Controls.Add(this.lblEnter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEnter;
        private Button btnInch;
        private Button btnMile;
        private Button btnFeet;
        private TextBox tbxInput;
    }
}