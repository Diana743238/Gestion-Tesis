﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibFormularios;

namespace AppGestionDeTesis
{
    public partial class FrmGestionTesis : Form
    {
        public FrmGestionTesis()
        {
            InitializeComponent();
        }

        private void rEGISTRODETESISTASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Formulario = new FrmTesista();
            Formulario.Show();
        }

        private void rEGISTRODEDOCENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulario = new FrmDocente();
            Formulario.Show();
        }

 
        private void RequisitosSolicitud_Click(object sender, EventArgs e)
        {
            Form Formulario = new  FrmRequisitoTramite();
            Formulario.Show();
        }

        private void Requisitos_Click(object sender, EventArgs e)
        {
            Form Formulario = new FrmRequisitos();
            Formulario.Show();
        }

        private void tRAMITESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulario = new FrmTramites();
            Formulario.Show();
        }

        private void gENERAREXPEDIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulario = new FrmExpediente();
            Formulario.Show();
        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
