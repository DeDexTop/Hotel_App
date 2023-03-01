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
            this.dgv_Detail = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Batal = new System.Windows.Forms.Button();
            this.txt_Id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laporan Transaksi";
            // 
            // dgv_Transaksi
            // 
            this.dgv_Transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Transaksi.Location = new System.Drawing.Point(44, 212);
            this.dgv_Transaksi.Name = "dgv_Transaksi";
            this.dgv_Transaksi.RowHeadersWidth = 62;
            this.dgv_Transaksi.RowTemplate.Height = 28;
            this.dgv_Transaksi.Size = new System.Drawing.Size(487, 277);
            this.dgv_Transaksi.TabIndex = 1;
            // 
            // dgv_Detail
            // 
            this.dgv_Detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Detail.Location = new System.Drawing.Point(576, 212);
            this.dgv_Detail.Name = "dgv_Detail";
            this.dgv_Detail.RowHeadersWidth = 62;
            this.dgv_Detail.RowTemplate.Height = 28;
            this.dgv_Detail.Size = new System.Drawing.Size(341, 277);
            this.dgv_Detail.TabIndex = 2;
            this.dgv_Detail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Detail_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Daftar Pelanggan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Detail";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(653, 44);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(207, 26);
            this.txt_Search.TabIndex = 5;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Image = global::Hotel_App.Properties.Resources.magnifying_glass;
            this.btn_Search.Location = new System.Drawing.Point(866, 35);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(51, 45);
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
            this.btn_Batal.Location = new System.Drawing.Point(866, 103);
            this.btn_Batal.Name = "btn_Batal";
            this.btn_Batal.Size = new System.Drawing.Size(51, 48);
            this.btn_Batal.TabIndex = 17;
            this.btn_Batal.UseVisualStyleBackColor = false;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(12, 39);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(50, 26);
            this.txt_Id.TabIndex = 18;
            this.txt_Id.Visible = false;
            // 
            // Report_Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 516);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.btn_Batal);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Detail);
            this.Controls.Add(this.dgv_Transaksi);
            this.Controls.Add(this.label1);
            this.Name = "Report_Transaksi";
            this.Text = "Report_Transaksi";
            this.Load += new System.EventHandler(this.Report_Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Transaksi;
        private System.Windows.Forms.DataGridView dgv_Detail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Batal;
        private System.Windows.Forms.TextBox txt_Id;
    }
}