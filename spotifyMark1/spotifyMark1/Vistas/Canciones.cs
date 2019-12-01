using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spotifyMark1.Vistas
{
    public partial class Canciones : Form
    {
        public Canciones()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Vistas.AgregaEditaCancion ventanaAgregaEditaCancion = new Vistas.AgregaEditaCancion();
            ventanaAgregaEditaCancion.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Vistas.AgregaEditaCancion ventanaAgregaEditaCancion = new Vistas.AgregaEditaCancion();
            ventanaAgregaEditaCancion.ShowDialog();
        }
    }
}
