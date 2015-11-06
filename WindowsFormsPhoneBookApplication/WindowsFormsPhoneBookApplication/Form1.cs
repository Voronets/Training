using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsPhoneBookApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneBookDataSet.PersonInfo' table. You can move, or remove it, as needed.
            this.personInfoTableAdapter.Fill(this.phoneBookDataSet.PersonInfo);
            // TODO: This line of code loads data into the 'phoneBookDataSet.Phones' table. You can move, or remove it, as needed.
            this.phonesTableAdapter.Fill(this.phoneBookDataSet.Phones);

        }

    /*    public void PerformRefresh()
        {
            this.dataGridPhoneBook.Refresh();
            this.dataGridPhoneBook.Update();
        }*/

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.personInfoTableAdapter.FillBy(this.phoneBookDataSet.PersonInfo);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridPhoneBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormDetails formDet = new FormDetails();
          //  formDet.textBoxID.Text = dataGridPhoneBook.CurrentRow.Cells[0].Value.ToString();
          //  this.personInfoTableAdapter.GetData();

            PhoneBookDataSet.PersonInfoRow phoneRow;
            phoneRow = phoneBookDataSet.PersonInfo.FindByPersonID(Int32.Parse(dataGridPhoneBook.CurrentRow.Cells[0].Value.ToString()));

            formDet.textBoxID.Text = phoneRow.PersonID.ToString();
            formDet.textBoxFirstName.Text = phoneRow.FirstName;
            formDet.comboBoxMidName.Text = phoneRow.MiddleName;
            formDet.textBoxLastName.Text = phoneRow.LastName;
            formDet.textBoxEmail.Text = phoneRow.EMail;
            formDet.textBoxPhone.Text = phoneRow.PhoneN;
            formDet.textBoxComments.Text = phoneRow.Comments;
                        
            formDet.ShowDialog();          
        }

        private void addNewContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  FormDetails formDet = new FormDetails(this);
            FormDetails formDet = new FormDetails();
            formDet.Text = "Add new contact";
            formDet.buttonSave.Text = "Save record";
            formDet.textBoxID.Enabled = true;
            formDet.buttonDelete.Visible = false;
            formDet.buttonNextRecord.Visible = false;
            formDet.buttonPrevRecord.Visible = false;
            formDet.checkBoxEditDetails.Checked = true;
            formDet.checkBoxEditDetails.Visible = false;
            formDet.ShowDialog();           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
