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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Log)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catatan Aktivitas";
            // 
            // dgv_Log
            // 
            this.dgv_Log.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Log.Location = new System.Drawing.Point(12, 157);
            this.dgv_Log.Name = "dgv_Log";
            this.dgv_Log.RowHeadersWidth = 62;
            this.dgv_Log.RowTemplate.Height = 28;
            this.dgv_Log.Size = new System.Drawing.Size(842, 354);
            this.dgv_Log.TabIndex = 0;
            // 
            // Log_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 523);
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
    }
}