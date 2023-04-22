namespace LeapYear
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
            this.numyear = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numyear)).BeginInit();
            this.SuspendLayout();
            // 
            // numyear
            // 
            this.numyear.Location = new System.Drawing.Point(152, 79);
            this.numyear.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numyear.Name = "numyear";
            this.numyear.Size = new System.Drawing.Size(120, 23);
            this.numyear.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the year in order to find, whether this yera is leap or not";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(170, 121);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 2;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 210);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numyear);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numyear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numyear;
        private Label label1;
        private Button btnsubmit;
    }
}