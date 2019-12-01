using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spotifyMark1
{
    public partial class mainScreen : Form
    {
        public mainScreen()
        {
            InitializeComponent();
        }

        //private void btnCanciones_Click(object sender, EventArgs e)
        //{
        //    Vistas.Canciones ventanaCancion = new Vistas.Canciones();
        //    ventanaCancion.ShowDialog();
        //}

        private void btnCanciones_Click_1(object sender, EventArgs e)
        {
            Vistas.Canciones ventanaCancion = new Vistas.Canciones();
            ventanaCancion.ShowDialog();
        }

        private void btnAlbumes_Click(object sender, EventArgs e)
        {
            Vistas.Albumes ventanaAlbum = new Vistas.Albumes();
            ventanaAlbum.ShowDialog();
        }

        private void btnArtistas_Click(object sender, EventArgs e)
        {
            Vistas.Artistas ventanaArtista = new Vistas.Artistas();
            ventanaArtista.ShowDialog();
        }

        private void btnGeneros_Click(object sender, EventArgs e)
        {
            Vistas.Generos ventanaGenero = new Vistas.Generos();
            ventanaGenero.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Vistas.Usuarios ventanaUsuario = new Vistas.Usuarios();
            ventanaUsuario.ShowDialog();
        }
    }
}
