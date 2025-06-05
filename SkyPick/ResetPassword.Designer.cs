namespace SkyPick
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.tbCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.lblResetPassword = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbBackArrow = new System.Windows.Forms.PictureBox();
            this.chShowCurrentPassword = new System.Windows.Forms.CheckBox();
            this.cbShowNewPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword.Location = new System.Drawing.Point(190, 239);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblCurrentPassword.Size = new System.Drawing.Size(169, 33);
            this.lblCurrentPassword.TabIndex = 8;
            this.lblCurrentPassword.Text = "Current password:";
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentPassword.Location = new System.Drawing.Point(376, 239);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.PasswordChar = '*';
            this.tbCurrentPassword.Size = new System.Drawing.Size(217, 34);
            this.tbCurrentPassword.TabIndex = 9;
            this.tbCurrentPassword.TextChanged += new System.EventHandler(this.tbCurrentPassword_TextChanged);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(218, 346);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblNewPassword.Size = new System.Drawing.Size(141, 33);
            this.lblNewPassword.TabIndex = 11;
            this.lblNewPassword.Text = "New Password:";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPassword.Location = new System.Drawing.Point(376, 346);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '*';
            this.tbNewPassword.Size = new System.Drawing.Size(217, 34);
            this.tbNewPassword.TabIndex = 12;
            this.tbNewPassword.TextChanged += new System.EventHandler(this.tbNewPassword_TextChanged);
            // 
            // lblResetPassword
            // 
            this.lblResetPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResetPassword.AutoSize = true;
            this.lblResetPassword.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblResetPassword.Location = new System.Drawing.Point(296, 87);
            this.lblResetPassword.Margin = new System.Windows.Forms.Padding(50);
            this.lblResetPassword.Name = "lblResetPassword";
            this.lblResetPassword.Size = new System.Drawing.Size(439, 81);
            this.lblResetPassword.TabIndex = 14;
            this.lblResetPassword.Text = "Reset Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnResetPassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.Location = new System.Drawing.Point(360, 448);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(246, 69);
            this.btnResetPassword.TabIndex = 16;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(854, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 608);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 608);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pbBackArrow
            // 
            this.pbBackArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBackArrow.Image = ((System.Drawing.Image)(resources.GetObject("pbBackArrow.Image")));
            this.pbBackArrow.Location = new System.Drawing.Point(106, 22);
            this.pbBackArrow.Name = "pbBackArrow";
            this.pbBackArrow.Size = new System.Drawing.Size(73, 67);
            this.pbBackArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackArrow.TabIndex = 19;
            this.pbBackArrow.TabStop = false;
            this.pbBackArrow.Click += new System.EventHandler(this.pbBackArrow_Click);
            // 
            // chShowCurrentPassword
            // 
            this.chShowCurrentPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chShowCurrentPassword.AutoSize = true;
            this.chShowCurrentPassword.Location = new System.Drawing.Point(610, 248);
            this.chShowCurrentPassword.Name = "chShowCurrentPassword";
            this.chShowCurrentPassword.Size = new System.Drawing.Size(125, 20);
            this.chShowCurrentPassword.TabIndex = 20;
            this.chShowCurrentPassword.Text = "Show Password";
            this.chShowCurrentPassword.UseVisualStyleBackColor = true;
            this.chShowCurrentPassword.CheckedChanged += new System.EventHandler(this.chShowCurrentPassword_CheckedChanged);
            // 
            // cbShowNewPassword
            // 
            this.cbShowNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbShowNewPassword.AutoSize = true;
            this.cbShowNewPassword.Location = new System.Drawing.Point(610, 355);
            this.cbShowNewPassword.Name = "cbShowNewPassword";
            this.cbShowNewPassword.Size = new System.Drawing.Size(125, 20);
            this.cbShowNewPassword.TabIndex = 21;
            this.cbShowNewPassword.Text = "Show Password";
            this.cbShowNewPassword.UseVisualStyleBackColor = true;
            this.cbShowNewPassword.CheckedChanged += new System.EventHandler(this.cbShowNewPassword_CheckedChanged);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(954, 608);
            this.Controls.Add(this.cbShowNewPassword);
            this.Controls.Add(this.chShowCurrentPassword);
            this.Controls.Add(this.pbBackArrow);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.lblResetPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.tbCurrentPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.TextBox tbCurrentPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label lblResetPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbBackArrow;
        private System.Windows.Forms.CheckBox chShowCurrentPassword;
        private System.Windows.Forms.CheckBox cbShowNewPassword;
    }
}