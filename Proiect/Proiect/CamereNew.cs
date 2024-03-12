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
using System.Xml.Linq;

namespace Proiect
{
    public partial class CamereNew : Form
    {
        public CamereNew()
        {
            InitializeComponent();
        }

        private void ClientiNew_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDateDataSetNew.RezervariContinut' table. You can move, or remove it, as needed.
            this.rezervariContinutTableAdapter.Fill(this.bazaDateDataSetNew.RezervariContinut);
            // TODO: This line of code loads data into the 'bazaDateDataSet.Camere' table. You can move, or remove it, as needed.
            this.camereTableAdapter.Fill(this.bazaDateDataSet.Camere);

            A1();
        }
        private void A1()
        {
            //Protectie grid 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            //Protectie txtIdPersoana
            txtIdPersoana.ReadOnly = true;
            A3();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            A7();
        }

        private void A7()
        {
            //Configurare butoane
            configureazaButoane(false);

            //Dezlegare controale Panel
            legareControale(false);

            //Ridicare protectie controale Panel
            protectiePanel(false);


            //Modifcare lblOp
            lblOp.Text = "MODIFICARE";

            //Pozitionare cursor pe primul camp
            txtNume.Focus();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {


            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            con.ConnectionString = rezervariContinutTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Select IdCamera From RezervariContinut where IdCamera=" + txtIdPersoana.Text;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Camera este referita in tabela RezervariContinut! Nu se poate sterge!");
                con.Close();
                return;
            }
            else
            {
                const string mesaj = "Confirmati stergerea";
                const string titlu = "Stergere inregistrare";
                var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (rezultat == DialogResult.No) return;
                A8();
            }
            con.Close();
        }

        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = camereTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            cmd.CommandText = "Delete From Camere Where IdCamera = " + txtIdPersoana.Text;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            refresh_grid(camereBindingSource.Position);
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A4();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();
        }
        private void A2()
        {
            //Configurare butoane
            configureazaButoane(false);

            //Dezlegare controale Panel
            legareControale(false);

            //Ridicare protectie controale Panel
            protectiePanel(false);

            //Modifcare lblOp
            lblOp.Text = "ADAUGARE";

            //Pozitionare cursor pe primul camp
            txtNrCamera.Focus();

            // Golire campuri
            golireCampuri();
        }
        private void A3()
        {
            //Initializare lblOp
            lblOp.Text = "";
            //Çonfigurare(butoane)
            configureazaButoane(true);
            //Protectie componente Panel
            protectiePanel(true);
            //Legare controale
            legareControale(true);
        }

        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;

            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
        }

        private void A4()
        {
            if (lblOp.Text == "ADAUGARE")
            {
                if (!validareCampuriObligatorii()) return;

                adauga_inregistrare();

                golireCampuri();

                //Pune cursor pe primul camp
                txtNrCamera.Focus();
                refresh_grid(camereBindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                modifica_inregistrare();
                refresh_grid(camereBindingSource.Position);
                A3();
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");
        }

        private void modifica_inregistrare()
        {
            string listaSet;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = camereTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            listaSet = "NrCamera = '" + txtNrCamera.Text + "'," +
                       "NrLocuri = '" + txtNume.Text + "'," +
                       "Etaj = '" + txtTelefon.Text + "'," +
                       "PretZi = '" + txtPretZi.Text + "'," +
                       "SpImagine = '" + txtSpImagine.Text + "'";

            cmd.CommandText = "Update Camere Set " + listaSet + " Where IdCamera=" +
txtIdPersoana.Text;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void refresh_grid(int p)
        {
            camereTableAdapter.Fill(bazaDateDataSet.Camere);
            camereBindingSource.Position = p;
        }

        private void golireCampuri()
        {
            txtNrCamera.Text = "";
            txtNume.Text = "";
            txtIdPersoana.Text = "";
            txtTelefon.Text = "";
            txtPretZi.Text = "";
            txtSpImagine.Text = "";
        }
        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = camereTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            listaCampuri = "NrCamera, NrLocuri, Etaj, PretZi, SpImagine";
            listaValori = "'" + txtNrCamera.Text + "'" +
                          ",'" + txtNume.Text + "'" +
                          ",'" + txtTelefon.Text + "'" +
                          ",'" + txtPretZi.Text + "'" +
                          ",'" + txtSpImagine.Text + "'";

            cmd.CommandText = "Insert into Camere(" + listaCampuri + ") " +
                              "Select " + listaValori;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: NrCamere, NrLocuri (Nume), Etaj (NrTlf), PretZi
            if (txtNrCamera.Text == "")
            {
                MessageBox.Show("Completati NrCamera !");
                txtNrCamera.Focus();
                return false;
            }
            if (txtNume.Text == "")
            {
                MessageBox.Show("Completati NrLocuri !");
                txtNume.Focus();
                return false;
            }
            if (txtTelefon.Text == "")
            {
                MessageBox.Show("Completati Numarul de Etaj !");
                txtTelefon.Focus();
                return false;
            }
            if (txtPretZi.Text == "")
            {
                MessageBox.Show("Completati PretZi !");
                txtPretZi.Focus();
                return false;
            }
            return true;
        }

        private void txtNrCamera_Leave(object sender, EventArgs e)
        {
            if (txtNrCamera.Text!="")
            {
                A5(txtNrCamera);
            }
        }


        private void A5(TextBox txtB)
        {
            decimal p;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            if (txtNrCamera.Text == "") return;
            if (lblOp.Text == "") return;
            if (btnRenuntare.Focused) return;
         
            // Validare numericitate
            try { p = Convert.ToDecimal(txtB.Text); }
            catch { MessageBox.Show("Format eronat"); txtB.Focus(); return; }
            con.ConnectionString = camereTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            if (lblOp.Text == "ADAUGARE")
            {
                cmd.CommandText = "SELECT NrCamera FROM Camere WHERE NrCamera= " + txtNrCamera.Text ;
                con.Open();
                r = cmd.ExecuteReader();
                
                if (r.Read())
                {
                    MessageBox.Show("NrCamera deja existent");
                    txtNrCamera.Focus();
                }
                con.Close();
            }

            else if (lblOp.Text == "MODIFICARE")
            {
                cmd.CommandText = "SELECT NrCamera FROM Camere WHERE NrCamera=" + txtNrCamera.Text +
                                    " AND IdCamera <> "+txtIdPersoana.Text;
                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("NrCamera deja existent");
                    txtNrCamera.Focus();
                }
                con.Close();

                }
        }

        private void protectiePanel(bool v)
        {
            txtNume.ReadOnly = v;
            txtTelefon.ReadOnly = v;
            txtNrCamera.ReadOnly = v;
            txtPretZi.ReadOnly = v;
            txtSpImagine.ReadOnly = v;
        }

        private void legareControale(bool v)
        {
            if (v)
            {
                txtNume.DataBindings.Add("Text", camereBindingSource, "NrLocuri");
                txtTelefon.DataBindings.Add("Text", camereBindingSource, "Etaj");
                txtIdPersoana.DataBindings.Add("Text", camereBindingSource, "IdCamera");
                txtNrCamera.DataBindings.Add("Text", camereBindingSource, "NrCamera");
                txtPretZi.DataBindings.Add("Text", camereBindingSource, "PretZi");
                txtSpImagine.DataBindings.Add("Text", camereBindingSource, "SpImagine");
            }
            else
            {
                txtNume.DataBindings.Clear();
                txtIdPersoana.DataBindings.Clear();
                txtTelefon.DataBindings.Clear();
                txtNrCamera.DataBindings.Clear();
                txtPretZi.DataBindings.Clear();
                txtSpImagine.DataBindings.Clear();
            }
        }

        private void txtSpImagine_DoubleClick(object sender, EventArgs e)
        {
            if(lblOp.Text=="ADAUGARE"||lblOp.Text=="MODIFICARE")
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtSpImagine.Text = openFileDialog1.FileName;
                    pictureBox1.ImageLocation = txtSpImagine.Text;
                } 
            }
        }
    }
}
