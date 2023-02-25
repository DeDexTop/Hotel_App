namespace Hotel_App
{
    partial class Log_Form
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
            this.dgv_Log = new System.Windows.Forms.DataGridView();
            this.label_Data = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Input = new System.Windows.Forms.Button();
            this.btn_Transaksi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Log)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catatan Aktivitas";
            // 
            // dgv_Log
            // 
            this.dgv_Log.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Log.Location = new System.Drawing.Point(12, 238);
            this.dgv_Log.Name = "dgv_Log";
            this.dgv_Log.RowHeadersWidth = 62;
            this.dgv_Log.RowTemplate.Height = 28;
            this.dgv_Log.Size = new System.Drawing.Size(932, 270);
            this.dgv_Log.TabIndex = 0;
            // 
            // label_Data
            // 
            this.label_Data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Data.AutoSize = true;
            this.label_Data.Location = new System.Drawing.Point(28, 201);
            this.label_Data.Name = "label_Data";
            this.label_Data.Size = new System.Drawing.Size(48, 20);
            this.label_Data.TabIndex = 5;
            this.label_Data.Text = "Data:";
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Login.Image = global::Hotel_App.Properties.Resources.files1;
            this.btn_Login.Location = new System.Drawing.Point(657, 124);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(150, 56);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "   Log";
            this.btn_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Input
            // 
            this.btn_Input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Input.FlatAppearance.BorderSize = 0;
            this.btn_Input.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Input.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Input.Image = global::Hotel_App.Properties.Resources.input;
            this.btn_Input.Location = new System.Drawing.Point(409, 124);
            this.btn_Input.Name = "btn_Input";
            this.btn_Input.Size = new System.Drawing.Size(167, 56);
            this.btn_Input.TabIndex = 3;
            this.btn_Input.Text = "  Input Data";
            this.btn_Input.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Input.UseVisualStyleBackColor = false;
            this.btn_Input.Click += new System.EventHandler(this.btn_Input_Click);
            // 
            // btn_Transaksi
            // 
            this.btn_Transaksi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Transaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Transaksi.FlatAppearance.BorderSize = 0;
            this.btn_Transaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Transaksi.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Transaksi.Image = global::Hotel_App.Properties.Resources.transaction;
            this.btn_Transaksi.Location = new System.Drawing.Point(165, 124);
            this.btn_Transaksi.Name = "btn_Transaksi";
            this.btn_Transaksi.Size = new System.Drawing.Size(150, 56);
            this.btn_Transaksi.TabIndex = 2;
            this.btn_Transaksi.Text = "  Transaksi";
            this.btn_Transaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Transaksi.UseVisualStyleBackColor = false;
            this.btn_Transaksi.Click += new System.EventHandler(this.btn_Transaksi_Click);
            // 
            // Log_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 516);
            this.Controls.Add(this.label_Data);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_Input);
            this.Controls.Add(this.btn_Transaksi);
            this.Controls.Add(this.dgv_Log);
            this.Controls.Add(this.label1);
            this.Name = "Log_Form";
            this.Text = "Log_Form";
            this.Load += new System.EventHandler(this.Log_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Log)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Log;
        private System.Windows.Forms.Button btn_Transaksi;
        private System.Windows.Forms.Button btn_Input;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label_Data;
    }
}