namespace WindowsFormsPhoneBookApplication
{
    partial class Form3
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
            System.Windows.Forms.Label personIDLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label middleNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label eMailLabel;
            System.Windows.Forms.Label commentsLabel;
            System.Windows.Forms.Label phoneNLabel;
            this.phoneBookDataSet = new WindowsFormsPhoneBookApplication.PhoneBookDataSet();
            this.personInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personInfoTableAdapter = new WindowsFormsPhoneBookApplication.PhoneBookDataSetTableAdapters.PersonInfoTableAdapter();
            this.tableAdapterManager = new WindowsFormsPhoneBookApplication.PhoneBookDataSetTableAdapters.TableAdapterManager();
            this.personIDTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.phoneNTextBox = new System.Windows.Forms.TextBox();
            this.personInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            personIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            eMailLabel = new System.Windows.Forms.Label();
            commentsLabel = new System.Windows.Forms.Label();
            phoneNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // personIDLabel
            // 
            personIDLabel.AutoSize = true;
            personIDLabel.Location = new System.Drawing.Point(257, 62);
            personIDLabel.Name = "personIDLabel";
            personIDLabel.Size = new System.Drawing.Size(57, 13);
            personIDLabel.TabIndex = 0;
            personIDLabel.Text = "Person ID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(319, 107);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "First Name:";
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new System.Drawing.Point(362, 181);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(72, 13);
            middleNameLabel.TabIndex = 4;
            middleNameLabel.Text = "Middle Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(370, 264);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 6;
            lastNameLabel.Text = "Last Name:";
            // 
            // eMailLabel
            // 
            eMailLabel.AutoSize = true;
            eMailLabel.Location = new System.Drawing.Point(265, 289);
            eMailLabel.Name = "eMailLabel";
            eMailLabel.Size = new System.Drawing.Size(36, 13);
            eMailLabel.TabIndex = 8;
            eMailLabel.Text = "EMail:";
            // 
            // commentsLabel
            // 
            commentsLabel.AutoSize = true;
            commentsLabel.Location = new System.Drawing.Point(170, 334);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Size = new System.Drawing.Size(59, 13);
            commentsLabel.TabIndex = 10;
            commentsLabel.Text = "Comments:";
            // 
            // phoneNLabel
            // 
            phoneNLabel.AutoSize = true;
            phoneNLabel.Location = new System.Drawing.Point(76, 358);
            phoneNLabel.Name = "phoneNLabel";
            phoneNLabel.Size = new System.Drawing.Size(52, 13);
            phoneNLabel.TabIndex = 12;
            phoneNLabel.Text = "Phone N:";
            // 
            // phoneBookDataSet
            // 
            this.phoneBookDataSet.DataSetName = "PhoneBookDataSet";
            this.phoneBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personInfoBindingSource
            // 
            this.personInfoBindingSource.DataMember = "PersonInfo";
            this.personInfoBindingSource.DataSource = this.phoneBookDataSet;
            // 
            // personInfoTableAdapter
            // 
            this.personInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersonInfoTableAdapter = this.personInfoTableAdapter;
            this.tableAdapterManager.PhonesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsPhoneBookApplication.PhoneBookDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // personIDTextBox
            // 
            this.personIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personInfoBindingSource, "PersonID", true));
            this.personIDTextBox.Location = new System.Drawing.Point(320, 59);
            this.personIDTextBox.Name = "personIDTextBox";
            this.personIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.personIDTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personInfoBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(385, 104);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personInfoBindingSource, "MiddleName", true));
            this.middleNameTextBox.Location = new System.Drawing.Point(440, 178);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.middleNameTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personInfoBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(437, 261);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personInfoBindingSource, "EMail", true));
            this.eMailTextBox.Location = new System.Drawing.Point(307, 286);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(100, 20);
            this.eMailTextBox.TabIndex = 9;
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personInfoBindingSource, "Comments", true));
            this.commentsTextBox.Location = new System.Drawing.Point(235, 331);
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(100, 20);
            this.commentsTextBox.TabIndex = 11;
            // 
            // phoneNTextBox
            // 
            this.phoneNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personInfoBindingSource, "PhoneN", true));
            this.phoneNTextBox.Location = new System.Drawing.Point(134, 355);
            this.phoneNTextBox.Name = "phoneNTextBox";
            this.phoneNTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNTextBox.TabIndex = 13;
            // 
            // personInfoDataGridView
            // 
            this.personInfoDataGridView.AutoGenerateColumns = false;
            this.personInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.personInfoDataGridView.DataSource = this.personInfoBindingSource;
            this.personInfoDataGridView.Location = new System.Drawing.Point(29, 410);
            this.personInfoDataGridView.Name = "personInfoDataGridView";
            this.personInfoDataGridView.Size = new System.Drawing.Size(606, 220);
            this.personInfoDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PersonID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PersonID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MiddleName";
            this.dataGridViewTextBoxColumn3.HeaderText = "MiddleName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn4.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EMail";
            this.dataGridViewTextBoxColumn5.HeaderText = "EMail";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Comments";
            this.dataGridViewTextBoxColumn6.HeaderText = "Comments";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PhoneN";
            this.dataGridViewTextBoxColumn7.HeaderText = "PhoneN";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 650);
            this.Controls.Add(this.personInfoDataGridView);
            this.Controls.Add(phoneNLabel);
            this.Controls.Add(this.phoneNTextBox);
            this.Controls.Add(commentsLabel);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(eMailLabel);
            this.Controls.Add(this.eMailTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(middleNameLabel);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(personIDLabel);
            this.Controls.Add(this.personIDTextBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personInfoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PhoneBookDataSet phoneBookDataSet;
        private System.Windows.Forms.BindingSource personInfoBindingSource;
        private PhoneBookDataSetTableAdapters.PersonInfoTableAdapter personInfoTableAdapter;
        private PhoneBookDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox personIDTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.TextBox phoneNTextBox;
        private System.Windows.Forms.DataGridView personInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}