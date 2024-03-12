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
    public partial class VizualizareCamere : Form
    {
        public VizualizareCamere()
        {
            InitializeComponent();
        }

        private void VizualizareCamere_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDateDataSet.Camere' table. You can move, or remove it, as needed.
            this.camereTableAdapter.Fill(this.bazaDateDataSet.Camere);

        }
    }
}
