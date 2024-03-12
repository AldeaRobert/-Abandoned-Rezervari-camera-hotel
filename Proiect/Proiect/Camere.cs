using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Camere : Form
    {
        public Camere()
        {
            InitializeComponent();
        }

        private void Camere_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDateDataSet.Camere' table. You can move, or remove it, as needed.
            this.camereTableAdapter.Fill(this.bazaDateDataSet.Camere);

        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            btnAdaugare.Enabled = false;
            btnModificare.Enabled = false;
            btnStergere.Enabled = false;

            btnConfirmare.Visible = true;
            btnRenuntare.Visible = true;

            txtEtaj.Text=null;

            txtNrCamera.Enabled = true;

            txtNrCamera.Text=null;
            txtNrLocuri.Text=null;
            txtSpImagine.Text=null;
            txtPretZi.Text = null;

            txtEtaj.ReadOnly = false;
            txtNrCamera.ReadOnly = false;
            txtNrLocuri.ReadOnly = false;
            txtSpImagine.ReadOnly = false;
            txtPretZi.ReadOnly = false;

            cmbIdCam.Text = null;
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            btnAdaugare.Enabled = true;
            btnModificare.Enabled = true;
            btnStergere.Enabled = true;

            btnConfirmare.Visible = false;
            btnRenuntare.Visible = false;

            txtEtaj.Text = null;
            txtNrCamera.Text = null;
            txtNrLocuri.Text = null;
            txtSpImagine.Text = null;
            txtPretZi.Text = null;

            txtEtaj.ReadOnly = true;
            txtNrCamera.ReadOnly= true;
            txtNrLocuri.ReadOnly= true;
            txtSpImagine.ReadOnly= true;
            txtPretZi.ReadOnly= true;

            cmbIdCam.Text = null;

            dataGridView1.Enabled = true;
        }
    }
}
