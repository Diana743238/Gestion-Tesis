using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LibClases;

namespace LibFormularios
{
    public partial class FrmProveido : LibFormularios.FrmPadre
    {
        private CConexion conexion;
        private CDocentes Docentes;
        private CTesista Tesistas;
        private CProveido Proveido;
        public FrmProveido()
        {
            InitializeComponent();
            IniciarEntidad(new CProveido());
            //IniciarEntidad(new CRequisitos());
            conexion = new CConexion();
            Docentes = new CDocentes();
            Tesistas = new CTesista();
            //IniciarTablaRequisitos();
            //dgvRequisitosSolicitud.DataSource = aEntidad.ListaGeneral();
        }

        private void BuscarTesis_Click(object sender, EventArgs e)
        {
            Form Formulario = new FrmBuscarTesis();
            Formulario.Show();
        }

        private void BuscarDocentes_Click(object sender, EventArgs e)
        {
            Form Formulario = new FrmBuscarDocentes();
            Formulario.Show();
        }

        private void CodTesis_Leave(object sender, EventArgs e)
        {
            // recolectamos el titulo de la tesis 
            string nombreTesis = "";
            nombreTesis = Proveido.Titulo(CodTesis.Text);
            NombreTesis.Text = nombreTesis;

            // recolectamos los datos de los tesistas 
            DataTable Tesistas;
            Tesistas = Proveido.Tesistas(CodTesis.Text);
            dgvTeistas.DataSource = Tesistas;
        }

        private void DesignacionDocentes()
        {

        }


    }
}
