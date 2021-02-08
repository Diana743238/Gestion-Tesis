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
            iniciar
        }

        //----- METODOS ------------
        //----- TABLA TESIS -------
        public DataTable mostrarTablaTesis(string NombreTesis)
        {
            DataTable tablaTesis;



            return tablaTesis;
        }
        //----- TABLA TESISTAS -----
        public DataTable mostrarTablaTesistas()
        {
            DataTable tablaTesistas;



            return tablaTesistas;
        }
        //----- TABLA DOCENTES -----
        public DataTable mostrarTablaDocentes()
        {
            DataTable tablaDocentes;



            return tablaDocentes;
        }
    }
}
