using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
=======
using LibClases;
>>>>>>> 28d1e63058a456b02821e0f9358a209782f0681d

namespace LibFormularios
{
    public partial class FrmBuscar : Form
    {
<<<<<<< HEAD
        public FrmBuscar()
        {
            InitializeComponent();
=======
        protected CBuscar buscar;
        private string tabla;
        private string columna;
        
        public FrmBuscar()
        {
            InitializeComponent();
            buscar = new CBuscar();
        }

        //Verificar que tabla es la que esta solicitando
        private void Tabla_Leave(object sender, EventArgs e)
        {
            //mostra los items en la tabla columna
            if(Tabla.Text == "Tesis")
            {
                Atributo.Items.Add("Codigo de Tesis");
                Atributo.Items.Add("Nombre de tesis");
                buscar.mostrarTablaTesis();
            }
            if (Tabla.Text == "Tesista")
            {
                Atributo.Items.Add("Codigo de Tesista");
                Atributo.Items.Add("Nombre de tesista");
                Atributo.Items.Add("Apellido Materno Tesista");
                Atributo.Items.Add("Apellido Paterno Tesista");
                Atributo.Items.Add("DNI");
                buscar.mostrarTablaTesistas();
            }
            if (Tabla.Text == "Docentes")
            {
                Atributo.Items.Add("Codigo de Docente");
                Atributo.Items.Add("Nombre de Docente");
                Atributo.Items.Add("Apellido Materno");
                Atributo.Items.Add("Apellido Paterno");
                Atributo.Items.Add("DNI");
                Atributo.Items.Add("Categoria");
                Atributo.Items.Add("Departamento Academico");
                buscar.mostrarTablaDocentes();
            }
        }

        private void Atributo_Leave(object sender, EventArgs e)
        {
            switch (Atributo.Text)
            {
                case "Codigo de Tesis":
                    tabla = "TTesis";
                    columna = "CodTesis";
                    break;
                case "Nombre de Tesis":
                    tabla = "TTesis";
                    columna = "TituloTesis";
                    break;
                case "Codigo de Tesista":
                    tabla = "TTesista";
                    columna = "CodTesista";
                    break;
                case "Nombre de Tesista":
                    tabla = "TTesista";
                    columna = "Nombre";
                    break;
                case "Apellido Materno Tesista":
                    tabla = "TTesista";
                    columna = "ApellidoMaterno";
                    break;
                case "Apellido Paterno Tesista":
                    tabla = "TTesista";
                    columna = "ApellidoPaterno";
                    break;
                case "Codigo de Docente":
                    tabla = "TDocentes";
                    columna = "CodDocente";
                    break;
                case "Nombre de Docente":
                    tabla = "TDocentes";
                    columna = "Nombre";
                    break;
                case "Apellido Materno":
                    tabla = "TDocentes";
                    columna = "ApellidoMaterno";
                    break;
                case "Apellido Paterno":
                    tabla = "TDocentes";
                    columna = "ApellidoPaterno";
                    break;
                case "DNI":
                    tabla = "TDocentes";
                    columna = "DNI";
                    break;
                case "Categoria":
                    tabla = "TDocentes";
                    columna = "Categoria";
                    break;
                case "Departamento Academico":
                    tabla = "TDocentes";
                    columna = "DepAcademico";
                    break;
            }
            buscador.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvResultados.DataSource = buscar.buscarRegistro(buscador.Text,tabla,columna);
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            DataTable Seleccionados;
            Seleccionados = dgvResultados.SelectedRows.CopyTo();
>>>>>>> 28d1e63058a456b02821e0f9358a209782f0681d
        }
    }
}
