using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mock_tes_for_speed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_ModuleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveData();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            if (this.Validate())
            {
                try
                {
                this.tb_ModuleBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.universityDataSet);
                MessageBox.Show("Saved");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
            // TODO: This line of code loads data into the 'universityDataSet.tb_ModuleType' table. You can move, or remove it, as needed.
            this.tb_ModuleTypeTableAdapter.Fill(this.universityDataSet.tb_ModuleType);
            // TODO: This line of code loads data into the 'universityDataSet.tb_Module' table. You can move, or remove it, as needed.
            this.tb_ModuleTableAdapter.Fill(this.universityDataSet.tb_Module);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tb_ModuleBindingSource.MoveFirst();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tb_ModuleBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tb_ModuleBindingSource.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tb_ModuleBindingSource.MoveLast();
        }

        private void EnableDisableButtons()
        {
            if(tb_ModuleBindingSource.Position == 0)
            {
                btnFirst.Enabled = false;
                btnPrevious.Enabled = false;
            }
            else
            {
                btnFirst.Enabled = true;
                btnPrevious.Enabled = true;
            }
            if(tb_ModuleBindingSource.Position == tb_ModuleBindingSource.Count - 1)
            {
                btnLast.Enabled = false;
                btnNext.Enabled = false;
            }
            else
            {
                btnLast.Enabled = true;
                btnNext.Enabled = true;
            }
        }

        private void tb_ModuleBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            EnableDisableButtons();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tb_ModuleBindingSource.Count == 0)
            {
                MessageBox.Show("Nothing to delete");
            }
            else
            {
                if (MessageBox.Show("Are you sure", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tb_ModuleBindingSource.RemoveCurrent();
                    MessageBox.Show("Deleted");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var module_type = ((DataRowView)cbxNewModuleType.SelectedItem).Row;
            universityDataSet.tb_Module.Addtb_ModuleRow(tbxNewModuleCode.Text, tbxNewModuleName.Text, Convert.ToInt32(tbxNewModuleYear.Text), (UniversityDataSet.tb_ModuleTypeRow)module_type);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tb_ModuleBindingSource.Filter = $"ModuleName LIKE '{textBox1.Text}%'";
        }

        private void Form1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Validate())
            {
                this.tb_ModuleBindingSource.EndEdit();
                if (universityDataSet.HasChanges())
                {
                    if (MessageBox.Show("You have changes. Do you want to save them?", "save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SaveData();
                    }
                }
            }
        }
        private bool IsNumeric(string text)
        {
            return double.TryParse(text, out _);
        }

        private void tbxNewModuleCode_Validating(object sender, CancelEventArgs e)
        {
            foreach(var module in tbxNewModuleCode.Text)
            {
                if (IsNumeric(Convert.ToString(module)))
                {
                    MessageBox.Show("You Can not Enter numbers");
                    e.Cancel = true;
                    return;
                }
            }
        }
    }
}
