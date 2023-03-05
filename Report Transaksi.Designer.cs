namespace Hotel_App
{
    partial class Report_Transaksi
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
            this.dgv_Transaksi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Batal = new System.Windows.Forms.Button();
            this.dt_Tanggal2 = new System.Windows.Forms.DateTimePicker();
            this.dt_Tanggal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laporan Transaksi";
            // 
            // dgv_Transaksi
            // 
            this.dgv_Transaksi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Transaksi.Location = new System.Drawing.Point(44, 212);
            this.dgv_Transaksi.Name = "dgv_Transaksi";
            this.dgv_Transaksi.RowHeadersWidth = 62;
            this.dgv_Transaksi.RowTemplate.Height = 28;
            this.dgv_Transaksi.Size = new System.Drawing.Size(873, 277);
            this.dgv_Transaksi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Daftar Pelanggan";
            // 
            // txt_Search
            // 
            this.txt_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Search.Location = new System.Drawing.Point(678, 108);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(207, 26);
            this.txt_Search.TabIndex = 5;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Image = global::Hotel_App.Properties.Resources.magnifying_glass;
            this.btn_Search.Location = new System.Drawing.Point(824, 146);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(61, 60);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Batal
            // 
            this.btn_Batal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Batal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Batal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Batal.FlatAppearance.BorderSize = 0;
            this.btn_Batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Batal.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Batal.Image = global::Hotel_App.Properties.Resources.refresh;
            this.btn_Batal.Location = new System.Drawing.Point(749, 146);
            this.btn_Batal.Name = "btn_Batal";
            this.btn_Batal.Size = new System.Drawing.Size(64, 60);
            this.btn_Batal.TabIndex = 17;
            this.btn_Batal.UseVisualStyleBackColor = false;
            this.btn_Batal.Click += new System.EventHandler(this.btn_Batal_Click);
            // 
            // dt_Tanggal2
            // 
            this.dt_Tanggal2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_Tanggal2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_Tanggal2.Location = new System.Drawing.Point(678, 47);
            this.dt_Tanggal2.Name = "dt_Tanggal2";
            this.dt_Tanggal2.Size = new System.Drawing.Size(207, 26);
            this.dt_Tanggal2.TabIndex = 19;
            // 
            // dt_Tanggal
            // 
            this.dt_Tanggal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_Tanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_Tanggal.Location = new System.Drawing.Point(438, 47);
            this.dt_Tanggal.Name = "dt_Tanggal";
            this.dt_Tanggal.Size = new System.Drawing.Size(207, 26);
            this.dt_Tanggal.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Dari:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(674, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ke:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nama:";
            // 
            // btn_Print
            // 
            this.btn_Print.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Print.FlatAppearance.BorderSize = 0;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Print.Image = global::Hotel_App.Properties.Resources.printer__1_;
            this.btn_Print.Location = new System.Drawing.Point(589, 146);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(140, 60);
            this.btn_Print.TabIndex = 24;
            this.btn_Print.Text = "  Print";
            this.btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // Report_Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 516);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dt_Tanggal);
            this.Controls.Add(this.dt_Tanggal2);
            this.Controls.Add(this.btn_Batal);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Transaksi);
            this.Controls.Add(this.label1);
            this.Name = "Report_Transaksi";
            this.Text = "Report_Transaksi";
            this.Load += new System.EventHandler(this.Report_Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Transaksi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Batal;
        private System.Windows.Forms.DateTimePicker dt_Tanggal2;
        private System.Windows.Forms.DateTimePicker dt_Tanggal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Print;
    }
}