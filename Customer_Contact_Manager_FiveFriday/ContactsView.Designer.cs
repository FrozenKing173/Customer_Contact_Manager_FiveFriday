namespace Customer_Contact_Manager_FiveFriday
{
    partial class ContactsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsView));
            this.customerContactsListView = new System.Windows.Forms.ListView();
            this.CustomerContactsID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerContactsEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerContactsNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerContactsFkCustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpCustomerContacts = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.CustomerContactsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpCustomerContacts.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerContactsListView
            // 
            this.customerContactsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerContactsID,
            this.CustomerContactsName,
            this.CustomerContactsEmail,
            this.CustomerContactsNumber,
            this.CustomerContactsFkCustomerID});
            this.customerContactsListView.FullRowSelect = true;
            this.customerContactsListView.GridLines = true;
            this.customerContactsListView.Location = new System.Drawing.Point(12, 228);
            this.customerContactsListView.Name = "customerContactsListView";
            this.customerContactsListView.Size = new System.Drawing.Size(378, 214);
            this.customerContactsListView.TabIndex = 7;
            this.customerContactsListView.UseCompatibleStateImageBehavior = false;
            this.customerContactsListView.View = System.Windows.Forms.View.Details;
            this.customerContactsListView.SelectedIndexChanged += new System.EventHandler(this.customerContactsListView_SelectedIndexChanged);
            // 
            // CustomerContactsID
            // 
            this.CustomerContactsID.Text = "ID";
            this.CustomerContactsID.Width = 32;
            // 
            // CustomerContactsEmail
            // 
            this.CustomerContactsEmail.DisplayIndex = 2;
            this.CustomerContactsEmail.Text = "Email";
            this.CustomerContactsEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerContactsEmail.Width = 92;
            // 
            // CustomerContactsNumber
            // 
            this.CustomerContactsNumber.DisplayIndex = 3;
            this.CustomerContactsNumber.Text = "Contact Number";
            this.CustomerContactsNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerContactsNumber.Width = 92;
            // 
            // CustomerContactsFkCustomerID
            // 
            this.CustomerContactsFkCustomerID.DisplayIndex = 4;
            this.CustomerContactsFkCustomerID.Text = "Customer ID";
            this.CustomerContactsFkCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerContactsFkCustomerID.Width = 66;
            // 
            // grpCustomerContacts
            // 
            this.grpCustomerContacts.Controls.Add(this.btnAdd);
            this.grpCustomerContacts.Controls.Add(this.btnDelete);
            this.grpCustomerContacts.Controls.Add(this.btnUpdate);
            this.grpCustomerContacts.Controls.Add(this.txtContactNumber);
            this.grpCustomerContacts.Controls.Add(this.lblContactNumber);
            this.grpCustomerContacts.Controls.Add(this.txtEmail);
            this.grpCustomerContacts.Controls.Add(this.lblEmail);
            this.grpCustomerContacts.Controls.Add(this.txtName);
            this.grpCustomerContacts.Controls.Add(this.lblName);
            this.grpCustomerContacts.Location = new System.Drawing.Point(12, 12);
            this.grpCustomerContacts.Name = "grpCustomerContacts";
            this.grpCustomerContacts.Size = new System.Drawing.Size(378, 203);
            this.grpCustomerContacts.TabIndex = 2;
            this.grpCustomerContacts.TabStop = false;
            this.grpCustomerContacts.Text = "Customer\'s Contacts";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(57, 174);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(219, 174);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(138, 174);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(174, 104);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(160, 20);
            this.txtContactNumber.TabIndex = 3;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(45, 107);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(87, 13);
            this.lblContactNumber.TabIndex = 4;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(174, 78);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(97, 81);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(174, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(94, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // CustomerContactsName
            // 
            this.CustomerContactsName.DisplayIndex = 1;
            this.CustomerContactsName.Text = "Name";
            this.CustomerContactsName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerContactsName.Width = 92;
            // 
            // ContactsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(405, 454);
            this.Controls.Add(this.grpCustomerContacts);
            this.Controls.Add(this.customerContactsListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Text = "FiveFriday";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerContactsView_FormClosing);
            this.Load += new System.EventHandler(this.CustomerContactsView_Load);
            this.grpCustomerContacts.ResumeLayout(false);
            this.grpCustomerContacts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView customerContactsListView;
        private System.Windows.Forms.GroupBox grpCustomerContacts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ColumnHeader CustomerContactsID;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader CustomerContactsEmail;
        private System.Windows.Forms.ColumnHeader CustomerContactsNumber;
        private System.Windows.Forms.ColumnHeader CustomerContactsFkCustomerID;
        private System.Windows.Forms.ColumnHeader ContactName;
        private System.Windows.Forms.ColumnHeader CustomerContactsName;
    }
}