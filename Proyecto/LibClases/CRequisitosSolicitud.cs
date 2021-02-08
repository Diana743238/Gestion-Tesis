using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class CRequisitosSolicitud : CEntidad
    {
        //=============== ATRIBUTOS =======================
        //-- Todos heredados de CEntidad ----
        //================ METODOS ========================
        //-------------- Constructores --------------------
        public CRequisitosSolicitud() : base("TRequisitosSolicitud")
        {
        }
        //------ Implementación de metodos abstractos -----
        public override string[] NombresAtributos()
        {
            return new string[] { "codSolicitud", "codRequisito" };
        }

        public DataTable ListarRequisitosSolicitud(string pCodTramite)
        { //-- lista los ejemplares que le corresponden a un libro determinado
            string Consulta = "select S.CodRequisito,R.Descripcion from TRequisitosSolicitud S inner join TRequisitos R on S.CodRequisito = R.CodRequisito where S.CodTramite = '" + pCodTramite + "'";

            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
    }
}
