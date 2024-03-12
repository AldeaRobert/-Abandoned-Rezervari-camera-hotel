namespace Proiect
{
    partial class CamereNew
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
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.camereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDateDataSet = new Proiect.BazaDateDataSet();
            this.txtSpImagine = new System.Windows.Forms.TextBox();
            this.txtPretZi = new System.Windows.Forms.TextBox();
            this.txtNrCamera = new System.Windows.Forms.TextBox();
            this.lblSpImagine = new System.Windows.Forms.Label();
            this.lblCamera = new System.Windows.Forms.Label();
            this.lblPretZi = new System.Windows.Forms.Label();
            this.txtIdPersoana = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.lblOp = new System.Windows.Forms.Label();
            this.camereTableAdapter = new Proiect.BazaDateDataSetTableAdapters.CamereTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bazaDateDataSetNew = new Proiect.BazaDateDataSetNew();
            this.rezervariContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervariContinutTableAdapter = new Proiect.BazaDateDataSetNewTableAdapters.RezervariContinutTableAdapter();
            this.NrCamera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrLocuri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretZiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpImagine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDateDataSetNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervariContinutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(528, 77);
            this.btnRenuntare.Margin = new System.Windows.Forms.Padding(2);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(77, 30);
            this.btnRenuntare.TabIndex = 36;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(437, 77);
            this.btnConfirmare.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(76, 30);
            this.btnConfirmare.TabIndex = 35;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtSpImagine);
            this.panel1.Controls.Add(this.txtPretZi);
            this.panel1.Controls.Add(this.txtNrCamera);
            this.panel1.Controls.Add(this.lblSpImagine);
            this.panel1.Controls.Add(this.lblCamera);
            this.panel1.Controls.Add(this.lblPretZi);
            this.panel1.Controls.Add(this.txtIdPersoana);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.txtNume);
            this.panel1.Controls.Add(this.lblTelefon);
            this.panel1.Controls.Add(this.txtTelefon);
            this.panel1.Controls.Add(this.lblNume);
            this.panel1.Location = new System.Drawing.Point(415, 101);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 328);
            this.panel1.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.camereBindingSource, "SpImagine", true));
            this.pictureBox1.Location = new System.Drawing.Point(207, -81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
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
            // txtSpImagine
            // 
            this.txtSpImagine.Location = new System.Drawing.Point(44, 297);
            this.txtSpImagine.Name = "txtSpImagine";
            this.txtSpImagine.Size = new System.Drawing.Size(643, 20);
            this.txtSpImagine.TabIndex = 24;
            this.txtSpImagine.DoubleClick += new System.EventHandler(this.txtSpImagine_DoubleClick);
            // 
            // txtPretZi
            // 
            this.txtPretZi.Location = new System.Drawing.Point(44, 196);
            this.txtPretZi.Name = "txtPretZi";
            this.txtPretZi.Size = new System.Drawing.Size(100, 20);
            this.txtPretZi.TabIndex = 23;
            // 
            // txtNrCamera
            // 
            this.txtNrCamera.Location = new System.Drawing.Point(41, 51);
            this.txtNrCamera.Name = "txtNrCamera";
            this.txtNrCamera.Size = new System.Drawing.Size(100, 20);
            this.txtNrCamera.TabIndex = 22;
            this.txtNrCamera.Leave += new System.EventHandler(this.txtNrCamera_Leave);
            // 
            // lblSpImagine
            // 
            this.lblSpImagine.AutoSize = true;
            this.lblSpImagine.Location = new System.Drawing.Point(44, 281);
            this.lblSpImagine.Name = "lblSpImagine";
            this.lblSpImagine.Size = new System.Drawing.Size(57, 13);
            this.lblSpImagine.TabIndex = 21;
            this.lblSpImagine.Text = "SpImagine";
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Location = new System.Drawing.Point(44, 36);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(54, 13);
            this.lblCamera.TabIndex = 20;
            this.lblCamera.Text = "NrCamera";
            // 
            // lblPretZi
            // 
            this.lblPretZi.AutoSize = true;
            this.lblPretZi.Location = new System.Drawing.Point(44, 181);
            this.lblPretZi.Name = "lblPretZi";
            this.lblPretZi.Size = new System.Drawing.Size(35, 13);
            this.lblPretZi.TabIndex = 19;
            this.lblPretZi.Text = "PretZi";
            // 
            // txtIdPersoana
            // 
            this.txtIdPersoana.Location = new System.Drawing.Point(44, 241);
            this.txtIdPersoana.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdPersoana.Name = "txtIdPersoana";
            this.txtIdPersoana.Size = new System.Drawing.Size(100, 20);
            this.txtIdPersoana.TabIndex = 18;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(44, 226);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(56, 13);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "ID camera";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(41, 96);
            this.txtNume.Margin = new System.Windows.Forms.Padding(2);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(103, 20);
            this.txtNume.TabIndex = 12;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(44, 126);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(25, 13);
            this.lblTelefon.TabIndex = 10;
            this.lblTelefon.Text = "Etaj";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(44, 141);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 16;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(44, 81);
            this.lblNume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(47, 13);
            this.lblNume.TabIndex = 6;
            this.lblNume.Text = "NrLocuri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NrCamera,
            this.NrLocuri,
            this.pretZiDataGridViewTextBoxColumn,
            this.Etaj,
            this.SpImagine});
            this.dataGridView1.DataSource = this.camereBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(399, 370);
            this.dataGridView1.TabIndex = 33;
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(315, 19);
            this.btnStergere.Margin = new System.Windows.Forms.Padding(2);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(62, 31);
            this.btnStergere.TabIndex = 32;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(175, 19);
            this.btnModificare.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(66, 30);
            this.btnModificare.TabIndex = 31;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(53, 20);
            this.btnAdaugare.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(67, 29);
            this.btnAdaugare.TabIndex = 30;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(484, 47);
            this.lblOp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(0, 13);
            this.lblOp.TabIndex = 37;
            // 
            // camereTableAdapter
            // 
            this.camereTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bazaDateDataSetNew
            // 
            this.bazaDateDataSetNew.DataSetName = "BazaDateDataSetNew";
            this.bazaDateDataSetNew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervariContinutBindingSource
            // 
            this.rezervariContinutBindingSource.DataMember = "RezervariContinut";
            this.rezervariContinutBindingSource.DataSource = this.bazaDateDataSetNew;
            // 
            // rezervariContinutTableAdapter
            // 
            this.rezervariContinutTableAdapter.ClearBeforeFill = true;
            // 
            // NrCamera
            // 
            this.NrCamera.DataPropertyName = "NrCamera";
            this.NrCamera.HeaderText = "NrCamera";
            this.NrCamera.Name = "NrCamera";
            // 
            // NrLocuri
            // 
            this.NrLocuri.DataPropertyName = "NrLocuri";
            this.NrLocuri.HeaderText = "NrLocuri";
            this.NrLocuri.Name = "NrLocuri";
            // 
            // pretZiDataGridViewTextBoxColumn
            // 
            this.pretZiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pretZiDataGridViewTextBoxColumn.DataPropertyName = "PretZi";
            this.pretZiDataGridViewTextBoxColumn.HeaderText = "PretZi";
            this.pretZiDataGridViewTextBoxColumn.Name = "pretZiDataGridViewTextBoxColumn";
            this.pretZiDataGridViewTextBoxColumn.Width = 60;
            // 
            // Etaj
            // 
            this.Etaj.DataPropertyName = "Etaj";
            this.Etaj.HeaderText = "Etaj";
            this.Etaj.Name = "Etaj";
            // 
            // SpImagine
            // 
            this.SpImagine.DataPropertyName = "SpImagine";
            this.SpImagine.HeaderText = "SpImagine";
            this.SpImagine.Name = "SpImagine";
            // 
            // CamereNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 444);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.Name = "CamereNew";
            this.Text = "Camere";
            this.Load += new System.EventHandler(this.ClientiNew_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDateDataSetNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervariContinutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIdPersoana;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnAdaugare;
        private BazaDateDataSet bazaDateDataSet;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.BindingSource camereBindingSource;
        private BazaDateDataSetTableAdapters.CamereTableAdapter camereTableAdapter;
        private System.Windows.Forms.TextBox txtSpImagine;
        private System.Windows.Forms.TextBox txtPretZi;
        private System.Windows.Forms.TextBox txtNrCamera;
        private System.Windows.Forms.Label lblSpImagine;
        private System.Windows.Forms.Label lblCamera;
        private System.Windows.Forms.Label lblPretZi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private BazaDateDataSetNew bazaDateDataSetNew;
        private System.Windows.Forms.BindingSource rezervariContinutBindingSource;
        private BazaDateDataSetNewTableAdapters.RezervariContinutTableAdapter rezervariContinutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrCamera;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrLocuri;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretZiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpImagine;
    }
}