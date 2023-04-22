namespace practice_classes
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
            this.txthome = new System.Windows.Forms.TextBox();
            this.txtaway = new System.Windows.Forms.TextBox();
            this.numscorehome = new System.Windows.Forms.NumericUpDown();
            this.numscoreaway = new System.Windows.Forms.NumericUpDown();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblGuest = new System.Windows.Forms.Label();
            this.blbHomeScore = new System.Windows.Forms.Label();
            this.lblGuestScore = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numscorehome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numscoreaway)).BeginInit();
            this.SuspendLayout();
            // 
            // txthome
            // 
            this.txthome.Location = new System.Drawing.Point(119, 6);
            this.txthome.Name = "txthome";
            this.txthome.Size = new System.Drawing.Size(100, 23);
            this.txthome.TabIndex = 0;
            // 
            // txtaway
            // 
            this.txtaway.Location = new System.Drawing.Point(119, 72);
            this.txtaway.Name = "txtaway";
            this.txtaway.Size = new System.Drawing.Size(100, 23);
            this.txtaway.TabIndex = 1;
            // 
            // numscorehome
            // 
            this.numscorehome.Location = new System.Drawing.Point(436, 9);
            this.numscorehome.Name = "numscorehome";
            this.numscorehome.Size = new System.Drawing.Size(120, 23);
            this.numscorehome.TabIndex = 2;
            // 
            // numscoreaway
            // 
            this.numscoreaway.Location = new System.Drawing.Point(436, 78);
            this.numscoreaway.Name = "numscoreaway";
            this.numscoreaway.Size = new System.Drawing.Size(120, 23);
            this.numscoreaway.TabIndex = 3;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Location = new System.Drawing.Point(12, 9);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(70, 15);
            this.lblHome.TabIndex = 4;
            this.lblHome.Text = "Home team";
            // 
            // lblGuest
            // 
            this.lblGuest.AutoSize = true;
            this.lblGuest.Location = new System.Drawing.Point(16, 72);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Size = new System.Drawing.Size(66, 15);
            this.lblGuest.TabIndex = 5;
            this.lblGuest.Text = "Away team";
            // 
            // blbHomeScore
            // 
            this.blbHomeScore.AutoSize = true;
            this.blbHomeScore.Location = new System.Drawing.Point(286, 14);
            this.blbHomeScore.Name = "blbHomeScore";
            this.blbHomeScore.Size = new System.Drawing.Size(85, 15);
            this.blbHomeScore.TabIndex = 6;
            this.blbHomeScore.Text = "Enter the scroe";
            // 
            // lblGuestScore
            // 
            this.lblGuestScore.AutoSize = true;
            this.lblGuestScore.Location = new System.Drawing.Point(286, 80);
            this.lblGuestScore.Name = "lblGuestScore";
            this.lblGuestScore.Size = new System.Drawing.Size(85, 15);
            this.lblGuestScore.TabIndex = 7;
            this.lblGuestScore.Text = "Enter the score";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 47);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 205);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblGuestScore);
            this.Controls.Add(this.blbHomeScore);
            this.Controls.Add(this.lblGuest);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.numscoreaway);
            this.Controls.Add(this.numscorehome);
            this.Controls.Add(this.txtaway);
            this.Controls.Add(this.txthome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numscorehome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numscoreaway)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txthome;
        private TextBox txtaway;
        private NumericUpDown numscorehome;
        private NumericUpDown numscoreaway;
        private Label lblHome;
        private Label lblGuest;
        private Label blbHomeScore;
        private Label lblGuestScore;
        private Button button1;
        private Button button2;
    }
}