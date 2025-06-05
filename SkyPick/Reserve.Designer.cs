namespace SkyPick
{
    partial class Reserve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reserve));
            this.lblBookAFlight = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearchFlights = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.cbDepCountry = new System.Windows.Forms.ComboBox();
            this.cbArrCity = new System.Windows.Forms.ComboBox();
            this.cbArrCountry = new System.Windows.Forms.ComboBox();
            this.cbDepCity = new System.Windows.Forms.ComboBox();
            this.cbDepAirport = new System.Windows.Forms.ComboBox();
            this.cbArrAirport = new System.Windows.Forms.ComboBox();
            this.cbSeatClass = new System.Windows.Forms.ComboBox();
            this.nudSeats = new System.Windows.Forms.NumericUpDown();
            this.dgvFlights = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pbBackArrow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookAFlight
            // 
            this.lblBookAFlight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBookAFlight.AutoSize = true;
            this.lblBookAFlight.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAFlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblBookAFlight.Location = new System.Drawing.Point(321, 25);
            this.lblBookAFlight.Margin = new System.Windows.Forms.Padding(50);
            this.lblBookAFlight.Name = "lblBookAFlight";
            this.lblBookAFlight.Size = new System.Drawing.Size(380, 81);
            this.lblBookAFlight.TabIndex = 13;
            this.lblBookAFlight.Text = "Book a Flight";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearchFlights
            // 
            this.btnSearchFlights.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchFlights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnSearchFlights.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnSearchFlights.Font = new System.Drawing.Font("Segoe UI", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFlights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnSearchFlights.Location = new System.Drawing.Point(616, 233);
            this.btnSearchFlights.Name = "btnSearchFlights";
            this.btnSearchFlights.Size = new System.Drawing.Size(145, 48);
            this.btnSearchFlights.TabIndex = 14;
            this.btnSearchFlights.Text = "Search ";
            this.btnSearchFlights.UseVisualStyleBackColor = false;
            // 
            // btnReserve
            // 
            this.btnReserve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnReserve.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnReserve.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnReserve.Location = new System.Drawing.Point(798, 233);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(140, 48);
            this.btnReserve.TabIndex = 17;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = false;
            // 
            // cbDepCountry
            // 
            this.cbDepCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDepCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepCountry.FormattingEnabled = true;
            this.cbDepCountry.Location = new System.Drawing.Point(27, 169);
            this.cbDepCountry.Name = "cbDepCountry";
            this.cbDepCountry.Size = new System.Drawing.Size(167, 33);
            this.cbDepCountry.TabIndex = 18;
            // 
            // cbArrCity
            // 
            this.cbArrCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbArrCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArrCity.FormattingEnabled = true;
            this.cbArrCity.Location = new System.Drawing.Point(221, 248);
            this.cbArrCity.Name = "cbArrCity";
            this.cbArrCity.Size = new System.Drawing.Size(167, 33);
            this.cbArrCity.TabIndex = 19;
            // 
            // cbArrCountry
            // 
            this.cbArrCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbArrCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArrCountry.FormattingEnabled = true;
            this.cbArrCountry.Location = new System.Drawing.Point(27, 248);
            this.cbArrCountry.Name = "cbArrCountry";
            this.cbArrCountry.Size = new System.Drawing.Size(167, 33);
            this.cbArrCountry.TabIndex = 20;
            // 
            // cbDepCity
            // 
            this.cbDepCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDepCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepCity.FormattingEnabled = true;
            this.cbDepCity.Location = new System.Drawing.Point(221, 169);
            this.cbDepCity.Name = "cbDepCity";
            this.cbDepCity.Size = new System.Drawing.Size(167, 33);
            this.cbDepCity.TabIndex = 21;
            // 
            // cbDepAirport
            // 
            this.cbDepAirport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDepAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepAirport.FormattingEnabled = true;
            this.cbDepAirport.Location = new System.Drawing.Point(413, 169);
            this.cbDepAirport.Name = "cbDepAirport";
            this.cbDepAirport.Size = new System.Drawing.Size(167, 33);
            this.cbDepAirport.TabIndex = 22;
            // 
            // cbArrAirport
            // 
            this.cbArrAirport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbArrAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArrAirport.FormattingEnabled = true;
            this.cbArrAirport.Location = new System.Drawing.Point(413, 248);
            this.cbArrAirport.Name = "cbArrAirport";
            this.cbArrAirport.Size = new System.Drawing.Size(167, 33);
            this.cbArrAirport.TabIndex = 23;
            // 
            // cbSeatClass
            // 
            this.cbSeatClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSeatClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeatClass.FormattingEnabled = true;
            this.cbSeatClass.Location = new System.Drawing.Point(603, 169);
            this.cbSeatClass.Name = "cbSeatClass";
            this.cbSeatClass.Size = new System.Drawing.Size(167, 33);
            this.cbSeatClass.TabIndex = 24;
            // 
            // nudSeats
            // 
            this.nudSeats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSeats.Location = new System.Drawing.Point(777, 169);
            this.nudSeats.Name = "nudSeats";
            this.nudSeats.Size = new System.Drawing.Size(167, 34);
            this.nudSeats.TabIndex = 25;
            // 
            // dgvFlights
            // 
            this.dgvFlights.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Location = new System.Drawing.Point(12, 287);
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.RowHeadersWidth = 51;
            this.dgvFlights.RowTemplate.Height = 24;
            this.dgvFlights.Size = new System.Drawing.Size(926, 312);
            this.dgvFlights.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Departure Country:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Departure City:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Departure Airport:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Arrival Country:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Arrival City:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(430, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Arrival Airport:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(623, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "Seat Class:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(780, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "Number of Seats:";
            // 
            // pbBackArrow
            // 
            this.pbBackArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBackArrow.Image = ((System.Drawing.Image)(resources.GetObject("pbBackArrow.Image")));
            this.pbBackArrow.Location = new System.Drawing.Point(36, 39);
            this.pbBackArrow.Name = "pbBackArrow";
            this.pbBackArrow.Size = new System.Drawing.Size(73, 67);
            this.pbBackArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackArrow.TabIndex = 35;
            this.pbBackArrow.TabStop = false;
            this.pbBackArrow.Click += new System.EventHandler(this.pbBackArrow_Click);
            // 
            // Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 611);
            this.Controls.Add(this.pbBackArrow);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFlights);
            this.Controls.Add(this.nudSeats);
            this.Controls.Add(this.cbSeatClass);
            this.Controls.Add(this.cbArrAirport);
            this.Controls.Add(this.cbDepAirport);
            this.Controls.Add(this.cbDepCity);
            this.Controls.Add(this.cbArrCountry);
            this.Controls.Add(this.cbArrCity);
            this.Controls.Add(this.cbDepCountry);
            this.Controls.Add(this.lblBookAFlight);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSearchFlights);
            this.Controls.Add(this.btnReserve);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reserve";
            this.Text = "Reserve";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBookAFlight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearchFlights;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.ComboBox cbDepCountry;
        private System.Windows.Forms.ComboBox cbArrCity;
        private System.Windows.Forms.ComboBox cbArrCountry;
        private System.Windows.Forms.ComboBox cbDepCity;
        private System.Windows.Forms.ComboBox cbDepAirport;
        private System.Windows.Forms.ComboBox cbArrAirport;
        private System.Windows.Forms.ComboBox cbSeatClass;
        private System.Windows.Forms.NumericUpDown nudSeats;
        private System.Windows.Forms.DataGridView dgvFlights;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbBackArrow;
    }
}