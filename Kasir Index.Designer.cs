namespace Hotel_App
{
    partial class Kasir_Index
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
            this.dgv_transaksi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.dgv_Detail = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.btn_Batal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selamat Datang ";
            // 
            // dgv_transaksi
            // 
            this.dgv_transaksi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transaksi.Location = new System.Drawing.Point(12, 236);
            this.dgv_transaksi.Name = "dgv_transaksi";
            this.dgv_transaksi.RowHeadersWidth = 62;
            this.dgv_transaksi.RowTemplate.Height = 28;
            this.dgv_transaksi.Size = new System.Drawing.Size(613, 247);
            this.dgv_transaksi.TabIndex = 1;
            this.dgv_transaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_transaksi_CellClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Transaksi";
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Image = global::Hotel_App.Properties.Resources.magnifying_glass;
            this.btn_Search.Location = new System.Drawing.Point(993, 182);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(51, 45);
            this.btn_Search.TabIndex = 20;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Search.Location = new System.Drawing.Point(795, 191);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(192, 26);
            this.txt_Search.TabIndex = 19;
            // 
            // dgv_Detail
            // 
            this.dgv_Detail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Detail.Location = new System.Drawing.Point(666, 236);
            this.dgv_Detail.Name = "dgv_Detail";
            this.dgv_Detail.RowHeadersWidth = 62;
            this.dgv_Detail.RowTemplate.Height = 28;
            this.dgv_Detail.Size = new System.Drawing.Size(378, 247);
            this.dgv_Detail.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(666, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Detail :";
            // 
            // txt_Id
            // 
            this.txt_Id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Id.Location = new System.Drawing.Point(962, 12);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(82, 26);
            this.txt_Id.TabIndex = 23;
            this.txt_Id.Visible = false;
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
            this.btn_Batal.Location = new System.Drawing.Point(993, 128);
            this.btn_Batal.Name = "btn_Batal";
            this.btn_Batal.Size = new System.Drawing.Size(51, 48);
            this.btn_Batal.TabIndex = 24;
            this.btn_Batal.UseVisualStyleBackColor = false;
            this.btn_Batal.Click += new System.EventHandler(this.btn_Batal_Click);
            // 
            // Kasir_Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 514);
            this.Controls.Add(this.btn_Batal);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_Detail);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_transaksi);
            this.Controls.Add(this.label1);
            this.Name = "Kasir_Index";
            this.Text = "Kasir_Index";
            this.Load += new System.EventHandler(this.Kasir_Index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_transaksi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.DataGridView dgv_Detail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Button btn_Batal;
    }
}