namespace Hotel_App
{
    partial class Kasir_Form
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
            this.panel_Judul = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Desktop = new System.Windows.Forms.Panel();
            this.btn_Kembali = new System.Windows.Forms.Button();
            this.btn_Tambah = new System.Windows.Forms.Button();
            this.panel_Judul.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Judul
            // 
            this.panel_Judul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel_Judul.Controls.Add(this.btn_Kembali);
            this.panel_Judul.Controls.Add(this.btn_Tambah);
            this.panel_Judul.Controls.Add(this.label1);
            this.panel_Judul.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Judul.Location = new System.Drawing.Point(0, 0);
            this.panel_Judul.Name = "panel_Judul";
            this.panel_Judul.Size = new System.Drawing.Size(1078, 84);
            this.panel_Judul.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(491, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasir";
            // 
            // panel_Desktop
            // 
            this.panel_Desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Desktop.Location = new System.Drawing.Point(0, 84);
            this.panel_Desktop.Name = "panel_Desktop";
            this.panel_Desktop.Size = new System.Drawing.Size(1078, 570);
            this.panel_Desktop.TabIndex = 1;
            // 
            // btn_Kembali
            // 
            this.btn_Kembali.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Kembali.FlatAppearance.BorderSize = 0;
            this.btn_Kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kembali.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Kembali.Image = global::Hotel_App.Properties.Resources.angle_left_free_icon_font;
            this.btn_Kembali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Kembali.Location = new System.Drawing.Point(0, 0);
            this.btn_Kembali.Name = "btn_Kembali";
            this.btn_Kembali.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Kembali.Size = new System.Drawing.Size(124, 84);
            this.btn_Kembali.TabIndex = 2;
            this.btn_Kembali.Text = "  Kembali";
            this.btn_Kembali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Kembali.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Kembali.UseVisualStyleBackColor = true;
            this.btn_Kembali.Visible = false;
            this.btn_Kembali.Click += new System.EventHandler(this.btn_Kembali_Click);
            // 
            // btn_Tambah
            // 
            this.btn_Tambah.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Tambah.FlatAppearance.BorderSize = 0;
            this.btn_Tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tambah.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Tambah.Image = global::Hotel_App.Properties.Resources.ticket;
            this.btn_Tambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Tambah.Location = new System.Drawing.Point(929, 0);
            this.btn_Tambah.Name = "btn_Tambah";
            this.btn_Tambah.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Tambah.Size = new System.Drawing.Size(149, 84);
            this.btn_Tambah.TabIndex = 1;
            this.btn_Tambah.Text = "    Tambah";
            this.btn_Tambah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Tambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Tambah.UseVisualStyleBackColor = true;
            this.btn_Tambah.Click += new System.EventHandler(this.btn_Tambah_Click);
            // 
            // Kasir_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 654);
            this.Controls.Add(this.panel_Desktop);
            this.Controls.Add(this.panel_Judul);
            this.Name = "Kasir_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasir_Form";
            this.Load += new System.EventHandler(this.Kasir_Form_Load);
            this.panel_Judul.ResumeLayout(false);
            this.panel_Judul.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Judul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Desktop;
        private System.Windows.Forms.Button btn_Kembali;
        private System.Windows.Forms.Button btn_Tambah;
    }
}