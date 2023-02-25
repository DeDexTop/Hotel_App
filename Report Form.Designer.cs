namespace Hotel_App
{
    partial class Report_Form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.chart_Report = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_Report = new System.Windows.Forms.DataGridView();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Bulan = new System.Windows.Forms.Button();
            this.btn_Hari = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Report)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laporan Pemasukan";
            // 
            // chart_Report
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Report.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Report.Legends.Add(legend1);
            this.chart_Report.Location = new System.Drawing.Point(12, 204);
            this.chart_Report.Name = "chart_Report";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_Report.Series.Add(series1);
            this.chart_Report.Size = new System.Drawing.Size(540, 300);
            this.chart_Report.TabIndex = 1;
            this.chart_Report.Text = "chart1";
            // 
            // dgv_Report
            // 
            this.dgv_Report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Report.Location = new System.Drawing.Point(595, 23);
            this.dgv_Report.Name = "dgv_Report";
            this.dgv_Report.RowHeadersWidth = 62;
            this.dgv_Report.RowTemplate.Height = 28;
            this.dgv_Report.Size = new System.Drawing.Size(349, 481);
            this.dgv_Report.TabIndex = 2;
            // 
            // btn_Print
            // 
            this.btn_Print.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Print.FlatAppearance.BorderSize = 0;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Print.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Print.Image = global::Hotel_App.Properties.Resources.printer__1_;
            this.btn_Print.Location = new System.Drawing.Point(416, 123);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(136, 55);
            this.btn_Print.TabIndex = 12;
            this.btn_Print.Text = "   Print";
            this.btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Print.UseVisualStyleBackColor = false;
            // 
            // btn_Bulan
            // 
            this.btn_Bulan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Bulan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Bulan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Bulan.FlatAppearance.BorderSize = 0;
            this.btn_Bulan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bulan.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Bulan.Image = global::Hotel_App.Properties.Resources.calendar;
            this.btn_Bulan.Location = new System.Drawing.Point(210, 123);
            this.btn_Bulan.Name = "btn_Bulan";
            this.btn_Bulan.Size = new System.Drawing.Size(136, 55);
            this.btn_Bulan.TabIndex = 11;
            this.btn_Bulan.Text = "   Bulan";
            this.btn_Bulan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Bulan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Bulan.UseVisualStyleBackColor = false;
            // 
            // btn_Hari
            // 
            this.btn_Hari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Hari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Hari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Hari.FlatAppearance.BorderSize = 0;
            this.btn_Hari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hari.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Hari.Image = global::Hotel_App.Properties.Resources.date;
            this.btn_Hari.Location = new System.Drawing.Point(12, 123);
            this.btn_Hari.Name = "btn_Hari";
            this.btn_Hari.Size = new System.Drawing.Size(136, 55);
            this.btn_Hari.TabIndex = 10;
            this.btn_Hari.Text = "   Hari";
            this.btn_Hari.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Hari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Hari.UseVisualStyleBackColor = false;
            // 
            // Report_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 516);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Bulan);
            this.Controls.Add(this.btn_Hari);
            this.Controls.Add(this.dgv_Report);
            this.Controls.Add(this.chart_Report);
            this.Controls.Add(this.label1);
            this.Name = "Report_Form";
            this.Text = "Report_Form";
            ((System.ComponentModel.ISupportInitialize)(this.chart_Report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Report;
        private System.Windows.Forms.DataGridView dgv_Report;
        private System.Windows.Forms.Button btn_Hari;
        private System.Windows.Forms.Button btn_Bulan;
        private System.Windows.Forms.Button btn_Print;
    }
}