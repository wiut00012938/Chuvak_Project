namespace seminar2_exchanger
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
            this.txtsum = new System.Windows.Forms.TextBox();
            this.txtdollar = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnround1 = new System.Windows.Forms.Button();
            this.btnround2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsum
            // 
            this.txtsum.Location = new System.Drawing.Point(26, 122);
            this.txtsum.Name = "txtsum";
            this.txtsum.Size = new System.Drawing.Size(146, 23);
            this.txtsum.TabIndex = 0;
            // 
            // txtdollar
            // 
            this.txtdollar.Location = new System.Drawing.Point(609, 122);
            this.txtdollar.Name = "txtdollar";
            this.txtdollar.Size = new System.Drawing.Size(146, 23);
            this.txtdollar.TabIndex = 1;
            this.txtdollar.TextChanged += new System.EventHandler(this.txtdollar_TextChanged);
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(350, 102);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(123, 61);
            this.btncalculate.TabIndex = 2;
            this.btncalculate.Text = "calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnround1
            // 
            this.btnround1.Location = new System.Drawing.Point(175, 241);
            this.btnround1.Name = "btnround1";
            this.btnround1.Size = new System.Drawing.Size(123, 61);
            this.btnround1.TabIndex = 3;
            this.btnround1.Text = "round to the nearest number";
            this.btnround1.UseVisualStyleBackColor = true;
            this.btnround1.Click += new System.EventHandler(this.btnround1_Click);
            // 
            // btnround2
            // 
            this.btnround2.Location = new System.Drawing.Point(487, 241);
            this.btnround2.Name = "btnround2";
            this.btnround2.Size = new System.Drawing.Size(123, 61);
            this.btnround2.TabIndex = 4;
            this.btnround2.Text = "round to the nearest 100";
            this.btnround2.UseVisualStyleBackColor = true;
            this.btnround2.Click += new System.EventHandler(this.btnround2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter the amount in sums";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "The amount of us dollars";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnround2);
            this.Controls.Add(this.btnround1);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtdollar);
            this.Controls.Add(this.txtsum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtsum;
        private TextBox txtdollar;
        private Button btncalculate;
        private Button btnround1;
        private Button btnround2;
        private Label label1;
        private Label label2;
    }
}