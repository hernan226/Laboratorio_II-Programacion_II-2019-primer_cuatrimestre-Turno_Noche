using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace GUI
{
    public partial class FrmPC : Form
    {
        Maquina compu = new Maquina("Nueva Maquina");
        public FrmPC()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        /// <summary>
        /// Agrega un periferico de la maquina si puede hacerlo y muestra el resultado por pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string a = compu + new PlacaVideo(txtMarca.Text, txtModelo.Text, (int)nudMemoria.Value);
            MessageBox.Show(a);
        }

        /// <summary>
        /// Quita un periferico de la maquina si puede hacerlo y muestra el resultado por pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSacar_Click(object sender, EventArgs e)
        {
            string a = compu - new PlacaVideo(txtMarca.Text, txtModelo.Text, (int)nudMemoria.Value);
            MessageBox.Show(a);
        }

        /// <summary>
        /// Muestra en la rich text box los datos de la maquina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSystemInfo_Click(object sender, EventArgs e)
        {
            rtxtSystemInfo.Text = compu.SystemInfo;
        }
    }
}
