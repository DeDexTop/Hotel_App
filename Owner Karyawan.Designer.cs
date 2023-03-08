namespace Hotel_App
{
    partial class Owner_Karyawan
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nama = new System.Windows.Forms.TextBox();
            this.dgv_Karyawan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Batal = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Karyawan)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nama :";
            // 
            // txt_Nama
            // 
            this.txt_Nama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Nama.Location = new System.Drawing.Point(691, 62);
            this.txt_Nama.Name = "txt_Nama";
            this.txt_Nama.Size = new System.Drawing.Size(231, 26);
            this.txt_Nama.TabIndex = 23;
            // 
            // dgv_Karyawan
            // 
            this.dgv_Karyawan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Karyawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Karyawan.Location = new System.Drawing.Point(41, 171);
            this.dgv_Karyawan.Name = "dgv_Karyawan";
            this.dgv_Karyawan.RowHeadersWidth = 62;
            this.dgv_Karyawan.RowTemplate.Height = 28;
            this.dgv_Karyawan.Size = new System.Drawing.Size(881, 318);
            this.dgv_Karyawan.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 36);
            this.label1.TabIndex = 21;
            this.label1.Text = "Data Karyawan";
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
            this.btn_Batal.Location = new System.Drawing.Point(786, 100);
            this.btn_Batal.Name = "btn_Batal";
            this.btn_Batal.Size = new System.Drawing.Size(64, 60);
            this.btn_Batal.TabIndex = 25;
            this.btn_Batal.UseVisualStyleBackColor = false;
            this.btn_Batal.Click += new System.EventHandler(this.btn_Batal_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Image = global::Hotel_App.Properties.Resources.magnifying_glass;
            this.btn_Search.Location = new System.Drawing.Point(861, 100);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(61, 60);
            this.btn_Search.TabIndex = 24;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Owner_Karyawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 520);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Batal);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Nama);
            this.Controls.Add(this.dgv_Karyawan);
            this.Controls.Add(this.label1);
            this.Name = "Owner_Karyawan";
            this.Text = "Owner_Karyawan";
            this.Load += new System.EventHandler(this.Owner_Karyawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Karyawan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Batal;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Nama;
        private System.Windows.Forms.DataGridView dgv_Karyawan;
        private System.Windows.Forms.Label label1;
    }
}