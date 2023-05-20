namespace AirlineManagementSystem
{
    partial class FlightTbl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightTbl));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FcodeTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FcabTb = new System.Windows.Forms.TextBox();
            this.FSrcCB = new System.Windows.Forms.ComboBox();
            this.FDestCB = new System.Windows.Forms.ComboBox();
            this.btnFReset = new System.Windows.Forms.Button();
            this.btnFRecord = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.FdateTb = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVflight = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(156, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fly Jinnah Airline";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(177, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Record New Flights";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(16, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Flight Code";
            // 
            // FcodeTb
            // 
            this.FcodeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FcodeTb.Location = new System.Drawing.Point(192, 215);
            this.FcodeTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FcodeTb.Name = "FcodeTb";
            this.FcodeTb.Size = new System.Drawing.Size(236, 31);
            this.FcodeTb.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(16, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Source";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(16, 324);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Destination";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(16, 420);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Number of seats";
            // 
            // FcabTb
            // 
            this.FcabTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FcabTb.Location = new System.Drawing.Point(192, 421);
            this.FcabTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FcabTb.Name = "FcabTb";
            this.FcabTb.Size = new System.Drawing.Size(236, 31);
            this.FcabTb.TabIndex = 5;
            // 
            // FSrcCB
            // 
            this.FSrcCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FSrcCB.ForeColor = System.Drawing.Color.Red;
            this.FSrcCB.FormattingEnabled = true;
            this.FSrcCB.Items.AddRange(new object[] {
            "Lahore",
            "Islamabad",
            "Karchi",
            "Multan"});
            this.FSrcCB.Location = new System.Drawing.Point(192, 268);
            this.FSrcCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FSrcCB.Name = "FSrcCB";
            this.FSrcCB.Size = new System.Drawing.Size(236, 33);
            this.FSrcCB.TabIndex = 2;
            this.FSrcCB.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // FDestCB
            // 
            this.FDestCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FDestCB.ForeColor = System.Drawing.Color.Red;
            this.FDestCB.FormattingEnabled = true;
            this.FDestCB.Items.AddRange(new object[] {
            "Lahore",
            "Islamabad",
            "Karchi",
            "Multan",
            "India",
            "United State",
            "UK"});
            this.FDestCB.Location = new System.Drawing.Point(192, 320);
            this.FDestCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FDestCB.Name = "FDestCB";
            this.FDestCB.Size = new System.Drawing.Size(236, 33);
            this.FDestCB.TabIndex = 3;
            this.FDestCB.SelectedIndexChanged += new System.EventHandler(this.FDestCB_SelectedIndexChanged);
            // 
            // btnFReset
            // 
            this.btnFReset.BackColor = System.Drawing.Color.Navy;
            this.btnFReset.FlatAppearance.BorderSize = 0;
            this.btnFReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFReset.ForeColor = System.Drawing.Color.White;
            this.btnFReset.Location = new System.Drawing.Point(282, 539);
            this.btnFReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFReset.Name = "btnFReset";
            this.btnFReset.Size = new System.Drawing.Size(112, 47);
            this.btnFReset.TabIndex = 7;
            this.btnFReset.Text = "Reset";
            this.btnFReset.UseVisualStyleBackColor = false;
            this.btnFReset.Click += new System.EventHandler(this.BtnFReset_Click);
            // 
            // btnFRecord
            // 
            this.btnFRecord.BackColor = System.Drawing.Color.Navy;
            this.btnFRecord.FlatAppearance.BorderSize = 0;
            this.btnFRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFRecord.ForeColor = System.Drawing.Color.White;
            this.btnFRecord.Location = new System.Drawing.Point(143, 539);
            this.btnFRecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFRecord.Name = "btnFRecord";
            this.btnFRecord.Size = new System.Drawing.Size(112, 47);
            this.btnFRecord.TabIndex = 6;
            this.btnFRecord.Text = "Record";
            this.btnFRecord.UseVisualStyleBackColor = false;
            this.btnFRecord.Click += new System.EventHandler(this.BtnFRecord_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(16, 369);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "TakeofDate";
            // 
            // FdateTb
            // 
            this.FdateTb.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FdateTb.CustomFormat = "";
            this.FdateTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FdateTb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FdateTb.Location = new System.Drawing.Point(193, 369);
            this.FdateTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FdateTb.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.FdateTb.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.FdateTb.Name = "FdateTb";
            this.FdateTb.Size = new System.Drawing.Size(234, 31);
            this.FdateTb.TabIndex = 4;
            this.FdateTb.Value = new System.DateTime(2022, 12, 14, 19, 59, 43, 0);
            this.FdateTb.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AirlineManagementSystem.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(462, 223);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 187);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnVflight
            // 
            this.btnVflight.BackColor = System.Drawing.Color.Navy;
            this.btnVflight.FlatAppearance.BorderSize = 0;
            this.btnVflight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVflight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVflight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVflight.ForeColor = System.Drawing.Color.White;
            this.btnVflight.Location = new System.Drawing.Point(236, 603);
            this.btnVflight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVflight.Name = "btnVflight";
            this.btnVflight.Size = new System.Drawing.Size(191, 47);
            this.btnVflight.TabIndex = 9;
            this.btnVflight.Text = "View Flights";
            this.btnVflight.UseVisualStyleBackColor = false;
            this.btnVflight.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Navy;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(420, 539);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 47);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FlightTbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 679);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnVflight);
            this.Controls.Add(this.FdateTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFReset);
            this.Controls.Add(this.btnFRecord);
            this.Controls.Add(this.FDestCB);
            this.Controls.Add(this.FSrcCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FcabTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FcodeTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FlightTbl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlightTbl";
            this.Load += new System.EventHandler(this.FlightTbl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FcodeTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FcabTb;
        private System.Windows.Forms.ComboBox FSrcCB;
        private System.Windows.Forms.ComboBox FDestCB;
        private System.Windows.Forms.Button btnFReset;
        private System.Windows.Forms.Button btnFRecord;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker FdateTb;
        private System.Windows.Forms.Button btnVflight;
        private System.Windows.Forms.Button btnBack;
    }
}