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
    public partial class FrmRequisitos : LibFormularios.FrmPadre
    {
        public FrmRequisitos()
        {
            InitializeComponent();
            IniciarEntidad(new CRequisitos());
        }
        //============= REDEFINICION DE LOS METODOS VIRTUALES ====================
        //-- Establecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { CodRequisito.Text, Descripcion.Text };

        }
        //-----------------------------------------------------------
        //-- Mostrar los datos de un registro
        public override void MostrarDatos()
        { //-- muestra la informacion contenida en el dataset de CLibro
            CodRequisito.Text = aEntidad.ValorAtributo("CodRequisito");
            Descripcion.Text = aEntidad.ValorAtributo("Descripcion");
            CodRequisito.Enabled = false;

        }
        //-----------------------------------------------------------
        //-- Iniciar los atributos clave y no clave en blanco
        public override void InicializarAtributoClave()
        {
            CodRequisito.Text = "";
            CodRequisito.Enabled = true;
        }
        public override void InicializarAtributosNoClave()
        {
            Descripcion.Text = "";
        }
        //-----------------------------------------------------------
        //-- Listar los registros y mostrarlos en el datagrid
        public override void ListarRegistros()
        { //-- Mostrar todos los libros de la tabla en el grid
            DgvRequisitos.DataSource = aEntidad.ListaGeneral();
        }
        //-----------------------------------------------------------
        //-- verificar los campos obligatorios(codigo y titulo) estén llenos
        public override bool EsRegistroValido()
        {
            if (CodRequisito.Text.Trim() != "" && Descripcion.Text.Trim() != "")
                return true;
            else
                return false;
        }
        // ================= EVENTOS ==============================
        private void CodRequisito_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }
        private void FrmRequisitos_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }

    }
}

