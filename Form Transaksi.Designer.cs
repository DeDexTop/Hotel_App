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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Transaksi));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nama = new System.Windows.Forms.TextBox();
            this.dt_Checkin = new System.Windows.Forms.DateTimePicker();
            this.dgv_Kamar = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banyak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Hari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_Tipe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Uang = new System.Windows.Forms.TextBox();
            this.label_Kembalian = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.txt_Jumlah = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Bayar = new System.Windows.Forms.Button();
            this.pb_Gambar = new System.Windows.Forms.PictureBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Simpan = new System.Windows.Forms.Button();
            this.btn_Buang = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kamar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Gambar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaksi";
            // 
            // txt_Nama
            // 
            this.txt_Nama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Nama.Location = new System.Drawing.Point(25, 127);
            this.txt_Nama.Name = "txt_Nama";
            this.txt_Nama.Size = new System.Drawing.Size(235, 26);
            this.txt_Nama.TabIndex = 1;
            // 
            // dt_Checkin
            // 
            this.dt_Checkin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_Checkin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_Checkin.Location = new System.Drawing.Point(25, 222);
            this.dt_Checkin.Name = "dt_Checkin";
            this.dt_Checkin.Size = new System.Drawing.Size(235, 26);
            this.dt_Checkin.TabIndex = 2;
            this.dt_Checkin.Value = new System.DateTime(2023, 1, 1, 8, 25, 0, 0);
            // 
            // dgv_Kamar
            // 
            this.dgv_Kamar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Kamar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Kamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Kamar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Tipe,
            this.Column2,
            this.Banyak,
            this.Column4,
            this.Column3,
            this.Column1});
            this.dgv_Kamar.Location = new System.Drawing.Point(12, 304);
            this.dgv_Kamar.Name = "dgv_Kamar";
            this.dgv_Kamar.RowHeadersWidth = 62;
            this.dgv_Kamar.RowTemplate.Height = 28;
            this.dgv_Kamar.Size = new System.Drawing.Size(628, 198);
            this.dgv_Kamar.TabIndex = 3;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Id";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Tipe
            // 
            this.Tipe.HeaderText = "Tipe Kamar";
            this.Tipe.MinimumWidth = 8;
            this.Tipe.Name = "Tipe";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Harga";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Banyak
            // 
            this.Banyak.HeaderText = "Jumlah Kamar";
            this.Banyak.MinimumWidth = 8;
            this.Banyak.Name = "Banyak";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Check In";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Hari";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Total";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // txt_Hari
            // 
            this.txt_Hari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Hari.Location = new System.Drawing.Point(469, 221);
            this.txt_Hari.Name = "txt_Hari";
            this.txt_Hari.Size = new System.Drawing.Size(85, 26);
            this.txt_Hari.TabIndex = 4;
            this.txt_Hari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Hari_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hari";
            // 
            // cbx_Tipe
            // 
            this.cbx_Tipe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_Tipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Tipe.FormattingEnabled = true;
            this.cbx_Tipe.Location = new System.Drawing.Point(332, 125);
            this.cbx_Tipe.Name = "cbx_Tipe";
            this.cbx_Tipe.Size = new System.Drawing.Size(222, 28);
            this.cbx_Tipe.TabIndex = 6;
            this.cbx_Tipe.TextChanged += new System.EventHandler(this.cbx_Tipe_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nama Pelanggan";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tanggal Check In";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "TIpe Kamar";
            // 
            // txt_Uang
            // 
            this.txt_Uang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Uang.Location = new System.Drawing.Point(673, 330);
            this.txt_Uang.Name = "txt_Uang";
            this.txt_Uang.Size = new System.Drawing.Size(298, 26);
            this.txt_Uang.TabIndex = 14;
            this.txt_Uang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Uang_KeyDown);
            this.txt_Uang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Uang_KeyPress);
            // 
            // label_Kembalian
            // 
            this.label_Kembalian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Kembalian.AutoSize = true;
            this.label_Kembalian.Location = new System.Drawing.Point(839, 376);
            this.label_Kembalian.Name = "label_Kembalian";
            this.label_Kembalian.Size = new System.Drawing.Size(87, 20);
            this.label_Kembalian.TabIndex = 15;
            this.label_Kembalian.Text = "Kembalian:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(673, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Uang Masuk";
            // 
            // label_Total
            // 
            this.label_Total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(673, 376);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(48, 20);
            this.label_Total.TabIndex = 17;
            this.label_Total.Text = "Total:";
            // 
            // txt_Jumlah
            // 
            this.txt_Jumlah.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Jumlah.Location = new System.Drawing.Point(332, 221);
            this.txt_Jumlah.Name = "txt_Jumlah";
            this.txt_Jumlah.Size = new System.Drawing.Size(119, 26);
            this.txt_Jumlah.TabIndex = 18;
            this.txt_Jumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Jumlah_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Jumlah Kamar";
            // 
            // btn_Bayar
            // 
            this.btn_Bayar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Bayar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Bayar.FlatAppearance.BorderSize = 0;
            this.btn_Bayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bayar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Bayar.Image = global::Hotel_App.Properties.Resources.rupiah;
            this.btn_Bayar.Location = new System.Drawing.Point(982, 321);
            this.btn_Bayar.Name = "btn_Bayar";
            this.btn_Bayar.Size = new System.Drawing.Size(58, 48);
            this.btn_Bayar.TabIndex = 20;
            this.btn_Bayar.UseVisualStyleBackColor = false;
            this.btn_Bayar.Click += new System.EventHandler(this.btn_Bayar_Click);
            // 
            // pb_Gambar
            // 
            this.pb_Gambar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_Gambar.Location = new System.Drawing.Point(741, 55);
            this.pb_Gambar.Name = "pb_Gambar";
            this.pb_Gambar.Size = new System.Drawing.Size(243, 204);
            this.pb_Gambar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Gambar.TabIndex = 13;
            this.pb_Gambar.TabStop = false;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Add.Image = global::Hotel_App.Properties.Resources.add;
            this.btn_Add.Location = new System.Drawing.Point(582, 117);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(58, 48);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
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
            this.btn_Print.Location = new System.Drawing.Point(873, 433);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(171, 69);
            this.btn_Print.TabIndex = 11;
            this.btn_Print.Text = "  Print";
            this.btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
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
            this.btn_Simpan.Location = new System.Drawing.Point(673, 433);
            this.btn_Simpan.Name = "btn_Simpan";
            this.btn_Simpan.Size = new System.Drawing.Size(171, 69);
            this.btn_Simpan.TabIndex = 10;
            this.btn_Simpan.Text = "  Simpan";
            this.btn_Simpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Simpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Simpan.UseVisualStyleBackColor = false;
            this.btn_Simpan.Click += new System.EventHandler(this.btn_Simpan_Click);
            // 
            // btn_Buang
            // 
            this.btn_Buang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Buang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Buang.FlatAppearance.BorderSize = 0;
            this.btn_Buang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buang.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Buang.Image = global::Hotel_App.Properties.Resources.delete;
            this.btn_Buang.Location = new System.Drawing.Point(582, 210);
            this.btn_Buang.Name = "btn_Buang";
            this.btn_Buang.Size = new System.Drawing.Size(58, 48);
            this.btn_Buang.TabIndex = 21;
            this.btn_Buang.UseVisualStyleBackColor = false;
            this.btn_Buang.Click += new System.EventHandler(this.btn_Buang_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form_Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 514);
            this.Controls.Add(this.btn_Buang);
            this.Controls.Add(this.btn_Bayar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Jumlah);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_Kembalian);
            this.Controls.Add(this.txt_Uang);
            this.Controls.Add(this.pb_Gambar);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Simpan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_Tipe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Hari);
            this.Controls.Add(this.dgv_Kamar);
            this.Controls.Add(this.dt_Checkin);
            this.Controls.Add(this.txt_Nama);
            this.Controls.Add(this.label1);
            this.Name = "Form_Transaksi";
            this.Text = "Form_Transaksi";
            this.Load += new System.EventHandler(this.Form_Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kamar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Gambar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nama;
        private System.Windows.Forms.DateTimePicker dt_Checkin;
        private System.Windows.Forms.DataGridView dgv_Kamar;
        private System.Windows.Forms.TextBox txt_Hari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Tipe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Simpan;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.PictureBox pb_Gambar;
        private System.Windows.Forms.TextBox txt_Uang;
        private System.Windows.Forms.Label label_Kembalian;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.TextBox txt_Jumlah;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Bayar;
        private System.Windows.Forms.Button btn_Buang;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banyak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}