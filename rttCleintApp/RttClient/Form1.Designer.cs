namespace RttClient
{
    partial class frmClient
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
            this.tcClient = new System.Windows.Forms.TabControl();
            this.tbClient = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.dgvContactDetails = new System.Windows.Forms.DataGridView();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddress = new System.Windows.Forms.Button();
            this.dgvAddresses = new System.Windows.Forms.DataGridView();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtSurburb = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbManageClients = new System.Windows.Forms.TabPage();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.tcClient.SuspendLayout();
            this.tbClient.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactDetails)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddresses)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tbManageClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // tcClient
            // 
            this.tcClient.Controls.Add(this.tbClient);
            this.tcClient.Controls.Add(this.tbManageClients);
            this.tcClient.Location = new System.Drawing.Point(3, 3);
            this.tcClient.Name = "tcClient";
            this.tcClient.SelectedIndex = 0;
            this.tcClient.Size = new System.Drawing.Size(846, 583);
            this.tcClient.TabIndex = 0;
            // 
            // tbClient
            // 
            this.tbClient.Controls.Add(this.panel1);
            this.tbClient.Location = new System.Drawing.Point(4, 22);
            this.tbClient.Name = "tbClient";
            this.tbClient.Padding = new System.Windows.Forms.Padding(3);
            this.tbClient.Size = new System.Drawing.Size(838, 557);
            this.tbClient.TabIndex = 0;
            this.tbClient.Text = "Client Info";
            this.tbClient.UseVisualStyleBackColor = true;
            this.tbClient.Enter += new System.EventHandler(this.tbClient_Enter);
            this.tbClient.Leave += new System.EventHandler(this.tbClient_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 551);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(689, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddContact);
            this.groupBox3.Controls.Add(this.dgvContactDetails);
            this.groupBox3.Controls.Add(this.cmbType);
            this.groupBox3.Controls.Add(this.txtNumber);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 375);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(804, 141);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contact Details";
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(677, 26);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(121, 23);
            this.btnAddContact.TabIndex = 11;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Visible = false;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // dgvContactDetails
            // 
            this.dgvContactDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvContactDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactDetails.Location = new System.Drawing.Point(23, 70);
            this.dgvContactDetails.Name = "dgvContactDetails";
            this.dgvContactDetails.Size = new System.Drawing.Size(775, 55);
            this.dgvContactDetails.TabIndex = 15;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Cell Phone",
            "Work Number",
            "Home Number"});
            this.cmbType.Location = new System.Drawing.Point(106, 23);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(177, 21);
            this.cmbType.TabIndex = 15;
            // 
            // txtNumber
            // 
            this.txtNumber.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtNumber.Location = new System.Drawing.Point(375, 26);
            this.txtNumber.MaxLength = 10;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(177, 20);
            this.txtNumber.TabIndex = 15;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(290, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddress);
            this.groupBox2.Controls.Add(this.dgvAddresses);
            this.groupBox2.Controls.Add(this.cmbProvince);
            this.groupBox2.Controls.Add(this.txtCity);
            this.groupBox2.Controls.Add(this.txtPostalCode);
            this.groupBox2.Controls.Add(this.txtSurburb);
            this.groupBox2.Controls.Add(this.txtStreetAddress);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 212);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address Information";
            // 
            // btnAddress
            // 
            this.btnAddress.Location = new System.Drawing.Point(677, 52);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(121, 23);
            this.btnAddress.TabIndex = 16;
            this.btnAddress.Text = "Add Address";
            this.btnAddress.UseVisualStyleBackColor = true;
            this.btnAddress.Visible = false;
            this.btnAddress.Click += new System.EventHandler(this.btnAddress_Click);
            // 
            // dgvAddresses
            // 
            this.dgvAddresses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddresses.Location = new System.Drawing.Point(23, 81);
            this.dgvAddresses.Name = "dgvAddresses";
            this.dgvAddresses.ReadOnly = true;
            this.dgvAddresses.Size = new System.Drawing.Size(775, 125);
            this.dgvAddresses.TabIndex = 14;
            // 
            // cmbProvince
            // 
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Items.AddRange(new object[] {
            "Eastern Cape ",
            "Free State ",
            "Gauteng ",
            "KwaZulu-Natal ",
            "Limpopo ",
            "Mpumalanga ",
            "Northern Cape ",
            "North West ",
            "Western Cape "});
            this.cmbProvince.Location = new System.Drawing.Point(623, 22);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(177, 21);
            this.cmbProvince.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(375, 51);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(177, 20);
            this.txtCity.TabIndex = 13;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(375, 25);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(177, 20);
            this.txtPostalCode.TabIndex = 12;
            this.txtPostalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPostalCode_KeyPress);
            // 
            // txtSurburb
            // 
            this.txtSurburb.Location = new System.Drawing.Point(106, 51);
            this.txtSurburb.Name = "txtSurburb";
            this.txtSurburb.Size = new System.Drawing.Size(177, 20);
            this.txtSurburb.TabIndex = 11;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(106, 25);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(177, 20);
            this.txtStreetAddress.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(568, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Province";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Postal Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Surburb";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Street Address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.txtIdNumber);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Information";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Gender"});
            this.cmbGender.Location = new System.Drawing.Point(472, 18);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(177, 21);
            this.cmbGender.TabIndex = 8;
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(472, 52);
            this.txtIdNumber.MaxLength = 13;
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(177, 20);
            this.txtIdNumber.TabIndex = 7;
            this.txtIdNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdNumber_KeyPress);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(105, 53);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(177, 20);
            this.txtSurname.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 20);
            this.txtName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Id Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tbManageClients
            // 
            this.tbManageClients.Controls.Add(this.btnAddClient);
            this.tbManageClients.Controls.Add(this.dgvClients);
            this.tbManageClients.Location = new System.Drawing.Point(4, 22);
            this.tbManageClients.Name = "tbManageClients";
            this.tbManageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tbManageClients.Size = new System.Drawing.Size(838, 557);
            this.tbManageClients.TabIndex = 1;
            this.tbManageClients.Text = "Manage Clients";
            this.tbManageClients.UseVisualStyleBackColor = true;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(700, 505);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(121, 30);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "Add New";
            this.btnAddClient.UseVisualStyleBackColor = true;
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(7, 16);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.Size = new System.Drawing.Size(814, 458);
            this.dgvClients.TabIndex = 0;
            this.dgvClients.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClients_CellMouseClick);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 584);
            this.Controls.Add(this.tcClient);
            this.Name = "frmClient";
            this.Text = "Client Details";
            this.tcClient.ResumeLayout(false);
            this.tbClient.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactDetails)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddresses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbManageClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcClient;
        private System.Windows.Forms.TabPage tbClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.DataGridView dgvContactDetails;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddress;
        private System.Windows.Forms.DataGridView dgvAddresses;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtSurburb;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbManageClients;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.DataGridView dgvClients;
    }
}

