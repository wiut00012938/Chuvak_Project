using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //function for integrated button for save
        private void tbTeacherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //for following DRY rule creating separated function SaveData()
            SaveData();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //filling databaase when loading inside try catch for validation and handling errors and making crash of program less rude
            try
            {
            // TODO: This line of code loads data into the 'dbDataSet.tbCountry' table. You can move, or remove it, as needed.
            this.tbCountryTableAdapter.Fill(this.dbDataSet.tbCountry);
            // TODO: This line of code loads data into the 'dbDataSet.tbTeacher' table. You can move, or remove it, as needed.
            this.tbTeacherTableAdapter.Fill(this.dbDataSet.tbTeacher);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //button that was created for saving
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        //SaveData() function that contains actual intstruction for saving edits
        private void SaveData()
        {
            if (this.Validate())
            {
                try
                {
                    this.tbTeacherBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dbDataSet);
                    MessageBox.Show("Saved");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            }
        }
        //instuction for event closing of program that will check for edits and ask whetether the user wants to save the changes before closing the form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Validate())
            {
                this.tbTeacherBindingSource.EndEdit();
                if (dbDataSet.HasChanges())
                {
                    if (MessageBox.Show("Save?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SaveData();
                    }
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void tbTeacherDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            tbTeacherBindingSource.MoveFirst();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            tbTeacherBindingSource.MovePrevious();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            tbTeacherBindingSource.MoveNext();
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            tbTeacherBindingSource.MoveLast();
        }

        private void EnableDisableButton()
        {
            if (tbTeacherBindingSource.Position == 0)
            {
                btnfirst.Enabled = false;
                btnprevious.Enabled = false;
            }
            else
            {
                btnfirst.Enabled = true;
                btnprevious.Enabled= true;
            }
            if (tbTeacherBindingSource.Position == tbTeacherBindingSource.Count - 1)
            {
                btnlast.Enabled = false;
                btnnext.Enabled = false;
            }
            else
            {
                btnlast.Enabled = true;
                btnnext.Enabled = true;
            }
        }

        private void tbTeacherBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            EnableDisableButton();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (tbTeacherBindingSource.Count == 0)
            {
                MessageBox.Show("No things to delete");
            }
            else
            {
                var userResponse = MessageBox.Show("Sure?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (userResponse == DialogResult.Yes)
                {
                    tbTeacherBindingSource.RemoveCurrent();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get dataset row with selected country
            var selectedCountry = ((DataRowView)comboNewCountry.SelectedItem).Row;
            //add to in-memory dataset
            dbDataSet.tbTeacher.AddtbTeacherRow(tbxNewFirstName.Text,
                            tbxNewLastName.Text,
                            tbxNewDob.Value,
                            tbxNewPhoneNumber.Text,
                            (int)nudNewGradeLevel.Value,
                            checkNewActive.Checked,
                            (dbDataSet.tbCountryRow)selectedCountry);

        }

        private void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            tbTeacherBindingSource.Filter = $"LastName LIKE '{tbxFilter.Text}%'";
        }

        private void firstNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (firstNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Can not be empty");
                e.Cancel = true;
            }
        }
    }
}
