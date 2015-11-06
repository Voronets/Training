namespace WindowsFormsPhoneBookApplication
{
    partial class FormDetails
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
            this.checkBoxEditDetails = new System.Windows.Forms.CheckBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.pictureBoxPerson = new System.Windows.Forms.PictureBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.personInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneBookDataSet = new WindowsFormsPhoneBookApplication.PhoneBookDataSet();
            this.buttonDetailsCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelPhones = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxMidName = new System.Windows.Forms.ComboBox();
            this.buttonPrevRecord = new System.Windows.Forms.Button();
            this.buttonNextRecord = new System.Windows.Forms.Button();
            this.labelComments = new System.Windows.Forms.Label();
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.personInfoTableAdapter = new WindowsFormsPhoneBookApplication.PhoneBookDataSetTableAdapters.PersonInfoTableAdapter();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.personInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personInfoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.personInfoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.labelRecDeleted = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personInfoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personInfoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personInfoBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxEditDetails
            // 
            this.checkBoxEditDetails.AutoSize = true;
            this.checkBoxEditDetails.Location = new System.Drawing.Point(25, 265);
            this.checkBoxEditDetails.Name = "checkBoxEditDetails";
            this.checkBoxEditDetails.Size = new System.Drawing.Size(94, 17);
            this.checkBoxEditDetails.TabIndex = 0;
            this.checkBoxEditDetails.Text = "Enable Editing";
            this.checkBoxEditDetails.UseVisualStyleBackColor = true;
            this.checkBoxEditDetails.CheckedChanged += new System.EventHandler(this.checkBoxEditDetails_CheckedChanged);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(252, 55);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(252, 83);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(69, 13);
            this.labelMiddleName.TabIndex = 2;
            this.labelMiddleName.Text = "Middle Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(252, 111);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Last Name";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(252, 139);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "E-mail";
            // 
            // pictureBoxPerson
            // 
            this.pictureBoxPerson.Location = new System.Drawing.Point(25, 26);
            this.pictureBoxPerson.Name = "pictureBoxPerson";
            this.pictureBoxPerson.Size = new System.Drawing.Size(175, 206);
            this.pictureBoxPerson.TabIndex = 5;
            this.pictureBoxPerson.TabStop = false;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phoneBookDataSet, "PersonInfo.FirstName", true));
            this.textBoxFirstName.Enabled = false;
            this.textBoxFirstName.Location = new System.Drawing.Point(327, 55);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFirstName.TabIndex = 6;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phoneBookDataSet, "PersonInfo.LastName", true));
            this.textBoxLastName.Enabled = false;
            this.textBoxLastName.Location = new System.Drawing.Point(327, 110);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(250, 20);
            this.textBoxLastName.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phoneBookDataSet, "PersonInfo.EMail", true));
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Location = new System.Drawing.Point(327, 137);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(250, 20);
            this.textBoxEmail.TabIndex = 9;
            // 
            // personInfoBindingSource
            // 
            this.personInfoBindingSource.DataMember = "PersonInfo";
            this.personInfoBindingSource.DataSource = this.phoneBookDataSet;
            // 
            // phoneBookDataSet
            // 
            this.phoneBookDataSet.DataSetName = "PhoneBookDataSet";
            this.phoneBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonDetailsCancel
            // 
            this.buttonDetailsCancel.Location = new System.Drawing.Point(487, 294);
            this.buttonDetailsCancel.Name = "buttonDetailsCancel";
            this.buttonDetailsCancel.Size = new System.Drawing.Size(90, 24);
            this.buttonDetailsCancel.TabIndex = 10;
            this.buttonDetailsCancel.Text = "Cancel";
            this.buttonDetailsCancel.UseVisualStyleBackColor = true;
            this.buttonDetailsCancel.Click += new System.EventHandler(this.buttonDetailsCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(25, 294);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(130, 24);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save changes";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelPhones
            // 
            this.labelPhones.AutoSize = true;
            this.labelPhones.Location = new System.Drawing.Point(252, 167);
            this.labelPhones.Name = "labelPhones";
            this.labelPhones.Size = new System.Drawing.Size(38, 13);
            this.labelPhones.TabIndex = 13;
            this.labelPhones.Text = "Phone";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(161, 294);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(130, 24);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Delete Record";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxMidName
            // 
            this.comboBoxMidName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phoneBookDataSet, "PersonInfo.MiddleName", true));
            this.comboBoxMidName.Enabled = false;
            this.comboBoxMidName.FormattingEnabled = true;
            this.comboBoxMidName.Location = new System.Drawing.Point(327, 81);
            this.comboBoxMidName.Name = "comboBoxMidName";
            this.comboBoxMidName.Size = new System.Drawing.Size(153, 21);
            this.comboBoxMidName.TabIndex = 15;
            // 
            // buttonPrevRecord
            // 
            this.buttonPrevRecord.Location = new System.Drawing.Point(327, 294);
            this.buttonPrevRecord.Name = "buttonPrevRecord";
            this.buttonPrevRecord.Size = new System.Drawing.Size(75, 24);
            this.buttonPrevRecord.TabIndex = 16;
            this.buttonPrevRecord.Text = "<< Previous";
            this.buttonPrevRecord.UseVisualStyleBackColor = true;
            this.buttonPrevRecord.Click += new System.EventHandler(this.buttonPrevRecord_Click);
            // 
            // buttonNextRecord
            // 
            this.buttonNextRecord.Location = new System.Drawing.Point(405, 294);
            this.buttonNextRecord.Name = "buttonNextRecord";
            this.buttonNextRecord.Size = new System.Drawing.Size(75, 24);
            this.buttonNextRecord.TabIndex = 17;
            this.buttonNextRecord.Text = "Next >>";
            this.buttonNextRecord.UseVisualStyleBackColor = true;
            this.buttonNextRecord.Click += new System.EventHandler(this.buttonNextRecord_Click);
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Location = new System.Drawing.Point(252, 192);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(56, 13);
            this.labelComments.TabIndex = 18;
            this.labelComments.Text = "Comments";
            // 
            // textBoxComments
            // 
            this.textBoxComments.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phoneBookDataSet, "PersonInfo.Comments", true));
            this.textBoxComments.Enabled = false;
            this.textBoxComments.Location = new System.Drawing.Point(326, 193);
            this.textBoxComments.Multiline = true;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(250, 39);
            this.textBoxComments.TabIndex = 19;
            // 
            // personInfoTableAdapter
            // 
            this.personInfoTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxID
            // 
            this.textBoxID.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.personInfoBindingSource4, "PersonID", true));
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(326, 29);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(250, 20);
            this.textBoxID.TabIndex = 20;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(252, 32);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(25, 13);
            this.labelID.TabIndex = 21;
            this.labelID.Text = "ID#";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phoneBookDataSet, "PersonInfo.PhoneN", true));
            this.textBoxPhone.Enabled = false;
            this.textBoxPhone.Location = new System.Drawing.Point(326, 163);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(250, 20);
            this.textBoxPhone.TabIndex = 22;
            // 
            // personInfoBindingSource1
            // 
            this.personInfoBindingSource1.DataMember = "PersonInfo";
            this.personInfoBindingSource1.DataSource = this.phoneBookDataSet;
            // 
            // personInfoBindingSource2
            // 
            this.personInfoBindingSource2.DataMember = "PersonInfo";
            this.personInfoBindingSource2.DataSource = this.phoneBookDataSet;
            // 
            // personInfoBindingSource3
            // 
            this.personInfoBindingSource3.DataMember = "PersonInfo";
            this.personInfoBindingSource3.DataSource = this.phoneBookDataSet;
            // 
            // personInfoBindingSource4
            // 
            this.personInfoBindingSource4.DataMember = "PersonInfo";
            this.personInfoBindingSource4.DataSource = this.phoneBookDataSet;
            // 
            // labelRecDeleted
            // 
            this.labelRecDeleted.AutoSize = true;
            this.labelRecDeleted.ForeColor = System.Drawing.Color.Red;
            this.labelRecDeleted.Location = new System.Drawing.Point(412, 265);
            this.labelRecDeleted.Name = "labelRecDeleted";
            this.labelRecDeleted.Size = new System.Drawing.Size(165, 13);
            this.labelRecDeleted.TabIndex = 23;
            this.labelRecDeleted.Text = "Record was successfully deleted.";
            this.labelRecDeleted.Visible = false;
            // 
            // FormDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 340);
            this.Controls.Add(this.labelRecDeleted);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxComments);
            this.Controls.Add(this.labelComments);
            this.Controls.Add(this.buttonNextRecord);
            this.Controls.Add(this.buttonPrevRecord);
            this.Controls.Add(this.comboBoxMidName);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelPhones);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDetailsCancel);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.pictureBoxPerson);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.checkBoxEditDetails);
            this.Name = "FormDetails";
            this.Text = "View Details";
            this.Load += new System.EventHandler(this.FormDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personInfoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personInfoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personInfoBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.PictureBox pictureBoxPerson;
        private System.Windows.Forms.Button buttonDetailsCancel;
        private System.Windows.Forms.Label labelPhones;
        public System.Windows.Forms.CheckBox checkBoxEditDetails;
        public System.Windows.Forms.TextBox textBoxFirstName;
        public System.Windows.Forms.TextBox textBoxLastName;
        public System.Windows.Forms.TextBox textBoxEmail;
        public System.Windows.Forms.Button buttonDelete;
        public System.Windows.Forms.ComboBox comboBoxMidName;
        public System.Windows.Forms.Button buttonPrevRecord;
        public System.Windows.Forms.Button buttonNextRecord;
        private System.Windows.Forms.Label labelComments;
        public System.Windows.Forms.TextBox textBoxComments;
        private PhoneBookDataSet phoneBookDataSet;
        private System.Windows.Forms.BindingSource personInfoBindingSource;
        private PhoneBookDataSetTableAdapters.PersonInfoTableAdapter personInfoTableAdapter;
        public System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        public System.Windows.Forms.TextBox textBoxPhone;
        public System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.BindingSource personInfoBindingSource4;
        private System.Windows.Forms.BindingSource personInfoBindingSource1;
        private System.Windows.Forms.BindingSource personInfoBindingSource2;
        private System.Windows.Forms.BindingSource personInfoBindingSource3;
        private System.Windows.Forms.Label labelRecDeleted;
    }
}