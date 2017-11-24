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
            this.customerContactsListView = new System.Windows.Forms.ListView();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContactNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FKCustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerContactsListView
            // 
            this.customerContactsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name,
            this.Email,
            this.ContactNumber,
            this.FKCustomerID});
            this.customerContactsListView.Location = new System.Drawing.Point(12, 277);
            this.customerContactsListView.Name = "customerContactsListView";
            this.customerContactsListView.Size = new System.Drawing.Size(378, 214);
            this.customerContactsListView.TabIndex = 0;
            this.customerContactsListView.UseCompatibleStateImageBehavior = false;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.lblCustomerID);
            this.grpCustomer.Controls.Add(this.btnAdd);
            this.grpCustomer.Controls.Add(this.btnDelete);
            this.grpCustomer.Controls.Add(this.btnUpdate);
            this.grpCustomer.Controls.Add(this.lblID);
            this.grpCustomer.Controls.Add(this.txtContactNumber);
            this.grpCustomer.Controls.Add(this.lblContactNumber);
            this.grpCustomer.Controls.Add(this.txtEmail);
            this.grpCustomer.Controls.Add(this.lblEmail);
            this.grpCustomer.Controls.Add(this.txtName);
            this.grpCustomer.Controls.Add(this.lblName);
            this.grpCustomer.Location = new System.Drawing.Point(12, 24);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(378, 203);
            this.grpCustomer.TabIndex = 2;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 174);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(168, 174);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(87, 174);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(311, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID:";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(110, 87);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(100, 20);
            this.txtContactNumber.TabIndex = 5;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(17, 90);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(87, 13);
            this.lblContactNumber.TabIndex = 4;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 60);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(17, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(311, 37);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(21, 13);
            this.lblCustomerID.TabIndex = 9;
            this.lblCustomerID.Text = "ID:";
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 30;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ContactNumber
            // 
            this.ContactNumber.Text = "Contact Number";
            this.ContactNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FKCustomerID
            // 
            this.FKCustomerID.Text = "Customer ID";
            this.FKCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CustomerContactsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 503);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.customerContactsListView);           
            this.Text = "FiveFriday";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerContactsView_FormClosing);
            this.Load += new System.EventHandler(this.CustomerContactsView_Load);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView customerContactsListView;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader ContactNumber;
        private System.Windows.Forms.ColumnHeader FKCustomerID;
    }
}