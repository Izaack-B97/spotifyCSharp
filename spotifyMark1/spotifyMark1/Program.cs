using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spotifyMark1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainScreen());
        }
    }
}

//Catálogo Canciones
//Catálogo Album
//Catálogo Artista
//Catálogo Género
//Catálogo Usuarios

//Relación Canción con:
//	Artista
//	Album
//	Genero

//Relación Usuario con Playlist
//Relación PlayList con Canciones
//192.168.1.68
