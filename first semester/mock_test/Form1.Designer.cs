namespace mock_test
{
    partial class Form1
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
            System.Windows.Forms.Label moduleCodeLabel;
            System.Windows.Forms.Label moduleNameLabel;
            System.Windows.Forms.Label moduleYearLabel;
            System.Windows.Forms.Label moduleTypeLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.universityDataSet = new mock_test.UniversityDataSet();
            this.tb_ModuleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ModuleTableAdapter = new mock_test.UniversityDataSetTableAdapters.tb_ModuleTableAdapter();
            this.tableAdapterManager = new mock_test.UniversityDataSetTableAdapters.TableAdapterManager();
            this.tb_ModuleTypeTableAdapter = new mock_test.UniversityDataSetTableAdapters.tb_ModuleTypeTableAdapter();
            this.tb_ModuleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_ModuleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.moduleCodeTextBox = new System.Windows.Forms.TextBox();
            this.moduleNameTextBox = new System.Windows.Forms.TextBox();
            this.moduleYearTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbModuleTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbNewModuleType = new System.Windows.Forms.ComboBox();
            this.tbModuleTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbxNewModuleCode = new System.Windows.Forms.TextBox();
            this.tbxNewModuleName = new System.Windows.Forms.TextBox();
            this.tbxNewModuleYear = new System.Windows.Forms.TextBox();
            this.tbxFilter = new System.Windows.Forms.TextBox();
            moduleCodeLabel = new System.Windows.Forms.Label();
            moduleNameLabel = new System.Windows.Forms.Label();
            moduleYearLabel = new System.Windows.Forms.Label();
            moduleTypeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ModuleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ModuleBindingNavigator)).BeginInit();
            this.tb_ModuleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbModuleTypeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbModuleTypeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // moduleCodeLabel
            // 
            moduleCodeLabel.AutoSize = true;
            moduleCodeLabel.Location = new System.Drawing.Point(173, 46);
            moduleCodeLabel.Name = "moduleCodeLabel";
            moduleCodeLabel.Size = new System.Drawing.Size(73, 13);
            moduleCodeLabel.TabIndex = 3;
            moduleCodeLabel.Text = "Module Code:";
            // 
            // moduleNameLabel
            // 
            moduleNameLabel.AutoSize = true;
            moduleNameLabel.Location = new System.Drawing.Point(173, 92);
            moduleNameLabel.Name = "moduleNameLabel";
            moduleNameLabel.Size = new System.Drawing.Size(76, 13);
            moduleNameLabel.TabIndex = 5;
            moduleNameLabel.Text = "Module Name:";
            // 
            // moduleYearLabel
            // 
            moduleYearLabel.AutoSize = true;
            moduleYearLabel.Location = new System.Drawing.Point(173, 147);
            moduleYearLabel.Name = "moduleYearLabel";
            moduleYearLabel.Size = new System.Drawing.Size(70, 13);
            moduleYearLabel.TabIndex = 7;
            moduleYearLabel.Text = "Module Year:";
            // 
            // moduleTypeLabel
            // 
            moduleTypeLabel.AutoSize = true;
            moduleTypeLabel.Location = new System.Drawing.Point(173, 204);
            moduleTypeLabel.Name = "moduleTypeLabel";
            moduleTypeLabel.Size = new System.Drawing.Size(72, 13);
            moduleTypeLabel.TabIndex = 9;
            moduleTypeLabel.Text = "Module Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(38, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 13);
            label1.TabIndex = 13;
            label1.Text = "Module Code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(38, 82);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 13);
            label2.TabIndex = 15;
            label2.Text = "Module Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(38, 137);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 13);
            label3.TabIndex = 17;
            label3.Text = "Module Year:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(38, 194);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 13);
            label4.TabIndex = 19;
            label4.Text = "Module Type:";
            // 
            // universityDataSet
            // 
            this.universityDataSet.DataSetName = "UniversityDataSet";
            this.universityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_ModuleBindingSource
            // 
            this.tb_ModuleBindingSource.DataMember = "tb_Module";
            this.tb_ModuleBindingSource.DataSource = this.universityDataSet;
            this.tb_ModuleBindingSource.CurrentChanged += new System.EventHandler(this.tb_ModuleBindingSource_CurrentChanged);
            // 
            // tb_ModuleTableAdapter
            // 
            this.tb_ModuleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_ModuleTableAdapter = this.tb_ModuleTableAdapter;
            this.tableAdapterManager.tb_ModuleTypeTableAdapter = this.tb_ModuleTypeTableAdapter;
            this.tableAdapterManager.UpdateOrder = mock_test.UniversityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_ModuleTypeTableAdapter
            // 
            this.tb_ModuleTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tb_ModuleBindingNavigator
            // 
            this.tb_ModuleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_ModuleBindingNavigator.BindingSource = this.tb_ModuleBindingSource;
            this.tb_ModuleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_ModuleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_ModuleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tb_ModuleBindingNavigatorSaveItem});
            this.tb_ModuleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_ModuleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_ModuleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_ModuleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_ModuleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_ModuleBindingNavigator.Name = "tb_ModuleBindingNavigator";
            this.tb_ModuleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_ModuleBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tb_ModuleBindingNavigator.TabIndex = 0;
            this.tb_ModuleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_ModuleBindingNavigatorSaveItem
            // 
            this.tb_ModuleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_ModuleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_ModuleBindingNavigatorSaveItem.Image")));
            this.tb_ModuleBindingNavigatorSaveItem.Name = "tb_ModuleBindingNavigatorSaveItem";
            this.tb_ModuleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tb_ModuleBindingNavigatorSaveItem.Text = "Save Data";
            this.tb_ModuleBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_ModuleBindingNavigatorSaveItem_Click);
            // 
            // moduleCodeTextBox
            // 
            this.moduleCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ModuleBindingSource, "ModuleCode", true));
            this.moduleCodeTextBox.Location = new System.Drawing.Point(255, 43);
            this.moduleCodeTextBox.Name = "moduleCodeTextBox";
            this.moduleCodeTextBox.Size = new System.Drawing.Size(121, 20);
            this.moduleCodeTextBox.TabIndex = 4;
            this.moduleCodeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.moduleCodeTextBox_Validating);
            // 
            // moduleNameTextBox
            // 
            this.moduleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ModuleBindingSource, "ModuleName", true));
            this.moduleNameTextBox.Location = new System.Drawing.Point(255, 89);
            this.moduleNameTextBox.Name = "moduleNameTextBox";
            this.moduleNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.moduleNameTextBox.TabIndex = 6;
            // 
            // moduleYearTextBox
            // 
            this.moduleYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ModuleBindingSource, "ModuleYear", true));
            this.moduleYearTextBox.Location = new System.Drawing.Point(255, 144);
            this.moduleYearTextBox.Name = "moduleYearTextBox";
            this.moduleYearTextBox.Size = new System.Drawing.Size(121, 20);
            this.moduleYearTextBox.TabIndex = 8;
            this.moduleYearTextBox.TextChanged += new System.EventHandler(this.moduleYearTextBox_TextChanged);
            this.moduleYearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.moduleYearTextBox_KeyPress);
            this.moduleYearTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.moduleYearTextBox_Validating);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.tb_ModuleBindingSource;
            this.listBox1.DisplayMember = "ModuleName";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(155, 173);
            this.listBox1.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tb_ModuleBindingSource, "ModuleType", true));
            this.comboBox1.DataSource = this.tbModuleTypeBindingSource;
            this.comboBox1.DisplayMember = "ModuleTypeName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(255, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "Id";
            // 
            // tbModuleTypeBindingSource
            // 
            this.tbModuleTypeBindingSource.DataMember = "tb_ModuleType";
            this.tbModuleTypeBindingSource.DataSource = this.universityDataSet;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(12, 248);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 13;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(102, 248);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 14;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(215, 248);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(301, 248);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 16;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(53, 306);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(266, 306);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cmbNewModuleType);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.tbxNewModuleCode);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.tbxNewModuleName);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.tbxNewModuleYear);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Location = new System.Drawing.Point(487, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 286);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "add";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(88, 245);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbNewModuleType
            // 
            this.cmbNewModuleType.DataSource = this.tbModuleTypeBindingSource1;
            this.cmbNewModuleType.DisplayMember = "ModuleTypeName";
            this.cmbNewModuleType.FormattingEnabled = true;
            this.cmbNewModuleType.Location = new System.Drawing.Point(120, 194);
            this.cmbNewModuleType.Name = "cmbNewModuleType";
            this.cmbNewModuleType.Size = new System.Drawing.Size(121, 21);
            this.cmbNewModuleType.TabIndex = 20;
            // 
            // tbModuleTypeBindingSource1
            // 
            this.tbModuleTypeBindingSource1.DataMember = "tb_ModuleType";
            this.tbModuleTypeBindingSource1.DataSource = this.universityDataSet;
            // 
            // tbxNewModuleCode
            // 
            this.tbxNewModuleCode.Location = new System.Drawing.Point(120, 33);
            this.tbxNewModuleCode.Name = "tbxNewModuleCode";
            this.tbxNewModuleCode.Size = new System.Drawing.Size(121, 20);
            this.tbxNewModuleCode.TabIndex = 14;
            // 
            // tbxNewModuleName
            // 
            this.tbxNewModuleName.Location = new System.Drawing.Point(120, 79);
            this.tbxNewModuleName.Name = "tbxNewModuleName";
            this.tbxNewModuleName.Size = new System.Drawing.Size(121, 20);
            this.tbxNewModuleName.TabIndex = 16;
            // 
            // tbxNewModuleYear
            // 
            this.tbxNewModuleYear.Location = new System.Drawing.Point(120, 134);
            this.tbxNewModuleYear.Name = "tbxNewModuleYear";
            this.tbxNewModuleYear.Size = new System.Drawing.Size(121, 20);
            this.tbxNewModuleYear.TabIndex = 18;
            // 
            // tbxFilter
            // 
            this.tbxFilter.Location = new System.Drawing.Point(12, 222);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(155, 20);
            this.tbxFilter.TabIndex = 20;
            this.tbxFilter.TextChanged += new System.EventHandler(this.tbxFilter_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(moduleCodeLabel);
            this.Controls.Add(this.moduleCodeTextBox);
            this.Controls.Add(moduleNameLabel);
            this.Controls.Add(this.moduleNameTextBox);
            this.Controls.Add(moduleYearLabel);
            this.Controls.Add(this.moduleYearTextBox);
            this.Controls.Add(moduleTypeLabel);
            this.Controls.Add(this.tb_ModuleBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ModuleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ModuleBindingNavigator)).EndInit();
            this.tb_ModuleBindingNavigator.ResumeLayout(false);
            this.tb_ModuleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbModuleTypeBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbModuleTypeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UniversityDataSet universityDataSet;
        private System.Windows.Forms.BindingSource tb_ModuleBindingSource;
        private UniversityDataSetTableAdapters.tb_ModuleTableAdapter tb_ModuleTableAdapter;
        private UniversityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_ModuleBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tb_ModuleBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox moduleCodeTextBox;
        private System.Windows.Forms.TextBox moduleNameTextBox;
        private System.Windows.Forms.TextBox moduleYearTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private UniversityDataSetTableAdapters.tb_ModuleTypeTableAdapter tb_ModuleTypeTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tbModuleTypeBindingSource;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbNewModuleType;
        private System.Windows.Forms.BindingSource tbModuleTypeBindingSource1;
        private System.Windows.Forms.TextBox tbxNewModuleCode;
        private System.Windows.Forms.TextBox tbxNewModuleName;
        private System.Windows.Forms.TextBox tbxNewModuleYear;
        private System.Windows.Forms.TextBox tbxFilter;
    }
}

