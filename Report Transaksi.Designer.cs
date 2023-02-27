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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laporan Transaksi";
            // 
            // dgv_Transaksi
            // 
            this.dgv_Transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Transaksi.Location = new System.Drawing.Point(67, 193);
            this.dgv_Transaksi.Name = "dgv_Transaksi";
            this.dgv_Transaksi.RowHeadersWidth = 62;
            this.dgv_Transaksi.RowTemplate.Height = 28;
            this.dgv_Transaksi.Size = new System.Drawing.Size(812, 277);
            this.dgv_Transaksi.TabIndex = 1;
            // 
            // Report_Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 516);
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
    }
}