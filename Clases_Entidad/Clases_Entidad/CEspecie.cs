using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Entidad
{
    public class CEspecie : CEntidad
    {
        /* CONSTRUCTORES */
        public CEspecie() : base("Especie", "ID_ESPECIE")
        {

        }

        /* OTROS METODOS */
        /* ************************************************* */
        public override string ArgumentoSentenciaInsert(params object[] Atributos)
        {
            return "'" + Atributos[0] + "'," + // ----- Cod_mascota
                   "'" + Atributos[1] + "'," +
                   "'" + Atributos[2] + "'";

        }

        /* ************************************************* */
        public override string ArgumentoSentenciaUpDate(params object[] Atributos)
        {
            return "ID_ESPECIE = '" + Atributos[0] + "'," +
                   "DESCRIPCION = '" + Atributos[1] + "'," +
                   "DETALLES = '" + Atributos[2] + "'";
        }
    }
}
