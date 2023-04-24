namespace SuperDuperMarket
{
    partial class AddPurpchaseOrder
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
            this.components = new System.ComponentModel.Container();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products_to_order = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.priorityDataGridViewTextBoxColumn,
            this.remainingDataGridViewTextBoxColumn,
            this.purchaseLevelDataGridViewTextBoxColumn,
            this.toOrderDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.products_to_order});
            this.dgv.DataSource = this.toOrderBindingSource;
            this.dgv.Location = new System.Drawing.Point(12, 162);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(743, 349);
            this.dgv.TabIndex = 0;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            this.priorityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remainingDataGridViewTextBoxColumn
            // 
            this.remainingDataGridViewTextBoxColumn.DataPropertyName = "Remaining";
            this.remainingDataGridViewTextBoxColumn.HeaderText = "Remaining";
            this.remainingDataGridViewTextBoxColumn.Name = "remainingDataGridViewTextBoxColumn";
            this.remainingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchaseLevelDataGridViewTextBoxColumn
            // 
            this.purchaseLevelDataGridViewTextBoxColumn.DataPropertyName = "PurchaseLevel";
            this.purchaseLevelDataGridViewTextBoxColumn.HeaderText = "PurchaseLevel";
            this.purchaseLevelDataGridViewTextBoxColumn.Name = "purchaseLevelDataGridViewTextBoxColumn";
            this.purchaseLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toOrderDataGridViewTextBoxColumn
            // 
            this.toOrderDataGridViewTextBoxColumn.DataPropertyName = "To_Order";
            this.toOrderDataGridViewTextBoxColumn.HeaderText = "To_Order";
            this.toOrderDataGridViewTextBoxColumn.Name = "toOrderDataGridViewTextBoxColumn";
            this.toOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // products_to_order
            // 
            this.products_to_order.HeaderText = "Products to Order";
            this.products_to_order.Name = "products_to_order";
            // 
            // toOrderBindingSource
            // 
            this.toOrderBindingSource.DataSource = typeof(SuperDuperMarket.DAL.ToOrder);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Location = new System.Drawing.Point(227, 527);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(266, 83);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Create a new purchase order";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(140, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tick at maximum of 5 products to order";
            // 
            // AddPurpchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 622);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgv);
            this.Name = "AddPurpchaseOrder";
            this.Text = "AddPurpchaseOrder";
            this.Load += new System.EventHandler(this.AddPurpchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toOrderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource toOrderBindingSource;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn products_to_order;
    }
}