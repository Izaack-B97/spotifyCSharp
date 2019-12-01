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
    public partial class AgregaEditaArtista : Form
    {
        public AgregaEditaArtista()
        {
            InitializeComponent();
        }

        private void botGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
