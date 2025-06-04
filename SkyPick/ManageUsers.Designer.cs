namespace SkyPick
{
    partial class ManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers));
            this.btnDeactivateActivateUser = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.lblManageUsersListing = new System.Windows.Forms.Label();
            this.gvUserList = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeactivateActivateUser
            // 
            this.btnDeactivateActivateUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeactivateActivateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnDeactivateActivateUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnDeactivateActivateUser.Location = new System.Drawing.Point(336, 378);
            this.btnDeactivateActivateUser.Name = "btnDeactivateActivateUser";
            this.btnDeactivateActivateUser.Size = new System.Drawing.Size(150, 60);
            this.btnDeactivateActivateUser.TabIndex = 9;
            this.btnDeactivateActivateUser.Text = "Deactivate/Activate User";
            this.btnDeactivateActivateUser.UseVisualStyleBackColor = false;
            this.btnDeactivateActivateUser.Click += new System.EventHandler(this.btnDeactivateUser_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnResetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnResetPassword.Location = new System.Drawing.Point(677, 378);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(111, 60);
            this.btnResetPassword.TabIndex = 8;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnAddNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnAddNewUser.Location = new System.Drawing.Point(12, 375);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(111, 60);
            this.btnAddNewUser.TabIndex = 7;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // lblManageUsersListing
            // 
            this.lblManageUsersListing.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblManageUsersListing.AutoSize = true;
            this.lblManageUsersListing.Font = new System.Drawing.Font("Corbel", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsersListing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblManageUsersListing.Location = new System.Drawing.Point(182, 20);
            this.lblManageUsersListing.Name = "lblManageUsersListing";
            this.lblManageUsersListing.Size = new System.Drawing.Size(561, 73);
            this.lblManageUsersListing.TabIndex = 6;
            this.lblManageUsersListing.Text = "Manage Users Listing";
            // 
            // gvUserList
            // 
            this.gvUserList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvUserList.BackgroundColor = System.Drawing.Color.White;
            this.gvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUserList.Location = new System.Drawing.Point(12, 105);
            this.gvUserList.Name = "gvUserList";
            this.gvUserList.RowHeadersWidth = 51;
            this.gvUserList.RowTemplate.Height = 24;
            this.gvUserList.Size = new System.Drawing.Size(776, 252);
            this.gvUserList.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDeactivateActivateUser);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.lblManageUsersListing);
            this.Controls.Add(this.gvUserList);
            this.Name = "ManageUsers";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeactivateActivateUser;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Label lblManageUsersListing;
        private System.Windows.Forms.DataGridView gvUserList;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}