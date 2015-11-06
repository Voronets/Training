using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPhoneBookApplication
{
    public partial class FormDetails : Form
    {
      //  Form1 _owner;

    /*    public FormDetails(Form1 owner)
        {
            _owner = owner;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDetails_FormClosing);
        }
        private void FormDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.PerformRefresh();
        }*/

        public FormDetails()
        {
            InitializeComponent();
        }

        private void FormDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneBookDataSet.PersonInfo' table. You can move, or remove it, as needed.
            this.personInfoTableAdapter.Fill(this.phoneBookDataSet.PersonInfo);            
            
        }
               
        private void checkBoxEditDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEditDetails.Checked == true)
            {
                textBoxFirstName.Enabled = true;
                comboBoxMidName.Enabled = true;
                textBoxLastName.Enabled = true;
                textBoxEmail.Enabled = true;
                textBoxPhone.Enabled = true;
                textBoxComments.Enabled = true;
                buttonSave.Enabled = true;
                buttonDelete.Enabled = true;
            }
            else
            {
                textBoxFirstName.Enabled = false;
                comboBoxMidName.Enabled = false;
                textBoxLastName.Enabled = false;
                textBoxEmail.Enabled = false;
                textBoxPhone.Enabled = false;
                textBoxComments.Enabled = false;
                buttonSave.Enabled = false;
                buttonDelete.Enabled = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personInfoBindingSource.EndEdit();

            if (Text == "Add new contact")
            {
                this.personInfoTableAdapter.Insert(Int32.Parse(textBoxID.Text), textBoxFirstName.Text, comboBoxMidName.Text,
                textBoxLastName.Text, textBoxEmail.Text, textBoxComments.Text, textBoxPhone.Text);
                buttonSave.Enabled = false;
            }
            else
            {
                PhoneBookDataSet.PersonInfoRow phoneRow;
                phoneRow = phoneBookDataSet.PersonInfo.FindByPersonID(Int32.Parse(textBoxID.Text));

                phoneRow.FirstName = textBoxFirstName.Text;
                phoneRow.MiddleName = comboBoxMidName.Text;
                phoneRow.LastName = textBoxLastName.Text;
                phoneRow.EMail = textBoxEmail.Text;
                phoneRow.PhoneN = textBoxPhone.Text;
                phoneRow.Comments = textBoxComments.Text;

                this.personInfoTableAdapter.Update(this.phoneBookDataSet.PersonInfo);
            }                    
       }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            PhoneBookDataSet.PersonInfoRow phoneRowOld;
            phoneRowOld = phoneBookDataSet.PersonInfo.FindByPersonID(Int32.Parse(textBoxID.Text));

            phoneRowOld.Delete();

            this.personInfoTableAdapter.Update(this.phoneBookDataSet.PersonInfo);
            buttonDelete.Enabled = false;
            buttonPrevRecord.Enabled = false;
            buttonNextRecord.Enabled = false;
            buttonSave.Enabled = false;

            textBoxID.Clear();
            textBoxFirstName.Clear();
            comboBoxMidName.Text = "";
            textBoxLastName.Clear();
            textBoxEmail.Clear();
            textBoxPhone.Clear();
            textBoxComments.Clear();

            labelRecDeleted.Visible = true;
            checkBoxEditDetails.Enabled = false;
                        
        }

        private void buttonPrevRecord_Click(object sender, EventArgs e)
        {

        }

        private void buttonNextRecord_Click(object sender, EventArgs e)
        {

        }
        
        private void buttonDetailsCancel_Click(object sender, EventArgs e)
        { 
            //Form1 gridForm = new Form1();
            
                //this.personInfoTableAdapter.Fill(this.phoneBookDataSet.PersonInfo);
     //       this.personInfoTableAdapter.Update(this.phoneBookDataSet.PersonInfo);
    //        gridForm.dataGridPhoneBook.DataSource = this.phoneBookDataSet.PersonInfo;
            //gridForm.dataGridPhoneBook.Update();
            
        //   gridForm.Refresh();
        //   gridForm.Update();
       //    gridForm.Invalidate();
        //    gridForm.UpdateGrid();
      //    Application.

            this.personInfoTableAdapter.Fill(this.phoneBookDataSet.PersonInfo);
            

            //this.personInfoTableAdapter.Fill(this.phoneBookDataSet.PersonInfo);

            /*this.personInfoBindingSource1.EndEdit();
            this.personInfoTableAdapter.Fill(this.phoneBookDataSet.PersonInfo);
            gridForm.dataGridPhoneBook.DataSource = this.phoneBookDataSet.PersonInfo;
            gridForm.Refresh();
            gridForm.Update();*/
            this.Close();            
        }  
    }
}
