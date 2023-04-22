namespace seminar2
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblsurname = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.lblinterest = new System.Windows.Forms.Label();
            this.numamount = new System.Windows.Forms.NumericUpDown();
            this.numinterest = new System.Windows.Forms.NumericUpDown();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lbldurability = new System.Windows.Forms.Label();
            this.numdurability = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numamount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numinterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdurability)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(197, 70);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(120, 15);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Enter your first name:";
            this.lblname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblsurname
            // 
            this.lblsurname.AutoSize = true;
            this.lblsurname.Location = new System.Drawing.Point(197, 117);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(113, 15);
            this.lblsurname.TabIndex = 1;
            this.lblsurname.Text = "Enter your surname:";
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Location = new System.Drawing.Point(197, 154);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(174, 15);
            this.lblamount.TabIndex = 2;
            this.lblamount.Text = "Enter an amount of investment:";
            // 
            // lblinterest
            // 
            this.lblinterest.AutoSize = true;
            this.lblinterest.Location = new System.Drawing.Point(197, 192);
            this.lblinterest.Name = "lblinterest";
            this.lblinterest.Size = new System.Drawing.Size(118, 15);
            this.lblinterest.TabIndex = 3;
            this.lblinterest.Text = "Enter an interest rate:";
            // 
            // numamount
            // 
            this.numamount.DecimalPlaces = 2;
            this.numamount.Location = new System.Drawing.Point(403, 152);
            this.numamount.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numamount.Name = "numamount";
            this.numamount.Size = new System.Drawing.Size(120, 23);
            this.numamount.TabIndex = 4;
            // 
            // numinterest
            // 
            this.numinterest.DecimalPlaces = 2;
            this.numinterest.Location = new System.Drawing.Point(403, 184);
            this.numinterest.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numinterest.Name = "numinterest";
            this.numinterest.Size = new System.Drawing.Size(120, 23);
            this.numinterest.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(403, 67);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(120, 23);
            this.txtname.TabIndex = 6;
            // 
            // txtsurname
            // 
            this.txtsurname.Location = new System.Drawing.Point(403, 114);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(120, 23);
            this.txtsurname.TabIndex = 7;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(329, 326);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(113, 62);
            this.btncalculate.TabIndex = 8;
            this.btncalculate.Text = "calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // lbldurability
            // 
            this.lbldurability.AutoSize = true;
            this.lbldurability.Location = new System.Drawing.Point(199, 243);
            this.lbldurability.Name = "lbldurability";
            this.lbldurability.Size = new System.Drawing.Size(118, 15);
            this.lbldurability.TabIndex = 9;
            this.lbldurability.Text = "Enter an interest rate:";
            // 
            // numdurability
            // 
            this.numdurability.Location = new System.Drawing.Point(403, 235);
            this.numdurability.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numdurability.Name = "numdurability";
            this.numdurability.Size = new System.Drawing.Size(120, 23);
            this.numdurability.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numdurability);
            this.Controls.Add(this.lbldurability);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.numinterest);
            this.Controls.Add(this.numamount);
            this.Controls.Add(this.lblinterest);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.lblsurname);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numamount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numinterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdurability)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblname;
        private Label lblsurname;
        private Label lblamount;
        private Label lblinterest;
        private NumericUpDown numamount;
        private NumericUpDown numinterest;
        private TextBox txtname;
        private TextBox txtsurname;
        private Button btncalculate;
        private Label lbldurability;
        private NumericUpDown numdurability;
    }
}