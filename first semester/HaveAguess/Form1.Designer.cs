namespace HaveAguess
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
            this.numguess = new System.Windows.Forms.NumericUpDown();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numguess)).BeginInit();
            this.SuspendLayout();
            // 
            // numguess
            // 
            this.numguess.Location = new System.Drawing.Point(319, 157);
            this.numguess.Name = "numguess";
            this.numguess.Size = new System.Drawing.Size(120, 23);
            this.numguess.TabIndex = 0;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(319, 215);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(120, 42);
            this.btnsubmit.TabIndex = 1;
            this.btnsubmit.Text = "Submit a guess";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(319, 289);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(120, 42);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "Close the application";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.numguess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numguess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NumericUpDown numguess;
        private Button btnsubmit;
        private Button btnclose;
    }
}