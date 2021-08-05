using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Entidad
{
    public class CJaulas:CEntidad
    {
        /* CONSTRUCTORES */
        public CJaulas() : base("Jaulas", "ID_JAULA")
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
                   "'" + Atributos[6] + "'";

        }

        /* ************************************************* */
        public override string ArgumentoSentenciaUpDate(params object[] Atributos)
        {
            return "ID_JAULA = '" + Atributos[0] + "'," + // ----- Cod_Alumno
                   "TIPO_JAULA = '" + Atributos[1] + "'," +    // ----- Peterno
                   "CAPACIDAD = '" + Atributos[2] + "'," +    // ----- Materno
                   "Estado = '" + Atributos[3] + "'," +    // ----- Materno
                   "ALTO = '" + Atributos[4] + "'," +    // ----- Nombres
                   "ANCHO = '" + Atributos[5] + "'," +    // ----- Nombres
                   "FONDO = '" + Atributos[6] + "'"; // ----- Cod_Carrera
        }
    }
}
