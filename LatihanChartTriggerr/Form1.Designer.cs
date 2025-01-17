
namespace LatihanChartTriggerr
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new LatihanChartTriggerr.Database1DataSet();
            this.janFebBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.janFebTableAdapter = new LatihanChartTriggerr.Database1DataSetTableAdapters.JanFebTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahun2020DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahun2021DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahun2022DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahun2023DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.janFebBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(37, 258);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Tahun 2020";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Tahun 2021";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Tahun 2022";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Tahun 2023";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(804, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.merkDataGridViewTextBoxColumn,
            this.tahun2020DataGridViewTextBoxColumn,
            this.tahun2021DataGridViewTextBoxColumn,
            this.tahun2022DataGridViewTextBoxColumn,
            this.tahun2023DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.janFebBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // janFebBindingSource
            // 
            this.janFebBindingSource.DataMember = "JanFeb";
            this.janFebBindingSource.DataSource = this.database1DataSet;
            // 
            // janFebTableAdapter
            // 
            this.janFebTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // merkDataGridViewTextBoxColumn
            // 
            this.merkDataGridViewTextBoxColumn.DataPropertyName = "Merk";
            this.merkDataGridViewTextBoxColumn.HeaderText = "Merk";
            this.merkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.merkDataGridViewTextBoxColumn.Name = "merkDataGridViewTextBoxColumn";
            this.merkDataGridViewTextBoxColumn.Width = 125;
            // 
            // tahun2020DataGridViewTextBoxColumn
            // 
            this.tahun2020DataGridViewTextBoxColumn.DataPropertyName = "Tahun2020";
            this.tahun2020DataGridViewTextBoxColumn.HeaderText = "Tahun2020";
            this.tahun2020DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tahun2020DataGridViewTextBoxColumn.Name = "tahun2020DataGridViewTextBoxColumn";
            this.tahun2020DataGridViewTextBoxColumn.Width = 125;
            // 
            // tahun2021DataGridViewTextBoxColumn
            // 
            this.tahun2021DataGridViewTextBoxColumn.DataPropertyName = "Tahun2021";
            this.tahun2021DataGridViewTextBoxColumn.HeaderText = "Tahun2021";
            this.tahun2021DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tahun2021DataGridViewTextBoxColumn.Name = "tahun2021DataGridViewTextBoxColumn";
            this.tahun2021DataGridViewTextBoxColumn.Width = 125;
            // 
            // tahun2022DataGridViewTextBoxColumn
            // 
            this.tahun2022DataGridViewTextBoxColumn.DataPropertyName = "Tahun2022";
            this.tahun2022DataGridViewTextBoxColumn.HeaderText = "Tahun2022";
            this.tahun2022DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tahun2022DataGridViewTextBoxColumn.Name = "tahun2022DataGridViewTextBoxColumn";
            this.tahun2022DataGridViewTextBoxColumn.Width = 125;
            // 
            // tahun2023DataGridViewTextBoxColumn
            // 
            this.tahun2023DataGridViewTextBoxColumn.DataPropertyName = "Tahun2023";
            this.tahun2023DataGridViewTextBoxColumn.HeaderText = "Tahun2023";
            this.tahun2023DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tahun2023DataGridViewTextBoxColumn.Name = "tahun2023DataGridViewTextBoxColumn";
            this.tahun2023DataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 621);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.janFebBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource janFebBindingSource;
        private Database1DataSetTableAdapters.JanFebTableAdapter janFebTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahun2020DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahun2021DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahun2022DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahun2023DataGridViewTextBoxColumn;
    }
}

