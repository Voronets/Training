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

              //  int rowIndex;
              //  rowIndex = phoneBookDataSet.PersonInfo.Rows.IndexOf(phoneRow);

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
            PhoneBookDataSet.PersonInfoRow phoneRow;
            phoneRow = phoneBookDataSet.PersonInfo.FindByPersonID(Int32.Parse(textBoxID.Text));

            int rowIndex;
            rowIndex = phoneBookDataSet.PersonInfo.Rows.IndexOf(phoneRow);

            int lastRowIndex;
            lastRowIndex = phoneBookDataSet.PersonInfo.Rows.Count - 1;

            if (rowIndex > 0)
             {
                rowIndex--;
                buttonPrevRecord.Enabled = true;
            }
             
            if (rowIndex == 0) 
                buttonPrevRecord.Enabled = false;

            if (rowIndex == lastRowIndex)
                buttonNextRecord.Enabled = false;
            else
                buttonNextRecord.Enabled = true;

            phoneRow = phoneBookDataSet.PersonInfo[rowIndex];

            textBoxID.Text = phoneRow.PersonID.ToString();
            textBoxFirstName.Text = phoneRow.FirstName;
            comboBoxMidName.Text = phoneRow.MiddleName;
            textBoxLastName.Text = phoneRow.LastName;
            textBoxEmail.Text = phoneRow.EMail;
            textBoxPhone.Text = phoneRow.PhoneN;
            textBoxComments.Text = phoneRow.Comments;

        }

        private void buttonNextRecord_Click(object sender, EventArgs e)
        {
            PhoneBookDataSet.PersonInfoRow phoneRow;
            phoneRow = phoneBookDataSet.PersonInfo.FindByPersonID(Int32.Parse(textBoxID.Text));

            int rowIndex;
            rowIndex = phoneBookDataSet.PersonInfo.Rows.IndexOf(phoneRow);

            int lastRowIndex;
            lastRowIndex = phoneBookDataSet.PersonInfo.Rows.Count - 1;

            if (rowIndex < lastRowIndex)
            {
                rowIndex++;
                buttonNextRecord.Enabled = true;
            }

            if (rowIndex == lastRowIndex)
                buttonNextRecord.Enabled = false;

            if (rowIndex == 0)
                buttonPrevRecord.Enabled = false;
            else
                buttonPrevRecord.Enabled = true;

            phoneRow = phoneBookDataSet.PersonInfo[rowIndex];

            textBoxID.Text = phoneRow.PersonID.ToString();
            textBoxFirstName.Text = phoneRow.FirstName;
            comboBoxMidName.Text = phoneRow.MiddleName;
            textBoxLastName.Text = phoneRow.LastName;
            textBoxEmail.Text = phoneRow.EMail;
            textBoxPhone.Text = phoneRow.PhoneN;
            textBoxComments.Text = phoneRow.Comments;
        }
        
        private void buttonDetailsCancel_Click(object sender, EventArgs e)
        { 
             this.Close();            
        }

        private void FormDetails_FormClosing(object sender, FormClosingEventArgs e)
        {          
        }  
    }
}
