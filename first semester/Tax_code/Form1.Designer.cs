namespace Tax_code
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.numPurachase = new System.Windows.Forms.NumericUpDown();
            this.tax_exempt = new System.Windows.Forms.RadioButton();
            this.state_sales = new System.Windows.Forms.RadioButton();
            this.federal = new System.Windows.Forms.RadioButton();
            this.special = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPurachase)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(54, 23);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(164, 23);
            this.tbxName.TabIndex = 1;
            // 
            // numPurachase
            // 
            this.numPurachase.Location = new System.Drawing.Point(54, 71);
            this.numPurachase.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numPurachase.Name = "numPurachase";
            this.numPurachase.Size = new System.Drawing.Size(164, 23);
            this.numPurachase.TabIndex = 2;
            // 
            // tax_exempt
            // 
            this.tax_exempt.AutoSize = true;
            this.tax_exempt.Location = new System.Drawing.Point(54, 120);
            this.tax_exempt.Name = "tax_exempt";
            this.tax_exempt.Size = new System.Drawing.Size(87, 19);
            this.tax_exempt.TabIndex = 3;
            this.tax_exempt.TabStop = true;
            this.tax_exempt.Text = "tax exempt ";
            this.tax_exempt.UseVisualStyleBackColor = true;
            // 
            // state_sales
            // 
            this.state_sales.AutoSize = true;
            this.state_sales.Location = new System.Drawing.Point(54, 145);
            this.state_sales.Name = "state_sales";
            this.state_sales.Size = new System.Drawing.Size(126, 19);
            this.state_sales.TabIndex = 4;
            this.state_sales.TabStop = true;
            this.state_sales.Text = "state sales tax only ";
            this.state_sales.UseVisualStyleBackColor = true;
            // 
            // federal
            // 
            this.federal.AutoSize = true;
            this.federal.Location = new System.Drawing.Point(54, 170);
            this.federal.Name = "federal";
            this.federal.Size = new System.Drawing.Size(162, 19);
            this.federal.TabIndex = 5;
            this.federal.TabStop = true;
            this.federal.Text = "federal and state sales tax ";
            this.federal.UseVisualStyleBackColor = true;
            // 
            // special
            // 
            this.special.AutoSize = true;
            this.special.Location = new System.Drawing.Point(54, 195);
            this.special.Name = "special";
            this.special.Size = new System.Drawing.Size(111, 19);
            this.special.TabIndex = 6;
            this.special.TabStop = true;
            this.special.Text = "special sales tax ";
            this.special.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(302, 71);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(148, 88);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 264);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.special);
            this.Controls.Add(this.federal);
            this.Controls.Add(this.state_sales);
            this.Controls.Add(this.tax_exempt);
            this.Controls.Add(this.numPurachase);
            this.Controls.Add(this.tbxName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPurachase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbxName;
        private NumericUpDown numPurachase;
        private RadioButton tax_exempt;
        private RadioButton state_sales;
        private RadioButton federal;
        private RadioButton special;
        private Button btnSubmit;
    }
}