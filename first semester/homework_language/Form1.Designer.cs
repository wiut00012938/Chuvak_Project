namespace homework_language
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
            this.txtenglish = new System.Windows.Forms.TextBox();
            this.txtalbonian = new System.Windows.Forms.TextBox();
            this.btntranslate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtenglish
            // 
            this.txtenglish.Location = new System.Drawing.Point(12, 190);
            this.txtenglish.Multiline = true;
            this.txtenglish.Name = "txtenglish";
            this.txtenglish.Size = new System.Drawing.Size(215, 32);
            this.txtenglish.TabIndex = 0;
            this.txtenglish.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtalbonian
            // 
            this.txtalbonian.Location = new System.Drawing.Point(551, 190);
            this.txtalbonian.Multiline = true;
            this.txtalbonian.Name = "txtalbonian";
            this.txtalbonian.Size = new System.Drawing.Size(215, 28);
            this.txtalbonian.TabIndex = 1;
            // 
            // btntranslate
            // 
            this.btntranslate.Location = new System.Drawing.Point(314, 190);
            this.btntranslate.Name = "btntranslate";
            this.btntranslate.Size = new System.Drawing.Size(133, 56);
            this.btntranslate.TabIndex = 2;
            this.btntranslate.Text = "translate";
            this.btntranslate.UseVisualStyleBackColor = true;
            this.btntranslate.Click += new System.EventHandler(this.btntranslate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.btntranslate);
            this.Controls.Add(this.txtalbonian);
            this.Controls.Add(this.txtenglish);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtenglish;
        private TextBox txtalbonian;
        private Button btntranslate;
    }
}