using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Entidad
{
    /// <summary>
	/// Summary description for CAlumno.
	/// </summary>
	public class CClientes : CEntidad
    {
        /* CONSTRUCTORES */
        public CClientes() : base("Clientes", "ID_CLIENTE")
        {

        }

        /* OTROS METODOS */
        /* ************************************************* */
        public override string ArgumentoSentenciaInsert(params object[] Atributos)
        {
            return "'" + Atributos[0] + "'," + // ----- Cod_Cliente
                   "'" + Atributos[1] + "'," + // ----- Nombres
                   "'" + Atributos[2] + "'," + // ----- Paterno
                   "'" + Atributos[3] + "'," + // ----- Materno
                   "'" + Atributos[4] + "'," + // ----- Direccion
                   "'" + Atributos[5] + "'," + // ----- Dpto
                   "'" + Atributos[6] + "'";  // ----- Email
                   
        }

        /* ************************************************* */
        public override string ArgumentoSentenciaUpDate(params object[] Atributos)
        {
            return "ID_CLIENTE = '" + Atributos[0] + "'," + // ----- Cod_Alumno
                   "NOMBRE = '" + Atributos[1] + "'," +    // ----- Peterno
                   "APELLIDO_P = '" + Atributos[2] + "'," +    // ----- Materno
                   "APELLIDO_M = '" + Atributos[3] + "'," +    // ----- Nombres
                   "DIRECCION = '" + Atributos[4] + "'," +    // ----- Nombres
                   "CELULAR = '" + Atributos[5] + "'," +    // ----- Nombres
                   "EMAIL = '" + Atributos[6] + "'"; // ----- Cod_Carrera
        }

    }
}
