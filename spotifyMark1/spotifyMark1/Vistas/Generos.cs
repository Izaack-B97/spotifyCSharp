﻿using System;
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
    public partial class Generos : Form
    {
        public Generos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Vistas.AgregaEditaGenero ventanaAgregaEditaGenero = new Vistas.AgregaEditaGenero();
            ventanaAgregaEditaGenero.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Vistas.AgregaEditaGenero ventanaAgregaEditaGenero = new Vistas.AgregaEditaGenero();
            ventanaAgregaEditaGenero.ShowDialog();
        }
    }
}
