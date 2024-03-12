namespace Proiect
{
    partial class Camere
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLocalitate = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.PB = new System.Windows.Forms.PictureBox();
            this.txtNrCamera = new System.Windows.Forms.TextBox();
            this.txtEtaj = new System.Windows.Forms.TextBox();
            this.lblPoza = new System.Windows.Forms.Label();
            this.lblSalariu = new System.Windows.Forms.Label();
            this.txtSpImagine = new System.Windows.Forms.TextBox();
            this.txtNrLocuri = new System.Windows.Forms.TextBox();
            this.lblCNP = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.camereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDateDataSet = new Proiect.BazaDateDataSet();
            this.lblOp = new System.Windows.Forms.Label();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.camereTableAdapter = new Proiect.BazaDateDataSetTableAdapters.CamereTableAdapter();
            this.IdCamera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrCameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrLocuriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretZiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spImagineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbIdCam = new System.Windows.Forms.ComboBox();
            this.txtPretZi = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDateDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPretZi);
            this.panel1.Controls.Add(this.cmbIdCam);
            this.panel1.Controls.Add(this.lblLocalitate);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.PB);
            this.panel1.Controls.Add(this.txtNrCamera);
            this.panel1.Controls.Add(this.txtEtaj);
            this.panel1.Controls.Add(this.lblPoza);
            this.panel1.Controls.Add(this.lblSalariu);
            this.panel1.Controls.Add(this.txtSpImagine);
            this.panel1.Controls.Add(this.txtNrLocuri);
            this.panel1.Controls.Add(this.lblCNP);
            this.panel1.Controls.Add(this.lblNume);
            this.panel1.Location = new System.Drawing.Point(525, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 283);
            this.panel1.TabIndex = 31;
            // 
            // lblLocalitate
            // 
            this.lblLocalitate.AutoSize = true;
            this.lblLocalitate.Location = new System.Drawing.Point(14, 141);
            this.lblLocalitate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalitate.Name = "lblLocalitate";
            this.lblLocalitate.Size = new System.Drawing.Size(35, 13);
            this.lblLocalitate.TabIndex = 9;
            this.lblLocalitate.Text = "PretZi";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(14, 175);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(52, 13);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "IdCamera";
            // 
            // PB
            // 
            this.PB.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.camereBindingSource, "SpImagine", true));
            this.PB.Location = new System.Drawing.Point(246, 2);
            this.PB.Margin = new System.Windows.Forms.Padding(2);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(432, 279);
            this.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB.TabIndex = 17;
            this.PB.TabStop = false;
            // 
            // txtNrCamera
            // 
            this.txtNrCamera.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.camereBindingSource, "NrCamera", true));
            this.txtNrCamera.Location = new System.Drawing.Point(68, 11);
            this.txtNrCamera.Margin = new System.Windows.Forms.Padding(2);
            this.txtNrCamera.Name = "txtNrCamera";
            this.txtNrCamera.ReadOnly = true;
            this.txtNrCamera.Size = new System.Drawing.Size(171, 20);
            this.txtNrCamera.TabIndex = 12;
            // 
            // txtEtaj
            // 
            this.txtEtaj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.camereBindingSource, "Etaj", true));
            this.txtEtaj.Location = new System.Drawing.Point(68, 72);
            this.txtEtaj.Margin = new System.Windows.Forms.Padding(2);
            this.txtEtaj.Name = "txtEtaj";
            this.txtEtaj.ReadOnly = true;
            this.txtEtaj.Size = new System.Drawing.Size(171, 20);
            this.txtEtaj.TabIndex = 14;
            // 
            // lblPoza
            // 
            this.lblPoza.AutoSize = true;
            this.lblPoza.Location = new System.Drawing.Point(16, 105);
            this.lblPoza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoza.Name = "lblPoza";
            this.lblPoza.Size = new System.Drawing.Size(31, 13);
            this.lblPoza.TabIndex = 10;
            this.lblPoza.Text = "Poza";
            // 
            // lblSalariu
            // 
            this.lblSalariu.AutoSize = true;
            this.lblSalariu.Location = new System.Drawing.Point(16, 72);
            this.lblSalariu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalariu.Name = "lblSalariu";
            this.lblSalariu.Size = new System.Drawing.Size(25, 13);
            this.lblSalariu.TabIndex = 8;
            this.lblSalariu.Text = "Etaj";
            // 
            // txtSpImagine
            // 
            this.txtSpImagine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.camereBindingSource, "SpImagine", true));
            this.txtSpImagine.Location = new System.Drawing.Point(68, 105);
            this.txtSpImagine.Margin = new System.Windows.Forms.Padding(2);
            this.txtSpImagine.Name = "txtSpImagine";
            this.txtSpImagine.ReadOnly = true;
            this.txtSpImagine.Size = new System.Drawing.Size(171, 20);
            this.txtSpImagine.TabIndex = 16;
            // 
            // txtNrLocuri
            // 
            this.txtNrLocuri.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.camereBindingSource, "NrLocuri", true));
            this.txtNrLocuri.Location = new System.Drawing.Point(68, 40);
            this.txtNrLocuri.Margin = new System.Windows.Forms.Padding(2);
            this.txtNrLocuri.Name = "txtNrLocuri";
            this.txtNrLocuri.ReadOnly = true;
            this.txtNrLocuri.Size = new System.Drawing.Size(171, 20);
            this.txtNrLocuri.TabIndex = 13;
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.Location = new System.Drawing.Point(16, 45);
            this.lblCNP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(47, 13);
            this.lblCNP.TabIndex = 7;
            this.lblCNP.Text = "NrLocuri";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(14, 16);
            this.lblNume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(54, 13);
            this.lblNume.TabIndex = 6;
            this.lblNume.Text = "NrCamera";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCamera,
            this.nrCameraDataGridViewTextBoxColumn,
            this.nrLocuriDataGridViewTextBoxColumn,
            this.etajDataGridViewTextBoxColumn,
            this.pretZiDataGridViewTextBoxColumn,
            this.spImagineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.camereBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 77);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(510, 283);
            this.dataGridView1.TabIndex = 30;
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
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.Location = new System.Drawing.Point(794, 10);
            this.lblOp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(0, 20);
            this.lblOp.TabIndex = 29;
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(870, 42);
            this.btnRenuntare.Margin = new System.Windows.Forms.Padding(2);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(77, 30);
            this.btnRenuntare.TabIndex = 28;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Visible = false;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(772, 42);
            this.btnConfirmare.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(76, 30);
            this.btnConfirmare.TabIndex = 27;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Visible = false;
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(404, 43);
            this.btnStergere.Margin = new System.Windows.Forms.Padding(2);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(62, 31);
            this.btnStergere.TabIndex = 26;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(275, 42);
            this.btnModificare.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(66, 30);
            this.btnModificare.TabIndex = 25;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(148, 43);
            this.btnAdaugare.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(67, 29);
            this.btnAdaugare.TabIndex = 24;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // camereTableAdapter
            // 
            this.camereTableAdapter.ClearBeforeFill = true;
            // 
            // IdCamera
            // 
            this.IdCamera.DataPropertyName = "IdCamera";
            this.IdCamera.HeaderText = "IdCamera";
            this.IdCamera.Name = "IdCamera";
            this.IdCamera.ReadOnly = true;
            // 
            // nrCameraDataGridViewTextBoxColumn
            // 
            this.nrCameraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nrCameraDataGridViewTextBoxColumn.DataPropertyName = "NrCamera";
            this.nrCameraDataGridViewTextBoxColumn.HeaderText = "NrCamera";
            this.nrCameraDataGridViewTextBoxColumn.Name = "nrCameraDataGridViewTextBoxColumn";
            this.nrCameraDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrCameraDataGridViewTextBoxColumn.Width = 79;
            // 
            // nrLocuriDataGridViewTextBoxColumn
            // 
            this.nrLocuriDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nrLocuriDataGridViewTextBoxColumn.DataPropertyName = "NrLocuri";
            this.nrLocuriDataGridViewTextBoxColumn.HeaderText = "NrLocuri";
            this.nrLocuriDataGridViewTextBoxColumn.Name = "nrLocuriDataGridViewTextBoxColumn";
            this.nrLocuriDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrLocuriDataGridViewTextBoxColumn.Width = 72;
            // 
            // etajDataGridViewTextBoxColumn
            // 
            this.etajDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.etajDataGridViewTextBoxColumn.DataPropertyName = "Etaj";
            this.etajDataGridViewTextBoxColumn.HeaderText = "Etaj";
            this.etajDataGridViewTextBoxColumn.Name = "etajDataGridViewTextBoxColumn";
            this.etajDataGridViewTextBoxColumn.ReadOnly = true;
            this.etajDataGridViewTextBoxColumn.Width = 50;
            // 
            // pretZiDataGridViewTextBoxColumn
            // 
            this.pretZiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pretZiDataGridViewTextBoxColumn.DataPropertyName = "PretZi";
            this.pretZiDataGridViewTextBoxColumn.HeaderText = "PretZi";
            this.pretZiDataGridViewTextBoxColumn.Name = "pretZiDataGridViewTextBoxColumn";
            this.pretZiDataGridViewTextBoxColumn.ReadOnly = true;
            this.pretZiDataGridViewTextBoxColumn.Width = 60;
            // 
            // spImagineDataGridViewTextBoxColumn
            // 
            this.spImagineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.spImagineDataGridViewTextBoxColumn.DataPropertyName = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.HeaderText = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.Name = "spImagineDataGridViewTextBoxColumn";
            this.spImagineDataGridViewTextBoxColumn.ReadOnly = true;
            this.spImagineDataGridViewTextBoxColumn.Width = 82;
            // 
            // cmbIdCam
            // 
            this.cmbIdCam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.camereBindingSource, "IdCamera", true));
            this.cmbIdCam.DataSource = this.camereBindingSource;
            this.cmbIdCam.DisplayMember = "IdCamera";
            this.cmbIdCam.FormattingEnabled = true;
            this.cmbIdCam.Location = new System.Drawing.Point(68, 175);
            this.cmbIdCam.Name = "cmbIdCam";
            this.cmbIdCam.Size = new System.Drawing.Size(171, 21);
            this.cmbIdCam.TabIndex = 20;
            // 
            // txtPretZi
            // 
            this.txtPretZi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.camereBindingSource, "PretZi", true));
            this.txtPretZi.Location = new System.Drawing.Point(68, 141);
            this.txtPretZi.Name = "txtPretZi";
            this.txtPretZi.ReadOnly = true;
            this.txtPretZi.Size = new System.Drawing.Size(171, 20);
            this.txtPretZi.TabIndex = 34;
            // 
            // Camere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 378);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.Name = "Camere";
            this.Text = "Camere";
            this.Load += new System.EventHandler(this.Camere_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDateDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLocalitate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.TextBox txtNrCamera;
        private System.Windows.Forms.TextBox txtEtaj;
        private System.Windows.Forms.Label lblPoza;
        private System.Windows.Forms.Label lblSalariu;
        private System.Windows.Forms.TextBox txtSpImagine;
        private System.Windows.Forms.TextBox txtNrLocuri;
        private System.Windows.Forms.Label lblCNP;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnAdaugare;
        private BazaDateDataSet bazaDateDataSet;
        private System.Windows.Forms.BindingSource camereBindingSource;
        private BazaDateDataSetTableAdapters.CamereTableAdapter camereTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCamera;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCameraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrLocuriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretZiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spImagineDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbIdCam;
        private System.Windows.Forms.TextBox txtPretZi;
    }
}