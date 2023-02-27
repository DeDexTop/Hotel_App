namespace Hotel_App
{
    partial class Owner_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owner_Form));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btn_Transaksi = new System.Windows.Forms.Button();
            this.btnKamar = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelDesktop.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.label4);
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(244, 82);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(978, 576);
            this.panelDesktop.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(285, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(439, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Selamat Datang Owner name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(434, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Owner";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitleBar.Controls.Add(this.btn_Logout);
            this.panelTitleBar.Controls.Add(this.btnOpen);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(244, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(978, 82);
            this.panelTitleBar.TabIndex = 7;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.buttonClose);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(244, 82);
            this.panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(92, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "MENU";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btn_Transaksi);
            this.panelMenu.Controls.Add(this.btnKamar);
            this.panelMenu.Controls.Add(this.btnLog);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(244, 658);
            this.panelMenu.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Image = global::Hotel_App.Properties.Resources.ceo__1_;
            this.label4.Location = new System.Drawing.Point(336, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 275);
            this.label4.TabIndex = 1;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Logout.Image = global::Hotel_App.Properties.Resources.logout;
            this.btn_Logout.Location = new System.Drawing.Point(807, 0);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(171, 82);
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.Text = "   Log Out";
            this.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.Location = new System.Drawing.Point(23, 15);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(62, 48);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btn_Transaksi
            // 
            this.btn_Transaksi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Transaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Transaksi.FlatAppearance.BorderSize = 0;
            this.btn_Transaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Transaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Transaksi.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Transaksi.Image = global::Hotel_App.Properties.Resources.fees;
            this.btn_Transaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Transaksi.Location = new System.Drawing.Point(0, 202);
            this.btn_Transaksi.Name = "btn_Transaksi";
            this.btn_Transaksi.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Transaksi.Size = new System.Drawing.Size(244, 60);
            this.btn_Transaksi.TabIndex = 4;
            this.btn_Transaksi.Text = "   Transaksi";
            this.btn_Transaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Transaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Transaksi.UseVisualStyleBackColor = true;
            this.btn_Transaksi.Click += new System.EventHandler(this.btn_Transaksi_Click);
            // 
            // btnKamar
            // 
            this.btnKamar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKamar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKamar.FlatAppearance.BorderSize = 0;
            this.btnKamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKamar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKamar.Image = global::Hotel_App.Properties.Resources.chart_histogram_free_icon_font;
            this.btnKamar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKamar.Location = new System.Drawing.Point(0, 142);
            this.btnKamar.Name = "btnKamar";
            this.btnKamar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnKamar.Size = new System.Drawing.Size(244, 60);
            this.btnKamar.TabIndex = 3;
            this.btnKamar.Text = "   Pemasukan";
            this.btnKamar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKamar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKamar.UseVisualStyleBackColor = true;
            this.btnKamar.Click += new System.EventHandler(this.btnKamar_Click);
            // 
            // btnLog
            // 
            this.btnLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLog.FlatAppearance.BorderSize = 0;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLog.Image = global::Hotel_App.Properties.Resources.files;
            this.btnLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLog.Location = new System.Drawing.Point(0, 82);
            this.btnLog.Name = "btnLog";
            this.btnLog.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLog.Size = new System.Drawing.Size(244, 60);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "   Aktifitas";
            this.btnLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(12, 15);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(52, 48);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Owner_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 658);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.MinimumSize = new System.Drawing.Size(1150, 680);
            this.Name = "Owner_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owner Form";
            this.Load += new System.EventHandler(this.Owner_Form_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnKamar;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btn_Transaksi;
    }
}