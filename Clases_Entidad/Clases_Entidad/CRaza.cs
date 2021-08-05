using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Entidad
{
    public class CRaza : CEntidad
    {
        /* CONSTRUCTORES */
        public CRaza() : base("Raza", "ID_RAZA")
        {

        }

        /* OTROS METODOS */
        /* ************************************************* */
        public override string ArgumentoSentenciaInsert(params object[] Atributos)
        {
            return "'" + Atributos[0] + "'," + // ----- Cod_mascota
                   "'" + Atributos[1] + "'," +
                   "'" + Atributos[2] + "'," +
                   "'" + Atributos[3] + "'";

        }

        /* ************************************************* */
        public override string ArgumentoSentenciaUpDate(params object[] Atributos)
        {
            return "ID_RAZA = '" + Atributos[0] + "'," +
                   "ID_ESPECIE = '" + Atributos[1] + "'," +
                   "DESCRIPCION = '" + Atributos[1] + "'," +
                   "DETALLES = '" + Atributos[2] + "'";
        }
    }
}