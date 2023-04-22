namespace Cats
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
            this.sleeping = new System.Windows.Forms.RadioButton();
            this.playing = new System.Windows.Forms.RadioButton();
            this.lying = new System.Windows.Forms.RadioButton();
            this.short_haired = new System.Windows.Forms.RadioButton();
            this.long_haired = new System.Windows.Forms.RadioButton();
            this.young = new System.Windows.Forms.RadioButton();
            this.old = new System.Windows.Forms.RadioButton();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sleeping
            // 
            this.sleeping.AutoSize = true;
            this.sleeping.Location = new System.Drawing.Point(44, 22);
            this.sleeping.Name = "sleeping";
            this.sleeping.Size = new System.Drawing.Size(99, 19);
            this.sleeping.TabIndex = 0;
            this.sleeping.TabStop = true;
            this.sleeping.Text = "cat is sleeping";
            this.sleeping.UseVisualStyleBackColor = true;
            // 
            // playing
            // 
            this.playing.AutoSize = true;
            this.playing.Location = new System.Drawing.Point(44, 63);
            this.playing.Name = "playing";
            this.playing.Size = new System.Drawing.Size(94, 19);
            this.playing.TabIndex = 1;
            this.playing.TabStop = true;
            this.playing.Text = "cat is playing";
            this.playing.UseVisualStyleBackColor = true;
            // 
            // lying
            // 
            this.lying.AutoSize = true;
            this.lying.Location = new System.Drawing.Point(44, 113);
            this.lying.Name = "lying";
            this.lying.Size = new System.Drawing.Size(81, 19);
            this.lying.TabIndex = 2;
            this.lying.TabStop = true;
            this.lying.Text = "cat is lying";
            this.lying.UseVisualStyleBackColor = true;
            // 
            // short_haired
            // 
            this.short_haired.AutoSize = true;
            this.short_haired.Location = new System.Drawing.Point(37, 104);
            this.short_haired.Name = "short_haired";
            this.short_haired.Size = new System.Drawing.Size(120, 19);
            this.short_haired.TabIndex = 4;
            this.short_haired.TabStop = true;
            this.short_haired.Text = "cat is short-haired";
            this.short_haired.UseVisualStyleBackColor = true;
            // 
            // long_haired
            // 
            this.long_haired.AutoSize = true;
            this.long_haired.Location = new System.Drawing.Point(40, 22);
            this.long_haired.Name = "long_haired";
            this.long_haired.Size = new System.Drawing.Size(117, 19);
            this.long_haired.TabIndex = 3;
            this.long_haired.TabStop = true;
            this.long_haired.Text = "cat is long-haired";
            this.long_haired.UseVisualStyleBackColor = true;
            // 
            // young
            // 
            this.young.AutoSize = true;
            this.young.Location = new System.Drawing.Point(30, 104);
            this.young.Name = "young";
            this.young.Size = new System.Drawing.Size(135, 19);
            this.young.TabIndex = 6;
            this.young.TabStop = true;
            this.young.Text = "cat is below 6 month";
            this.young.UseVisualStyleBackColor = true;
            // 
            // old
            // 
            this.old.AutoSize = true;
            this.old.Location = new System.Drawing.Point(6, 22);
            this.old.Name = "old";
            this.old.Size = new System.Drawing.Size(178, 19);
            this.old.TabIndex = 5;
            this.old.TabStop = true;
            this.old.Text = "cat is more than 6 month old";
            this.old.UseVisualStyleBackColor = true;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(255, 229);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(119, 51);
            this.btnsubmit.TabIndex = 7;
            this.btnsubmit.Text = "submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sleeping);
            this.groupBox1.Controls.Add(this.playing);
            this.groupBox1.Controls.Add(this.lying);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 194);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "current activity of cat";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.long_haired);
            this.groupBox2.Controls.Add(this.short_haired);
            this.groupBox2.Location = new System.Drawing.Point(233, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 185);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "hair of cat";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.old);
            this.groupBox3.Controls.Add(this.young);
            this.groupBox3.Location = new System.Drawing.Point(457, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 185);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "age of cat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 305);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsubmit);
            this.Name = "Form1";
            this.Text = "cat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RadioButton sleeping;
        private RadioButton playing;
        private RadioButton lying;
        private RadioButton short_haired;
        private RadioButton long_haired;
        private RadioButton young;
        private RadioButton old;
        private Button btnsubmit;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}