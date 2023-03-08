namespace Hotel_App
{
    partial class Owner_Kamar
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
            this.dgv_Kamar = new System.Windows.Forms.DataGridView();
            this.txt_TIpe = new System.Windows.Forms.TextBox();
            this.btn_Batal = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kamar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Kamar";
            // 
            // dgv_Kamar
            // 
            this.dgv_Kamar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Kamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Kamar.Location = new System.Drawing.Point(33, 174);
            this.dgv_Kamar.Name = "dgv_Kamar";
            this.dgv_Kamar.RowHeadersWidth = 62;
            this.dgv_Kamar.RowTemplate.Height = 28;
            this.dgv_Kamar.Size = new System.Drawing.Size(881, 318);
            this.dgv_Kamar.TabIndex = 1;
            // 
            // txt_TIpe
            // 
            this.txt_TIpe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TIpe.Location = new System.Drawing.Point(683, 65);
            this.txt_TIpe.Name = "txt_TIpe";
            this.txt_TIpe.Size = new System.Drawing.Size(231, 26);
            this.txt_TIpe.TabIndex = 2;
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
            this.btn_Batal.Location = new System.Drawing.Point(778, 103);
            this.btn_Batal.Name = "btn_Batal";
            this.btn_Batal.Size = new System.Drawing.Size(64, 60);
            this.btn_Batal.TabIndex = 19;
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
            this.btn_Search.Location = new System.Drawing.Point(853, 103);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(61, 60);
            this.btn_Search.TabIndex = 18;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tipe Kamar:";
            // 
            // Owner_Kamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 520);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Batal);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_TIpe);
            this.Controls.Add(this.dgv_Kamar);
            this.Controls.Add(this.label1);
            this.Name = "Owner_Kamar";
            this.Text = "Owner_Kamar";
            this.Load += new System.EventHandler(this.Owner_Kamar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kamar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Kamar;
        private System.Windows.Forms.TextBox txt_TIpe;
        private System.Windows.Forms.Button btn_Batal;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label2;
    }
}