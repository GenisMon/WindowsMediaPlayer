using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMP
{
    public partial class WMP : Form
    {
        public WMP()
        {
            InitializeComponent();
        }

        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new OpenFileDialog();
            Abrir.Title = "Abrir archivos";
            Abrir.Filter = "Archivo mp3 (*.mp3)|*.mp3|Archivo mp4 (*.mp4*)|*.mp4*";
            Abrir.FilterIndex = 1;
            try
            {
                if (Abrir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    axWindowsMediaPlayer1.URL = (Abrir.FileName);
                }
            }
            catch (Exception)
            {

                return;
            }
        }

        private void cerrarReproductorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
    }
}
