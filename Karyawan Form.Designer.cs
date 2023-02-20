namespace Hotel_App
{
    partial class Karyawan_Form
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
            this.txt_Nama = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.dgv_Karyawan = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Karyawan)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Nama
            // 
            this.txt_Nama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Nama.Location = new System.Drawing.Point(32, 134);
            this.txt_Nama.Name = "txt_Nama";
            this.txt_Nama.Size = new System.Drawing.Size(284, 26);
            this.txt_Nama.TabIndex = 0;
            // 
            // txt_Username
            // 
            this.txt_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Username.Location = new System.Drawing.Point(32, 212);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(284, 26);
            this.txt_Username.TabIndex = 2;
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Password.Location = new System.Drawing.Point(32, 290);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(284, 26);
            this.txt_Password.TabIndex = 3;
            // 
            // dgv_Karyawan
            // 
            this.dgv_Karyawan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Karyawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Karyawan.Location = new System.Drawing.Point(471, 108);
            this.dgv_Karyawan.Name = "dgv_Karyawan";
            this.dgv_Karyawan.RowHeadersWidth = 62;
            this.dgv_Karyawan.RowTemplate.Height = 28;
            this.dgv_Karyawan.Size = new System.Drawing.Size(383, 377);
            this.dgv_Karyawan.TabIndex = 5;
            this.dgv_Karyawan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Karyawan_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Delete.Image = global::Hotel_App.Properties.Resources.delete;
            this.btn_Delete.Location = new System.Drawing.Point(300, 420);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(136, 55);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "   Hapus";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Update.Image = global::Hotel_App.Properties.Resources.edit;
            this.btn_Update.Location = new System.Drawing.Point(158, 420);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(136, 55);
            this.btn_Update.TabIndex = 7;
            this.btn_Update.Text = "   Ubah";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Insert.FlatAppearance.BorderSize = 0;
            this.btn_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Insert.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Insert.Image = global::Hotel_App.Properties.Resources.add;
            this.btn_Insert.Location = new System.Drawing.Point(16, 420);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(136, 55);
            this.btn_Insert.TabIndex = 6;
            this.btn_Insert.Text = "   Tambah";
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Insert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Insert.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::Hotel_App.Properties.Resources.employee;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "         Data Karyawan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Karyawan_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 523);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.dgv_Karyawan);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nama);
            this.Name = "Karyawan_Form";
            this.Text = "Karyawan_Form";
            this.Load += new System.EventHandler(this.Karyawan_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Karyawan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.DataGridView dgv_Karyawan;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}