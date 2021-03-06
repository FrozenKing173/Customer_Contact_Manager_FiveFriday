﻿namespace Customer_Contact_Manager_FiveFriday
{
    partial class CustomerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerView));
            this.logo = new System.Windows.Forms.PictureBox();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.btnCustomerContacts = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.grpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(756, 14);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(155, 136);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.btnCustomerContacts);
            this.grpCustomer.Controls.Add(this.btnAdd);
            this.grpCustomer.Controls.Add(this.btnDelete);
            this.grpCustomer.Controls.Add(this.btnUpdate);
            this.grpCustomer.Controls.Add(this.lblID);
            this.grpCustomer.Controls.Add(this.txtLongitude);
            this.grpCustomer.Controls.Add(this.lblLongitude);
            this.grpCustomer.Controls.Add(this.txtLatitude);
            this.grpCustomer.Controls.Add(this.lblLatitude);
            this.grpCustomer.Controls.Add(this.txtName);
            this.grpCustomer.Controls.Add(this.lblName);
            this.grpCustomer.Location = new System.Drawing.Point(12, 12);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(345, 203);
            this.grpCustomer.TabIndex = 1;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer";
            // 
            // btnCustomerContacts
            // 
            this.btnCustomerContacts.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerContacts.ForeColor = System.Drawing.Color.White;
            this.btnCustomerContacts.Location = new System.Drawing.Point(226, 161);
            this.btnCustomerContacts.Margin = new System.Windows.Forms.Padding(0);
            this.btnCustomerContacts.Name = "btnCustomerContacts";
            this.btnCustomerContacts.Size = new System.Drawing.Size(113, 27);
            this.btnCustomerContacts.TabIndex = 7;
            this.btnCustomerContacts.Text = "Contacts";
            this.toolTip.SetToolTip(this.btnCustomerContacts, "Gets a specific customer\'s contacts.");
            this.btnCustomerContacts.UseVisualStyleBackColor = true;
            this.btnCustomerContacts.Click += new System.EventHandler(this.btnCustomerContacts_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(252, 17);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 27);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.toolTip.SetToolTip(this.btnAdd, "Adds a customer.");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(252, 113);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 27);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.toolTip.SetToolTip(this.btnDelete, "Deletes a specific customer.");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(252, 66);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 27);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.toolTip.SetToolTip(this.btnUpdate, "Updates a specific customer.");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(166, 17);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 15);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID:";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(117, 100);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(116, 21);
            this.txtLongitude.TabIndex = 3;
            this.toolTip.SetToolTip(this.txtLongitude, "A decimal number for a customer longitude e.g. 22.23456");
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(20, 103);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(65, 15);
            this.lblLongitude.TabIndex = 4;
            this.lblLongitude.Text = "Longitude:";
            this.toolTip.SetToolTip(this.lblLongitude, "A decimal number for a customer longitude e.g. 22.23456");
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(117, 69);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(116, 21);
            this.txtLatitude.TabIndex = 2;
            this.toolTip.SetToolTip(this.txtLatitude, "A decimal number for a customer latitude e.g. 22.23456");
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(32, 69);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(53, 15);
            this.lblLatitude.TabIndex = 2;
            this.lblLatitude.Text = "Latitude:";
            this.toolTip.SetToolTip(this.lblLatitude, "A decimal number for a customer latitude e.g. 22.23456");
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 21);
            this.txtName.TabIndex = 1;
            this.toolTip.SetToolTip(this.txtName, "A customer name  e.g Jeandre");
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(42, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.toolTip.SetToolTip(this.lblName, "A customer name e.g Jeandre");
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.customerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CustomerName,
            this.Latitude,
            this.Longitude});
            this.customerDataGridView.GridColor = System.Drawing.Color.Black;
            this.customerDataGridView.Location = new System.Drawing.Point(12, 233);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.Size = new System.Drawing.Size(345, 341);
            this.customerDataGridView.TabIndex = 8;
            this.toolTip.SetToolTip(this.customerDataGridView, "A grid containing customers.");
            this.customerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellClick);
            // 
            // ID
            // 
            this.ID.FillWeight = 30F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // CustomerName
            // 
            this.CustomerName.FillWeight = 90F;
            this.CustomerName.HeaderText = "Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 91;
            // 
            // Latitude
            // 
            this.Latitude.FillWeight = 90F;
            this.Latitude.HeaderText = "Latitude";
            this.Latitude.Name = "Latitude";
            this.Latitude.ReadOnly = true;
            this.Latitude.Width = 90;
            // 
            // Longitude
            // 
            this.Longitude.FillWeight = 90F;
            this.Longitude.HeaderText = "Longitude";
            this.Longitude.Name = "Longitude";
            this.Longitude.ReadOnly = true;
            this.Longitude.Width = 90;
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(369, 586);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.logo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(389, 629);
            this.Name = "CustomerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiveFriday";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerView_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCustomerContacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitude;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

