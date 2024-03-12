using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class LogInScreen : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        public LogInScreen()
        {
            InitializeComponent();
        }

        private void A1(Boolean v)
        {
            lblTitlu.Visible = !v;
            lblAutor.Visible = !v;
            btnEdCam.Visible = !v;
            btnEdClient.Visible = !v;
            btnEdRez.Visible = !v;
            btnEdConRez.Visible = !v;
            lblParola.Visible = v;
            txtParola.Visible = v;
            lblUtilizator.Visible = v;
            txtUtilizator.Visible = v;
            if (v) btnStart.Text = "Log In";
            else btnStart.Text = "Log Out";
        }

        private Boolean Logare_OK()
        {
            if (txtUtilizator.Text == "")
            {
                MessageBox.Show("Completati utilizator !");
                txtUtilizator.Focus();
                return false;
            }
            if (txtParola.Text == "")
            {
                MessageBox.Show("Completati parola !");
                txtParola.Focus();
                return false;
            }

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                                   "Data Source=D:\\Facultate\\an_3\\s1\\Tehnici avansate de programare\\Proiect\\BazaDate.accdb";
            cmd.Connection = con;
            cmd.CommandText = "Select Username,Password from Utilizatori " +
                              "where Username='" + txtUtilizator.Text + "'";
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                if (txtParola.Text != rdr.GetString(1))
                {
                    MessageBox.Show("Parola eronata");
                    txtParola.Focus();
                    con.Close();
                    return false;
                }
                con.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Utilizator eronat");
                txtUtilizator.Focus();
                con.Close();
                return false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Log In")
            {
                if (Logare_OK())
                {
                    A1(false);
                    txtParola.Text = null;
                    txtUtilizator.Text = null;
                }
            }
            else A1(true);
        }

        private void btnLogIn1_Click(object sender, EventArgs e)
        {
            Boolean c = true;
            btnLogIn1.Visible = !c;
            btnVizCam.Visible = !c;
            lblParola.Visible = c;
            txtParola.Visible = c;
            lblUtilizator.Visible = c;
            txtUtilizator.Visible = c;
            btnStart.Visible = c;
            btnStepBackHome.Visible = c;
        }

        private void btnStepBackHome_Click(object sender, EventArgs e)
        {
            Boolean c = false;
            btnStepBackHome.Visible = c;
            btnEdCam.Visible = c;
            btnEdClient.Visible = c;
            btnEdRez.Visible = c;
            btnEdConRez.Visible = c;
            lblTitlu.Visible = c;
            lblAutor.Visible = c;
            btnLogIn1.Visible = !c;
            btnVizCam.Visible = !c;
            lblParola.Visible = c;
            txtParola.Visible = c;
            lblUtilizator.Visible = c;
            txtUtilizator.Visible = c;
            btnStart.Visible = c;
            btnStepBackHome.Visible = c;
            btnStart.Text = "Log In";
            txtParola.Text = null;
            txtUtilizator.Text = null;
        }

        private void btnEdCam_Click(object sender, EventArgs e)
        {
            CamereNew f = new CamereNew();
            f.ShowDialog();
        }

        private void btnEdClient_Click(object sender, EventArgs e)
        {
            ClientiNew f = new ClientiNew();
            f.ShowDialog();
        }

        private void btnEdRez_Click(object sender, EventArgs e)
        {
            Rezervari f = new Rezervari();
            f.ShowDialog();
        }

        private void btnVizCam_Click(object sender, EventArgs e)
        {
            VizualizareCamere f = new VizualizareCamere();
            f.ShowDialog();
        }

        private void btnEdConRez_Click(object sender, EventArgs e)
        {
            ContinutRezervari f = new ContinutRezervari();
            f.ShowDialog();
        }
    }
}
