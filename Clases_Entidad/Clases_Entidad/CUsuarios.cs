using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Entidad
{
    public class CUsuarios : CEntidad
    {
        /* CONSTRUCTORES */
        public CUsuarios() : base("Usuarios", "ID_USUARIO")
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
                   "'" + Atributos[6] + "'," + // ----- Comuna
                   "'" + Atributos[7] + "'";  // ----- Email

        }

        /* ************************************************* */
        public override string ArgumentoSentenciaUpDate(params object[] Atributos)
        {
            return "ID_USUARIO = '" + Atributos[0] + "'," + 
                   "PASWORD = '" + Atributos[1] + "'," +    
                   "EMAIL = '" + Atributos[2] + "'," +    
                   "PREG_SECRETA = '" + Atributos[3] + "'," +    
                   "RESP_SECRETA = '" + Atributos[4] + "'," +    
                   "NOMBRE = '" + Atributos[5] + "'," +    
                   "APELLIDO_P = '" + Atributos[6] + "'," +    
                   "APELLIDO_M = '" + Atributos[7] + "'"; 
        }
    }
}
