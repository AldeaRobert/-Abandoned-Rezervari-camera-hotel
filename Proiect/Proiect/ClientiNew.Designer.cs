namespace Proiect
{
    partial class ClientiNew
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
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnReturnare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDateDataSet = new Proiect.BazaDateDataSet();
            this.clientiTableAdapter = new Proiect.BazaDateDataSetTableAdapters.ClientiTableAdapter();
            this.numeClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDateDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(12, 12);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(75, 23);
            this.btnActualizare.TabIndex = 0;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(93, 12);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(75, 23);
            this.btnSalvare.TabIndex = 1;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Visible = false;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnReturnare
            // 
            this.btnReturnare.Location = new System.Drawing.Point(174, 12);
            this.btnReturnare.Name = "btnReturnare";
            this.btnReturnare.Size = new System.Drawing.Size(75, 23);
            this.btnReturnare.TabIndex = 2;
            this.btnReturnare.Text = "Returnare";
            this.btnReturnare.UseVisualStyleBackColor = true;
            this.btnReturnare.Visible = false;
            this.btnReturnare.Click += new System.EventHandler(this.btnReturnare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeClientDataGridViewTextBoxColumn,
            this.nrTelefonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 400);
            this.dataGridView1.TabIndex = 3;
            // 
            // clientiBindingSource
            // 
            this.clientiBindingSource.DataMember = "Clienti";
            this.clientiBindingSource.DataSource = this.bazaDateDataSet;
            // 
            // bazaDateDataSet
            // 
            this.bazaDateDataSet.DataSetName = "BazaDateDataSet";
            this.bazaDateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientiTableAdapter
            // 
            this.clientiTableAdapter.ClearBeforeFill = true;
            // 
            // numeClientDataGridViewTextBoxColumn
            // 
            this.numeClientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numeClientDataGridViewTextBoxColumn.DataPropertyName = "NumeClient";
            this.numeClientDataGridViewTextBoxColumn.HeaderText = "NumeClient";
            this.numeClientDataGridViewTextBoxColumn.Name = "numeClientDataGridViewTextBoxColumn";
            this.numeClientDataGridViewTextBoxColumn.Width = 86;
            // 
            // nrTelefonDataGridViewTextBoxColumn
            // 
            this.nrTelefonDataGridViewTextBoxColumn.DataPropertyName = "NrTelefon";
            this.nrTelefonDataGridViewTextBoxColumn.HeaderText = "NrTelefon";
            this.nrTelefonDataGridViewTextBoxColumn.Name = "nrTelefonDataGridViewTextBoxColumn";
            this.nrTelefonDataGridViewTextBoxColumn.Width = 93;
            // 
            // ClientiNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 451);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReturnare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.btnActualizare);
            this.Name = "ClientiNew";
            this.Text = "Clienti";
            this.Load += new System.EventHandler(this.ClientiNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDateDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnReturnare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BazaDateDataSet bazaDateDataSet;
        private System.Windows.Forms.BindingSource clientiBindingSource;
        private BazaDateDataSetTableAdapters.ClientiTableAdapter clientiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelefonDataGridViewTextBoxColumn;
    }
}