namespace SkyPick
{
    partial class ManageFlights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageFlights));
            this.pbBackArrow = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditFlight = new System.Windows.Forms.Button();
            this.btnRemoveFlight = new System.Windows.Forms.Button();
            this.btnAddNewFlight = new System.Windows.Forms.Button();
            this.lblManageUsersListing = new System.Windows.Forms.Label();
            this.gvFlightList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFlightList)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBackArrow
            // 
            this.pbBackArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBackArrow.Image = ((System.Drawing.Image)(resources.GetObject("pbBackArrow.Image")));
            this.pbBackArrow.Location = new System.Drawing.Point(79, 62);
            this.pbBackArrow.Name = "pbBackArrow";
            this.pbBackArrow.Size = new System.Drawing.Size(73, 67);
            this.pbBackArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackArrow.TabIndex = 18;
            this.pbBackArrow.TabStop = false;
            this.pbBackArrow.Click += new System.EventHandler(this.pbBackArrow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(165, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnEditFlight
            // 
            this.btnEditFlight.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnEditFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditFlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnEditFlight.Location = new System.Drawing.Point(428, 469);
            this.btnEditFlight.Name = "btnEditFlight";
            this.btnEditFlight.Size = new System.Drawing.Size(157, 75);
            this.btnEditFlight.TabIndex = 16;
            this.btnEditFlight.Text = "Edit Flight";
            this.btnEditFlight.UseVisualStyleBackColor = false;
            this.btnEditFlight.Click += new System.EventHandler(this.btnEditFlight_Click);
            // 
            // btnRemoveFlight
            // 
            this.btnRemoveFlight.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRemoveFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnRemoveFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnRemoveFlight.Location = new System.Drawing.Point(773, 469);
            this.btnRemoveFlight.Name = "btnRemoveFlight";
            this.btnRemoveFlight.Size = new System.Drawing.Size(157, 75);
            this.btnRemoveFlight.TabIndex = 15;
            this.btnRemoveFlight.Text = "Remove Flight";
            this.btnRemoveFlight.UseVisualStyleBackColor = false;
            this.btnRemoveFlight.Click += new System.EventHandler(this.btnRemoveFlight_Click);
            // 
            // btnAddNewFlight
            // 
            this.btnAddNewFlight.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddNewFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnAddNewFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewFlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnAddNewFlight.Location = new System.Drawing.Point(69, 469);
            this.btnAddNewFlight.Name = "btnAddNewFlight";
            this.btnAddNewFlight.Size = new System.Drawing.Size(157, 75);
            this.btnAddNewFlight.TabIndex = 14;
            this.btnAddNewFlight.Text = "Add New Flight";
            this.btnAddNewFlight.UseVisualStyleBackColor = false;
            this.btnAddNewFlight.Click += new System.EventHandler(this.btnAddNewFlight_Click);
            // 
            // lblManageUsersListing
            // 
            this.lblManageUsersListing.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblManageUsersListing.AutoSize = true;
            this.lblManageUsersListing.Font = new System.Drawing.Font("Corbel", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsersListing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblManageUsersListing.Location = new System.Drawing.Point(281, 56);
            this.lblManageUsersListing.Name = "lblManageUsersListing";
            this.lblManageUsersListing.Size = new System.Drawing.Size(592, 73);
            this.lblManageUsersListing.TabIndex = 13;
            this.lblManageUsersListing.Text = "Manage Flights Listing";
            // 
            // gvFlightList
            // 
            this.gvFlightList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvFlightList.BackgroundColor = System.Drawing.Color.White;
            this.gvFlightList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFlightList.Location = new System.Drawing.Point(69, 141);
            this.gvFlightList.Name = "gvFlightList";
            this.gvFlightList.RowHeadersWidth = 51;
            this.gvFlightList.RowTemplate.Height = 24;
            this.gvFlightList.Size = new System.Drawing.Size(861, 322);
            this.gvFlightList.TabIndex = 12;
            // 
            // ManageFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 600);
            this.Controls.Add(this.pbBackArrow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEditFlight);
            this.Controls.Add(this.btnRemoveFlight);
            this.Controls.Add(this.btnAddNewFlight);
            this.Controls.Add(this.lblManageUsersListing);
            this.Controls.Add(this.gvFlightList);
            this.Name = "ManageFlights";
            this.Text = "ManageFlights";
            this.Load += new System.EventHandler(this.ManageFlights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFlightList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBackArrow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEditFlight;
        private System.Windows.Forms.Button btnRemoveFlight;
        private System.Windows.Forms.Button btnAddNewFlight;
        private System.Windows.Forms.Label lblManageUsersListing;
        private System.Windows.Forms.DataGridView gvFlightList;
    }
}