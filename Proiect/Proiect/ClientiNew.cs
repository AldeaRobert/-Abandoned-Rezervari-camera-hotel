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
    public partial class ClientiNew : Form
    {
        public ClientiNew()
        {
            InitializeComponent();
        }

        private void ClientiNew_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDateDataSet.Clienti' table. You can move, or remove it, as needed.
            this.clientiTableAdapter.Fill(this.bazaDateDataSet.Clienti);
            numeClientDataGridViewTextBoxColumn.ReadOnly = true;
            nrTelefonDataGridViewTextBoxColumn.ReadOnly = true;
            Configurare(true);
        }
        private void btnActualizare_Click(object sender, EventArgs e)
        {
            //A2
            Configurare(false);
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            try
            {
                clientiTableAdapter.Update(bazaDateDataSet.Clienti);
                Configurare(true);
                refresh();
            }
            catch (Exception exc)
            {
                string s = exc.Message;

                if (s.IndexOf("duplicate values") > 0)
                    MessageBox.Show("Inregistrare deja existenta !");
                else if (s.IndexOf("cannot be deleted") > 0)
                    MessageBox.Show("Ati sters inregistrari referite in alte tabele !");
            }
        }


        private void btnReturnare_Click(object sender, EventArgs e)
        {
            //A3
            Configurare(false);
            refresh();
        }
        
        private void Configurare(Boolean v)
        {
            btnActualizare.Enabled = v;
            btnReturnare.Visible= !v;
            btnSalvare.Visible= !v;
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;
            dataGridView1.ReadOnly = v;
        }

        private void refresh()
        {
            clientiTableAdapter.Fill(bazaDateDataSet.Clienti);
        }
        private void Clienti_Load(object sender, EventArgs e)
        {
            //A1
            Configurare(true);
            refresh();
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format eronat");
        }
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;
        }

    }
}
