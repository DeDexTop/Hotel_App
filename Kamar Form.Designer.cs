namespace Hotel_App
{
    partial class Kamar_Form
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
            this.dgv_Kamar = new System.Windows.Forms.DataGridView();
            this.txt_Tipe = new System.Windows.Forms.TextBox();
            this.txt_Harga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Batal = new System.Windows.Forms.Button();
            this.btn_SearchImage = new System.Windows.Forms.Button();
            this.pb_Kamar = new System.Windows.Forms.PictureBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kamar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Kamar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Kamar
            // 
            this.dgv_Kamar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Kamar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Kamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Kamar.Location = new System.Drawing.Point(24, 343);
            this.dgv_Kamar.Name = "dgv_Kamar";
            this.dgv_Kamar.RowHeadersWidth = 62;
            this.dgv_Kamar.RowTemplate.Height = 28;
            this.dgv_Kamar.Size = new System.Drawing.Size(816, 168);
            this.dgv_Kamar.TabIndex = 0;
            this.dgv_Kamar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Kamar_CellDoubleClick);
            // 
            // txt_Tipe
            // 
            this.txt_Tipe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Tipe.Location = new System.Drawing.Point(24, 163);
            this.txt_Tipe.Name = "txt_Tipe";
            this.txt_Tipe.Size = new System.Drawing.Size(255, 26);
            this.txt_Tipe.TabIndex = 1;
            // 
            // txt_Harga
            // 
            this.txt_Harga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Harga.Location = new System.Drawing.Point(24, 243);
            this.txt_Harga.Name = "txt_Harga";
            this.txt_Harga.Size = new System.Drawing.Size(255, 26);
            this.txt_Harga.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipe Kamar";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Harga / Malam";
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
            this.btn_Batal.Location = new System.Drawing.Point(338, 186);
            this.btn_Batal.Name = "btn_Batal";
            this.btn_Batal.Size = new System.Drawing.Size(51, 48);
            this.btn_Batal.TabIndex = 16;
            this.btn_Batal.UseVisualStyleBackColor = false;
            this.btn_Batal.Click += new System.EventHandler(this.btn_Batal_Click);
            // 
            // btn_SearchImage
            // 
            this.btn_SearchImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SearchImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_SearchImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SearchImage.FlatAppearance.BorderSize = 0;
            this.btn_SearchImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchImage.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_SearchImage.Image = global::Hotel_App.Properties.Resources.image__1_;
            this.btn_SearchImage.Location = new System.Drawing.Point(336, 126);
            this.btn_SearchImage.Name = "btn_SearchImage";
            this.btn_SearchImage.Size = new System.Drawing.Size(53, 48);
            this.btn_SearchImage.TabIndex = 13;
            this.btn_SearchImage.UseVisualStyleBackColor = false;
            this.btn_SearchImage.Click += new System.EventHandler(this.btn_SearchImage_Click);
            // 
            // pb_Kamar
            // 
            this.pb_Kamar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_Kamar.Location = new System.Drawing.Point(415, 71);
            this.pb_Kamar.Name = "pb_Kamar";
            this.pb_Kamar.Size = new System.Drawing.Size(200, 186);
            this.pb_Kamar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Kamar.TabIndex = 12;
            this.pb_Kamar.TabStop = false;
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
            this.btn_Delete.Location = new System.Drawing.Point(704, 186);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(136, 55);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "   Hapus";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
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
            this.btn_Update.Location = new System.Drawing.Point(704, 112);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(136, 55);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "   Ubah";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
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
            this.btn_Insert.Location = new System.Drawing.Point(704, 40);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(136, 55);
            this.btn_Insert.TabIndex = 9;
            this.btn_Insert.Text = "   Tambah";
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Insert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::Hotel_App.Properties.Resources.bed__1_;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(52, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "            Data Tipe Kamar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Search
            // 
            this.txt_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Search.Location = new System.Drawing.Point(570, 291);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(192, 26);
            this.txt_Search.TabIndex = 17;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Image = global::Hotel_App.Properties.Resources.magnifying_glass;
            this.btn_Search.Location = new System.Drawing.Point(789, 280);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(51, 45);
            this.btn_Search.TabIndex = 18;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Kamar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 523);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Batal);
            this.Controls.Add(this.btn_SearchImage);
            this.Controls.Add(this.pb_Kamar);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Harga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Tipe);
            this.Controls.Add(this.dgv_Kamar);
            this.Name = "Kamar_Form";
            this.Text = "Kamar_Form";
            this.Load += new System.EventHandler(this.Kamar_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kamar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Kamar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Kamar;
        private System.Windows.Forms.TextBox txt_Tipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Harga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.PictureBox pb_Kamar;
        private System.Windows.Forms.Button btn_SearchImage;
        private System.Windows.Forms.Button btn_Batal;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
    }
}