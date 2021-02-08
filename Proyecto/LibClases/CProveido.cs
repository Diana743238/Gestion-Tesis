using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LibClases
{
    public class CProveido : CEntidad 
    {
        //=============== ATRIBUTOS =======================
        //-- Todos heredados de CEntidad ----
        //================ METODOS ========================
        //-------------- Constructores --------------------
        public CProveido() : base("TProveido")
        {
        }
        //------ Implementación de metodos abstractos -----
        public override string[] NombresAtributos()
        {
            return new string[] { "CodTesista", "Nombre", "ApellidoPaterno", "ApellidoMaterno", "DNI", "CarreraProfesional", "FechaNacimiento" };
        }
        //------ METODOS PROPIOS DE LA CLASE PROVEIDO -----
        //------ extraer el titulo de la tesis
        public string Titulo(string CodTesis)
        {
            string Nombre = "";
            string Consulta = "";
            Consulta = "Select TituloTesis from TTesis where CodTesis = '" + CodTesis +"'";
            Nombre = aConexion.EjecutarSelect(Consulta).ToString();

            return Nombre;
        }
        //------ extraer los nombres de los tesistas ------
        public DataTable Tesistas(string CodTesis)
        {
            DataTable tesistas;
            string consulta = "";
            consulta = "select T.* from TTesista T inner join TTesis S on (T.CodTesista = S.Autor1 or T.CodTesista = S.Autor2 or T.CodTesista = S.Autor3) where S.CodTesis = '"+CodTesis+"'";
            aConexion.EjecutarSelect(consulta);
            tesistas = aConexion.Datos.Tables[0];
            return tesistas;
        }
    }
}
