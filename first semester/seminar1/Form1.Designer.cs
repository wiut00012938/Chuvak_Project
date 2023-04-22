namespace seminar1
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
            this.btnshow1 = new System.Windows.Forms.Button();
            this.btnshow2 = new System.Windows.Forms.Button();
            this.lblshow = new System.Windows.Forms.Label();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnshow1
            // 
            this.btnshow1.Location = new System.Drawing.Point(597, 321);
            this.btnshow1.Name = "btnshow1";
            this.btnshow1.Size = new System.Drawing.Size(107, 42);
            this.btnshow1.TabIndex = 0;
            this.btnshow1.Text = "Send a Hello";
            this.btnshow1.UseVisualStyleBackColor = true;
            this.btnshow1.Click += new System.EventHandler(this.btnshow1_Click);
            // 
            // btnshow2
            // 
            this.btnshow2.Location = new System.Drawing.Point(119, 321);
            this.btnshow2.Name = "btnshow2";
            this.btnshow2.Size = new System.Drawing.Size(107, 42);
            this.btnshow2.TabIndex = 1;
            this.btnshow2.Text = "Close the application";
            this.btnshow2.UseVisualStyleBackColor = true;
            this.btnshow2.Click += new System.EventHandler(this.btnshow2_Click);
            // 
            // lblshow
            // 
            this.lblshow.AutoSize = true;
            this.lblshow.Location = new System.Drawing.Point(261, 203);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(315, 15);
            this.lblshow.TabIndex = 2;
            this.lblshow.Text = "Enter the name of the person, whom you want to say hello";
            this.lblshow.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(324, 241);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(165, 23);
            this.txtbox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.lblshow);
            this.Controls.Add(this.btnshow2);
            this.Controls.Add(this.btnshow1);
            this.Name = "Form1";
            this.Text = "Hello world";
            this.AutoSizeChanged += new System.EventHandler(this.Form1_AutoSizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnshow1;
        private Button btnshow2;
        private Label lblshow;
        private TextBox txtbox;
    }
}