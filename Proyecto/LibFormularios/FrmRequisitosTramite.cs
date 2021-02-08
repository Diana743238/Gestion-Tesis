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
    public partial class FrmRequisitoTramite : LibFormularios.FrmPadre
    {
        private CTramite aTramite;
        private CRequisitos aRequisitos;
        //================== CONSTRUCTORES =======================
        public FrmRequisitoTramite()
        {
            InitializeComponent();
            IniciarEntidad(new CRequisitosSolicitud());
            //IniciarEntidad(new CRequisitos());
            aTramite = new CTramite();
            aRequisitos = new CRequisitos();
            IniciarTablaRequisitos();
        }
        public void IniciarTablaRequisitos()
        {
            //-- Recupera la informacion de un registro
            ChkListBoxRequisitos.Items. = aRequisitos.ListaGeneral();
        }
        //============= REDEFINICION DE LOS METODOS VIRTUALES ====================
        //-- Establecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            //-- recuperar el codigo del requisito (de la fila seleccionada en el grid)

            return new string[] { ChkListBoxRequisitos.CheckedItems.ToString() };
        }
        //----------------------------------------------------------
        public override void InicializarAtributosNoClave()
        {
            Solicitud.Text = "";
        }
        //-----------------------------------------------------------
        public override void ListarRegistros()
        { //-- Mostrar los ejemplares relacionados con el libro seleccionado
          // dgvRequisitosSolicitud.DataSource =(aEntidad as CTramite).ListaTramites(CodSolicitud.Text);
          //dgvRequisitosSolicitud.DataSource = aEntidad.ListaGeneral();
            string CodTramite= (Solicitud.SelectedValue == null ? "" : Solicitud.SelectedValue.ToString());
            dgvRequisitosSolicitud.DataSource = (aEntidad as CRequisitosSolicitud).ListarRequisitosSolicitud(CodTramite);
        }
        //-----------------------------------------------------------
        public override bool EsRegistroValido()
        {
            if (Solicitud.Text != "")
                return true;
            else
                return false;
        }
        //-----------------------------------------------------------
        public override void Grabar()
        { //-- al grabar un nuevo ejemplar, el formulario queda listo para

            //-- INSERTAR el siguiente registro

            try
            {
                if (EsRegistroValido())
                { //-- Recuperar atributos, el primer atributo es la clave
                    string[] Atributos = AsignarValoresAtributos();

                    //-- Se realiza la inserciòn sin verificar si existe la clave
                    //-- primaria, ya que en este caso la clave es autonumerica.
                    aEntidad.Insertar(Atributos);
                    //-- Inicializar el formulario

                    MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE", "CONFIRMACION");
                    InicializarAtributos();
                    ListarRegistros();

                }
                else
                    MessageBox.Show("DEBE COMPLETAR EL LLENADO DEL FORMULARIO",
                    "ALERTA");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR AL REALIZAR LA OPERACION");
            }
        }
        // ===== METODOS PARA MANEJAR LA INFORMACION DEL LIBRO ==========
        public void LlenarListaRegistroTramites()
        { //-- muestra la lista de tramites en el combo
            Solicitud.DataSource = aTramite.ListaGeneral();
            Solicitud.DisplayMember = "Descripcion";
            Solicitud.ValueMember = "CodTramites";
            //-- dejar el combo sin libro seleccionado
            Solicitud.SelectedIndex = -1;
        }
        // --------------------------------------------------------------------
        public void MostrarDatosRegistroTramite()
        { //-- al seleccionar un tramite en el combo, mostrar el resto de datos
          //-- recuperar el codigo del tramite seleccionado
            string CodTramite = (Solicitud.SelectedValue == null ? "" : Solicitud.SelectedValue.ToString());

            //-- solicitar a la base de datos la informacion del libro
            aTramite.Registro(new string[] { CodTramite });
            //-- mostrar el resto de informacion
            Solicitud.Text = aTramite.ValorAtributo("Nombre");
        }
        // =========================== EVENTOS ==============================
        private void FrmEjemplar_Load(object sender, EventArgs e)
        {
            LlenarListaRegistroTramites();
        }
        //---------------------------------------------------------------------
        private void dgvRequisitosSolicitud_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ChkListBoxRequisitos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MostrarDatosRegistroTramite();
            ListarRegistros();
        }
    }
}
