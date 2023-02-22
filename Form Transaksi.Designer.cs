namespace Hotel_App
{
    partial class Form_Transaksi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nama = new System.Windows.Forms.TextBox();
            this.dt_Checkin = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Hari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_Tipe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Uang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pb_Gambar = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Simpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Gambar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaksi";
            // 
            // txt_Nama
            // 
            this.txt_Nama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Nama.Location = new System.Drawing.Point(18, 131);
            this.txt_Nama.Name = "txt_Nama";
            this.txt_Nama.Size = new System.Drawing.Size(235, 26);
            this.txt_Nama.TabIndex = 1;
            // 
            // dt_Checkin
            // 
            this.dt_Checkin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_Checkin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_Checkin.Location = new System.Drawing.Point(18, 199);
            this.dt_Checkin.Name = "dt_Checkin";
            this.dt_Checkin.Size = new System.Drawing.Size(235, 26);
            this.dt_Checkin.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(516, 198);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_Hari
            // 
            this.txt_Hari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Hari.Location = new System.Drawing.Point(325, 199);
            this.txt_Hari.Name = "txt_Hari";
            this.txt_Hari.Size = new System.Drawing.Size(90, 26);
            this.txt_Hari.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hari";
            // 
            // cbx_Tipe
            // 
            this.cbx_Tipe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_Tipe.FormattingEnabled = true;
            this.cbx_Tipe.Location = new System.Drawing.Point(325, 129);
            this.cbx_Tipe.Name = "cbx_Tipe";
            this.cbx_Tipe.Size = new System.Drawing.Size(203, 28);
            this.cbx_Tipe.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nama Pelanggan";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tanggal Check In";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "TIpe Kamar";
            // 
            // txt_Uang
            // 
            this.txt_Uang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Uang.Location = new System.Drawing.Point(18, 269);
            this.txt_Uang.Name = "txt_Uang";
            this.txt_Uang.Size = new System.Drawing.Size(240, 26);
            this.txt_Uang.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Kembalian: Rp";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Uang Masuk";
            // 
            // pb_Gambar
            // 
            this.pb_Gambar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_Gambar.Location = new System.Drawing.Point(643, 48);
            this.pb_Gambar.Name = "pb_Gambar";
            this.pb_Gambar.Size = new System.Drawing.Size(188, 188);
            this.pb_Gambar.TabIndex = 13;
            this.pb_Gambar.TabStop = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Image = global::Hotel_App.Properties.Resources.add;
            this.button3.Location = new System.Drawing.Point(543, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 43);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btn_Print
            // 
            this.btn_Print.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Print.FlatAppearance.BorderSize = 0;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Print.Image = global::Hotel_App.Properties.Resources.printer__1_;
            this.btn_Print.Location = new System.Drawing.Point(656, 442);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(171, 69);
            this.btn_Print.TabIndex = 11;
            this.btn_Print.Text = "  Print";
            this.btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Print.UseVisualStyleBackColor = false;
            // 
            // btn_Simpan
            // 
            this.btn_Simpan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Simpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Simpan.FlatAppearance.BorderSize = 0;
            this.btn_Simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Simpan.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Simpan.Image = global::Hotel_App.Properties.Resources.bank__1_;
            this.btn_Simpan.Location = new System.Drawing.Point(656, 313);
            this.btn_Simpan.Name = "btn_Simpan";
            this.btn_Simpan.Size = new System.Drawing.Size(171, 69);
            this.btn_Simpan.TabIndex = 10;
            this.btn_Simpan.Text = "  Simpan";
            this.btn_Simpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Simpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Simpan.UseVisualStyleBackColor = false;
            // 
            // Form_Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 523);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Uang);
            this.Controls.Add(this.pb_Gambar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Simpan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_Tipe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Hari);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dt_Checkin);
            this.Controls.Add(this.txt_Nama);
            this.Controls.Add(this.label1);
            this.Name = "Form_Transaksi";
            this.Text = "Form_Transaksi";
            this.Load += new System.EventHandler(this.Form_Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Gambar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nama;
        private System.Windows.Forms.DateTimePicker dt_Checkin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Hari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Tipe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Simpan;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pb_Gambar;
        private System.Windows.Forms.TextBox txt_Uang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}