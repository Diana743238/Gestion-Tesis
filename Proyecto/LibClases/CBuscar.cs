using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LibClases
{
    public class CBuscar
    {
        //----- ATRIBUTOS ----------
        protected CConexion conexion;
        public CBuscar()
        {
            conexion = new CConexion();
        }

        //----- METODOS ------------
        //----- TABLA TESIS -------
        public DataTable mostrarTablaTesis()
        {
            DataTable tablaTesis;

            string consulta = "select * from TTesis";
            conexion.EjecutarSelect(consulta);
            tablaTesis = conexion.Datos.Tables[0];
            return tablaTesis;
        }
        //----- TABLA TESISTAS -----
        public DataTable mostrarTablaTesistas()
        {
            DataTable tablaTesistas;

            string consulta = "select * from TTesista";
            conexion.EjecutarSelect(consulta);
            tablaTesistas = conexion.Datos.Tables[0];

            return tablaTesistas;
        }
        //----- TABLA DOCENTES -----
        public DataTable mostrarTablaDocentes()
        {
            DataTable tablaDocentes;

            string consulta = "select * from TDocentes";
            conexion.EjecutarSelect(consulta);
            tablaDocentes = conexion.Datos.Tables[0];

            return tablaDocentes;
        }

        //----- BUSCAR REGISTRO --------
        public DataTable buscarRegistro(string Texto, string Tabla, string Columna)
        {
            DataTable resultadoBusqueda;
            string consulta = "select * from "+ Tabla +" where "+Columna+" like '%"+Texto+"%'";
            conexion.EjecutarSelect(consulta);
            resultadoBusqueda = conexion.Datos.Tables[0];
            return resultadoBusqueda;
        }
    }
}
