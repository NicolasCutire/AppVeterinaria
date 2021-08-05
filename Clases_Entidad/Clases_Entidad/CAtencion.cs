using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Entidad
{
    public class CAtencion:CEntidad
    {
        /* CONSTRUCTORES */
        public CAtencion() : base("Atencion", "ID_Atencion")
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
                   "'" + Atributos[5] + "'";

        }

        /* ************************************************* */
        public override string ArgumentoSentenciaUpDate(params object[] Atributos)
        {
            return "ID_Atencion = '" + Atributos[0] + "'," + // ----- Cod_Alumno
                   "ID_MASCOTA = '" + Atributos[1] + "'," +    // ----- Peterno
                   "ID_MEDICO = '" + Atributos[2] + "'," +    // ----- Peterno
                   "RESUMEN = '" + Atributos[3] + "'," +    // ----- Materno
                   "FECHA = '" + Atributos[4] + "'," +    // ----- Nombres
                   "OBSERVACIONES = '" + Atributos[5] + "'"; // ----- Cod_Carrera
        }
    }
}
