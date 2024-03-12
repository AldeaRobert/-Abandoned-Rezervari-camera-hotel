namespace Proiect
{
    partial class VizualizareCamere
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
            this.camereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDateDataSet = new Proiect.BazaDateDataSet();
            this.camereTableAdapter = new Proiect.BazaDateDataSetTableAdapters.CamereTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nrCameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrLocuriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretZiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrCameraDataGridViewTextBoxColumn,
            this.nrLocuriDataGridViewTextBoxColumn,
            this.etajDataGridViewTextBoxColumn,
            this.pretZiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.camereBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(321, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // camereBindingSource
            // 
            this.camereBindingSource.DataMember = "Camere";
            this.camereBindingSource.DataSource = this.bazaDateDataSet;
            // 
            // bazaDateDataSet
            // 
            this.bazaDateDataSet.DataSetName = "BazaDateDataSet";
            this.bazaDateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // camereTableAdapter
            // 
            this.camereTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.camereBindingSource, "SpImagine", true));
            this.pictureBox1.Location = new System.Drawing.Point(340, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nrCameraDataGridViewTextBoxColumn
            // 
            this.nrCameraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nrCameraDataGridViewTextBoxColumn.DataPropertyName = "NrCamera";
            this.nrCameraDataGridViewTextBoxColumn.HeaderText = "NrCamera";
            this.nrCameraDataGridViewTextBoxColumn.Name = "nrCameraDataGridViewTextBoxColumn";
            this.nrCameraDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrCameraDataGridViewTextBoxColumn.Width = 79;
            // 
            // nrLocuriDataGridViewTextBoxColumn
            // 
            this.nrLocuriDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nrLocuriDataGridViewTextBoxColumn.DataPropertyName = "NrLocuri";
            this.nrLocuriDataGridViewTextBoxColumn.HeaderText = "NrLocuri";
            this.nrLocuriDataGridViewTextBoxColumn.Name = "nrLocuriDataGridViewTextBoxColumn";
            this.nrLocuriDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrLocuriDataGridViewTextBoxColumn.Width = 72;
            // 
            // etajDataGridViewTextBoxColumn
            // 
            this.etajDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.etajDataGridViewTextBoxColumn.DataPropertyName = "Etaj";
            this.etajDataGridViewTextBoxColumn.HeaderText = "Etaj";
            this.etajDataGridViewTextBoxColumn.Name = "etajDataGridViewTextBoxColumn";
            this.etajDataGridViewTextBoxColumn.ReadOnly = true;
            this.etajDataGridViewTextBoxColumn.Width = 50;
            // 
            // pretZiDataGridViewTextBoxColumn
            // 
            this.pretZiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pretZiDataGridViewTextBoxColumn.DataPropertyName = "PretZi";
            this.pretZiDataGridViewTextBoxColumn.HeaderText = "PretZi";
            this.pretZiDataGridViewTextBoxColumn.Name = "pretZiDataGridViewTextBoxColumn";
            this.pretZiDataGridViewTextBoxColumn.ReadOnly = true;
            this.pretZiDataGridViewTextBoxColumn.Width = 60;
            // 
            // VizualizareCamere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 276);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VizualizareCamere";
            this.Text = "VizualizareCamere";
            this.Load += new System.EventHandler(this.VizualizareCamere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BazaDateDataSet bazaDateDataSet;
        private System.Windows.Forms.BindingSource camereBindingSource;
        private BazaDateDataSetTableAdapters.CamereTableAdapter camereTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCameraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrLocuriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretZiDataGridViewTextBoxColumn;
    }
}