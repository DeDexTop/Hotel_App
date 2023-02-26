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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.chart_Report = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Generate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Report)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laporan Pemasukan";
            // 
            // chart_Report
            // 
            this.chart_Report.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea2.Name = "ChartArea1";
            this.chart_Report.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_Report.Legends.Add(legend2);
            this.chart_Report.Location = new System.Drawing.Point(64, 157);
            this.chart_Report.Name = "chart_Report";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Pemasukan";
            this.chart_Report.Series.Add(series2);
            this.chart_Report.Size = new System.Drawing.Size(653, 334);
            this.chart_Report.TabIndex = 1;
            this.chart_Report.Text = "chart1";
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
            this.btn_Print.Location = new System.Drawing.Point(746, 250);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(155, 55);
            this.btn_Print.TabIndex = 12;
            this.btn_Print.Text = "   Print";
            this.btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Print.UseVisualStyleBackColor = false;
            // 
            // btn_Generate
            // 
            this.btn_Generate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Generate.FlatAppearance.BorderSize = 0;
            this.btn_Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Generate.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Generate.Image = global::Hotel_App.Properties.Resources.settings;
            this.btn_Generate.Location = new System.Drawing.Point(746, 157);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(155, 55);
            this.btn_Generate.TabIndex = 11;
            this.btn_Generate.Text = "   Generate";
            this.btn_Generate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Generate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Generate.UseVisualStyleBackColor = false;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // Report_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 516);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.chart_Report);
            this.Controls.Add(this.label1);
            this.Name = "Report_Form";
            this.Text = "Report_Form";
            ((System.ComponentModel.ISupportInitialize)(this.chart_Report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Report;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Button btn_Print;
    }
}