namespace WindowsFormsApp3
{
    partial class alıcı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alıcı));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yaşDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.başlıkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hayvankayıtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hayvankayıtDataSet = new WindowsFormsApp3.hayvankayıtDataSet();
            this.hayvankayıtTableAdapter = new WindowsFormsApp3.hayvankayıtDataSetTableAdapters.hayvankayıtTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvankayıtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvankayıtDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kategoriDataGridViewTextBoxColumn,
            this.ilDataGridViewTextBoxColumn,
            this.yaşDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.başlıkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hayvankayıtBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1343, 736);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "kategori";
            this.kategoriDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            this.kategoriDataGridViewTextBoxColumn.Width = 150;
            // 
            // ilDataGridViewTextBoxColumn
            // 
            this.ilDataGridViewTextBoxColumn.DataPropertyName = "il";
            this.ilDataGridViewTextBoxColumn.HeaderText = "il";
            this.ilDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ilDataGridViewTextBoxColumn.Name = "ilDataGridViewTextBoxColumn";
            this.ilDataGridViewTextBoxColumn.Width = 150;
            // 
            // yaşDataGridViewTextBoxColumn
            // 
            this.yaşDataGridViewTextBoxColumn.DataPropertyName = "yaş";
            this.yaşDataGridViewTextBoxColumn.HeaderText = "yaş";
            this.yaşDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.yaşDataGridViewTextBoxColumn.Name = "yaşDataGridViewTextBoxColumn";
            this.yaşDataGridViewTextBoxColumn.Width = 150;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            this.fiyatDataGridViewTextBoxColumn.Width = 150;
            // 
            // başlıkDataGridViewTextBoxColumn
            // 
            this.başlıkDataGridViewTextBoxColumn.DataPropertyName = "başlık";
            this.başlıkDataGridViewTextBoxColumn.HeaderText = "başlık";
            this.başlıkDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.başlıkDataGridViewTextBoxColumn.Name = "başlıkDataGridViewTextBoxColumn";
            this.başlıkDataGridViewTextBoxColumn.Width = 150;
            // 
            // hayvankayıtBindingSource
            // 
            this.hayvankayıtBindingSource.DataMember = "hayvankayıt";
            this.hayvankayıtBindingSource.DataSource = this.hayvankayıtDataSet;
            // 
            // hayvankayıtDataSet
            // 
            this.hayvankayıtDataSet.DataSetName = "hayvankayıtDataSet";
            this.hayvankayıtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hayvankayıtTableAdapter
            // 
            this.hayvankayıtTableAdapter.ClearBeforeFill = true;
            // 
            // alıcı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 736);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "alıcı";
            this.Text = "Hayvan Pazarcım";
            this.Load += new System.EventHandler(this.alıcı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvankayıtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvankayıtDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private hayvankayıtDataSet hayvankayıtDataSet;
        private System.Windows.Forms.BindingSource hayvankayıtBindingSource;
        private hayvankayıtDataSetTableAdapters.hayvankayıtTableAdapter hayvankayıtTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yaşDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn başlıkDataGridViewTextBoxColumn;
    }
}