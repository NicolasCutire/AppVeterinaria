using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Entidad
{
    public class CMascotas: CEntidad
    {
        /* CONSTRUCTORES */
        public CMascotas() : base("Mascota", "ID_MASCOTA")
        {

        }

        /* OTROS METODOS */
        /* ************************************************* */
        public override string ArgumentoSentenciaInsert(params object[] Atributos)
        {
            return "'" + Atributos[0] + "'," + // ----- Cod_mascota
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
            return "ID_MASCOTA = '" + Atributos[0] + "'," + 
                   "ID_CLIENTE = '" + Atributos[1] + "'," +
                   "NOMBRE = '" + Atributos[5] + "'," +
                   "ID_ESPECIE = '" + Atributos[2] + "'," +
                   "ID_RAZA = '" + Atributos[3] + "'," +
                   "ID_JAULA = '" + Atributos[4] + "'," +              
                   "SEXO = '" + Atributos[6] + "'," +  
                   "F_NAC = '" + Atributos[7] + "'"; 
        }
    }
}
