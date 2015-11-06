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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void personInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phoneBookDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneBookDataSet.PersonInfo' table. You can move, or remove it, as needed.
            this.personInfoTableAdapter.Fill(this.phoneBookDataSet.PersonInfo);

        }
    }
}
