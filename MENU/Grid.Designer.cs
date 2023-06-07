namespace MENU
{
    partial class Grid
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nokamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeniskamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargakamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kamarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet1 = new MENU.HotelDataSet1();
            this.karyawanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new MENU.HotelDataSet();
            this.karyawanTableAdapter = new MENU.HotelDataSetTableAdapters.karyawanTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.kamarTableAdapter = new MENU.HotelDataSet1TableAdapters.kamarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nokamarDataGridViewTextBoxColumn,
            this.jeniskamarDataGridViewTextBoxColumn,
            this.hargakamarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kamarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(123, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(854, 610);
            this.dataGridView1.TabIndex = 0;
            // 
            // nokamarDataGridViewTextBoxColumn
            // 
            this.nokamarDataGridViewTextBoxColumn.DataPropertyName = "no_kamar";
            this.nokamarDataGridViewTextBoxColumn.HeaderText = "no_kamar";
            this.nokamarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nokamarDataGridViewTextBoxColumn.Name = "nokamarDataGridViewTextBoxColumn";
            this.nokamarDataGridViewTextBoxColumn.Width = 150;
            // 
            // jeniskamarDataGridViewTextBoxColumn
            // 
            this.jeniskamarDataGridViewTextBoxColumn.DataPropertyName = "jenis_kamar";
            this.jeniskamarDataGridViewTextBoxColumn.HeaderText = "jenis_kamar";
            this.jeniskamarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jeniskamarDataGridViewTextBoxColumn.Name = "jeniskamarDataGridViewTextBoxColumn";
            this.jeniskamarDataGridViewTextBoxColumn.Width = 150;
            // 
            // hargakamarDataGridViewTextBoxColumn
            // 
            this.hargakamarDataGridViewTextBoxColumn.DataPropertyName = "harga_kamar";
            this.hargakamarDataGridViewTextBoxColumn.HeaderText = "harga_kamar";
            this.hargakamarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hargakamarDataGridViewTextBoxColumn.Name = "hargakamarDataGridViewTextBoxColumn";
            this.hargakamarDataGridViewTextBoxColumn.Width = 150;
            // 
            // kamarBindingSource
            // 
            this.kamarBindingSource.DataMember = "kamar";
            this.kamarBindingSource.DataSource = this.hotelDataSet1BindingSource;
            // 
            // hotelDataSet1BindingSource
            // 
            this.hotelDataSet1BindingSource.DataSource = this.hotelDataSet1;
            this.hotelDataSet1BindingSource.Position = 0;
            // 
            // hotelDataSet1
            // 
            this.hotelDataSet1.DataSetName = "HotelDataSet1";
            this.hotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // karyawanBindingSource
            // 
            this.karyawanBindingSource.DataMember = "karyawan";
            this.karyawanBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // karyawanTableAdapter
            // 
            this.karyawanTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 59);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Grid";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kamarTableAdapter
            // 
            this.kamarTableAdapter.ClearBeforeFill = true;
            // 
            // Grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 861);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Grid";
            this.Text = "Grid";
            this.Load += new System.EventHandler(this.Grid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource karyawanBindingSource;
        private HotelDataSetTableAdapters.karyawanTableAdapter karyawanTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource hotelDataSet1BindingSource;
        private HotelDataSet1 hotelDataSet1;
        private System.Windows.Forms.BindingSource kamarBindingSource;
        private HotelDataSet1TableAdapters.kamarTableAdapter kamarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nokamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeniskamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargakamarDataGridViewTextBoxColumn;
    }
}