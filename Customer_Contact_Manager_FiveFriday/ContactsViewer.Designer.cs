namespace Customer_Contact_Manager_FiveFriday
{
    partial class ContactsViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsViewer));
            this.customerContactsListView = new System.Windows.Forms.ListView();
            this.CustomerContactsID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerContactsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerContactsEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerContactsNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpCustomerContacts = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grpCustomerContacts.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerContactsListView
            // 
            this.customerContactsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerContactsID,
            this.CustomerContactsName,
            this.CustomerContactsEmail,
            this.CustomerContactsNumber});
            this.customerContactsListView.FullRowSelect = true;
            this.customerContactsListView.GridLines = true;
            this.customerContactsListView.HideSelection = false;
            this.customerContactsListView.Location = new System.Drawing.Point(12, 266);
            this.customerContactsListView.Name = "customerContactsListView";
            this.customerContactsListView.Size = new System.Drawing.Size(443, 464);
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
            // CustomerContactsName
            // 
            this.CustomerContactsName.Text = "Name";
            this.CustomerContactsName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerContactsName.Width = 118;
            // 
            // CustomerContactsEmail
            // 
            this.CustomerContactsEmail.Text = "Email";
            this.CustomerContactsEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerContactsEmail.Width = 159;
            // 
            // CustomerContactsNumber
            // 
            this.CustomerContactsNumber.Text = "Contact Number";
            this.CustomerContactsNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerContactsNumber.Width = 130;
            // 
            // grpCustomerContacts
            // 
            this.grpCustomerContacts.Controls.Add(this.lblID);
            this.grpCustomerContacts.Controls.Add(this.lblCustomerName);
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
            this.grpCustomerContacts.Size = new System.Drawing.Size(443, 234);
            this.grpCustomerContacts.TabIndex = 2;
            this.grpCustomerContacts.TabStop = false;
            this.grpCustomerContacts.Text = "Customer\'s contacts";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(399, 207);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 15);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(51, 17);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(164, 22);
            this.lblCustomerName.TabIndex = 7;
            this.lblCustomerName.Text = "lblCustomerName";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(66, 201);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 27);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(255, 201);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 27);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(161, 201);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 27);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(203, 120);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(186, 21);
            this.txtContactNumber.TabIndex = 3;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(52, 123);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(100, 15);
            this.lblContactNumber.TabIndex = 4;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(203, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 21);
            this.txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(113, 93);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(40, 15);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(203, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 21);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(110, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // ContactsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(467, 742);
            this.Controls.Add(this.grpCustomerContacts);
            this.Controls.Add(this.customerContactsListView);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(487, 785);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ColumnHeader ContactName;
        private System.Windows.Forms.ColumnHeader CustomerContactsName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblID;
    }
}