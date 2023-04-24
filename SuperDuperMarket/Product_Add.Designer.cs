namespace SuperDuperMarket
{
    partial class Product_Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.nudRemaining = new System.Windows.Forms.NumericUpDown();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.nudPriority = new System.Windows.Forms.NumericUpDown();
            this.lblPurchaseLevel = new System.Windows.Forms.Label();
            this.nudPurchaseLevel = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemaining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchaseLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxName.Location = new System.Drawing.Point(276, 8);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(181, 26);
            this.tbxName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblName.Location = new System.Drawing.Point(12, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(157, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name of a product";
            // 
            // nudRemaining
            // 
            this.nudRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudRemaining.Location = new System.Drawing.Point(276, 65);
            this.nudRemaining.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nudRemaining.Name = "nudRemaining";
            this.nudRemaining.Size = new System.Drawing.Size(181, 29);
            this.nudRemaining.TabIndex = 2;
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRemaining.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRemaining.Location = new System.Drawing.Point(12, 65);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(170, 20);
            this.lblRemaining.TabIndex = 3;
            this.lblRemaining.Text = "Products Remaining";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPriority.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPriority.Location = new System.Drawing.Point(12, 121);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(182, 20);
            this.lblPriority.TabIndex = 5;
            this.lblPriority.Text = "Priority of the product";
            // 
            // nudPriority
            // 
            this.nudPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudPriority.Location = new System.Drawing.Point(276, 121);
            this.nudPriority.Name = "nudPriority";
            this.nudPriority.Size = new System.Drawing.Size(181, 29);
            this.nudPriority.TabIndex = 4;
            // 
            // lblPurchaseLevel
            // 
            this.lblPurchaseLevel.AutoSize = true;
            this.lblPurchaseLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPurchaseLevel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPurchaseLevel.Location = new System.Drawing.Point(12, 186);
            this.lblPurchaseLevel.Name = "lblPurchaseLevel";
            this.lblPurchaseLevel.Size = new System.Drawing.Size(243, 20);
            this.lblPurchaseLevel.TabIndex = 7;
            this.lblPurchaseLevel.Text = "Purchase level of the product";
            // 
            // nudPurchaseLevel
            // 
            this.nudPurchaseLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudPurchaseLevel.Location = new System.Drawing.Point(276, 181);
            this.nudPurchaseLevel.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudPurchaseLevel.Name = "nudPurchaseLevel";
            this.nudPurchaseLevel.Size = new System.Drawing.Size(181, 29);
            this.nudPurchaseLevel.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPrice.Location = new System.Drawing.Point(12, 247);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(151, 20);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price of a product";
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudPrice.Location = new System.Drawing.Point(276, 242);
            this.nudPrice.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(181, 29);
            this.nudPrice.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Location = new System.Drawing.Point(63, 334);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(119, 45);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.Location = new System.Drawing.Point(292, 334);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 45);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Product_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.lblPurchaseLevel);
            this.Controls.Add(this.nudPurchaseLevel);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.nudPriority);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.nudRemaining);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxName);
            this.Name = "Product_Add";
            this.Text = "Product_Add";
            ((System.ComponentModel.ISupportInitialize)(this.nudRemaining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchaseLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown nudRemaining;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.NumericUpDown nudPriority;
        private System.Windows.Forms.Label lblPurchaseLevel;
        private System.Windows.Forms.NumericUpDown nudPurchaseLevel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}