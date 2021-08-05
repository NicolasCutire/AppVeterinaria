using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Entidad
{
    public class CMedico:CEntidad
    {
        /* CONSTRUCTORES */
        public CMedico() : base("Medico", "ID_MEDICO")
        {

        }

        /* OTROS METODOS */
        /* ************************************************* */
        public override string ArgumentoSentenciaInsert(params object[] Atributos)
        {
            return "'" + Atributos[0] + "'," +
                   "'" + Atributos[1] + "'," +
                   "'" + Atributos[2] + "'," +
                   "'" + Atributos[3] + "'," +
                   "'" + Atributos[4] + "'," +
                   "'" + Atributos[5] + "'," +
                   "'" + Atributos[6] + "'," +
                   "'" + Atributos[7] + "'";

        }

        /* ************************************************* */
        public override string ArgumentoSentenciaUpDate(params object[] Atributos)
        {
            return "ID_MEDICO = '" + Atributos[0] + "'," + // ----- Cod_Alumno
                   "ID_USUARIO = '" + Atributos[1] + "'," +    // ----- Peterno
                   "NOMBRE = '" + Atributos[2] + "'," +    // ----- Materno
                   "APELLIDO_P = '" + Atributos[3] + "'," +    // ----- Nombres
                   "APELLIDO_M = '" + Atributos[4] + "'," +    // ----- Nombres
                   "DIRECCION = '" + Atributos[5] + "'," +    // ----- Nombres
                   "CELULAR = '" + Atributos[6] + "'," +    // ----- Nombres
                   "EMAIL = '" + Atributos[7] + "'"; // ----- Cod_Carrera
        }
    }
}
