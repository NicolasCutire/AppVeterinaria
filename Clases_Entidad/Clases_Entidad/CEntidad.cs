using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Clases_Entidad
{
    public class CEntidad
    {
        /* ATRIBUTOS */
        private string aNombreTabla;
        private string aAtributoClave;
        private DataSet aDatos;
        private SqlConnection aConexion; // ----- Solo para uso interno
        private SqlDataAdapter aAdaptador; // ----- Solo para uso interno

        /* CONSTRUCTORES */
        /*
		public CEntidad()
		{
          CEntidad("");
		}
		*/

        public CEntidad(string pNombreTabla,
                        string pAtributoClave)
        {
            aNombreTabla = pNombreTabla;
            aAtributoClave = pAtributoClave;
            aConexion = new SqlConnection("Data Source=USER\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Clinica_Veterinaria");
            //aConexion = new SqlConnection("Data Source=localhost;Integrated Security=SSPI;User='sa',password='';Initial Catalog=BDBiblioteca");
            //aConexion=new SqlConnection("Data Source=;Initial Catalog = BDBiblioteca;uid=");
            //aConexion = new SqlConnection("Data Source=;Initial Catalog = BDBiblioteca;uid=");
            aConexion.Open();
            aDatos = new DataSet();
            aAdaptador = new SqlDataAdapter();
        }

        /* PROPIEDADES */
        public string NombreTabla
        {
            get
            {
                return aNombreTabla;
            }
            set
            {
                aNombreTabla = value;
            }
        }

        public string AtributoClave
        {
            get
            {
                return aAtributoClave;
            }
            set
            {
                aAtributoClave = value;
            }
        }

        public DataSet Datos
        {
            get
            {
                return aDatos;
            }
            set
            {
                aDatos = value;
            }
        }
        /* OTROS METODOS */

        /* ************************************************* */
        /* Este método se utiliza para las sentencias INSERT, UPDATE y DELETE */
        public void EjecutarSentenciaSQL(string TextoSQL)
        {
            // ----- Crear objeto de comandos SQL para definir sentencia SQL 
            SqlCommand OComandoSQL;
            OComandoSQL = new SqlCommand(TextoSQL, aConexion);

            // ----- Ejecutar Comando 
            OComandoSQL.ExecuteNonQuery();
        }

        /* ************************************************* */
        /* Este método se utiliza para la sentencia Select.
		   Los datos lo devuelve en la propiedad Datos */
        public void RecuperarDatos(string TextoSQL)
        {
            // ----- Asignar al adaptador sentencia SQL 
            aAdaptador.SelectCommand = new SqlCommand(TextoSQL, aConexion);
            // ----- Asignar al adaptador sentencia SQL
            aDatos = new DataSet();
            aAdaptador.Fill(aDatos); // Los datos se llenan en el DataSet aDatos
        }

        /* ************************************************* */
        public virtual bool ExisteClave(params object[] Atributos)
        {
            /* La clave es el primer atributo */
            string Clave = Atributos[0].ToString();
            /* Construir sentencia Select */
            string TextoSQL = "Select * " +
                              " from " + aNombreTabla +
                              " where (" + aAtributoClave + "='" + Clave + "')";
            /* Ejecutar sentencia Select */
            RecuperarDatos(TextoSQL);

            /* Determinar si se recupero algun registro */
            return (aDatos.Tables[0].Rows.Count > 0);
        }

        /* ************************************************* */
        public virtual string ArgumentoSentenciaInsert(params object[] Atributos)
        {
            return "";
        }

        /* ************************************************* */
        public virtual void Insert(params object[] Atributos)
        {
            /* Generar sentencia INSERT */
            string TextoSQL = "INSERT INTO " + aNombreTabla +
                              " VALUES(" + ArgumentoSentenciaInsert(Atributos) + ")";
            /* Ejecutar sentencia INSERT */
            EjecutarSentenciaSQL(TextoSQL);
        }

        /* ************************************************* */
        public virtual string ArgumentoSentenciaUpDate(params object[] Atributos)
        {
            return "";
        }

        /* ************************************************* */
        public virtual void UpDate(params object[] Atributos)
        {
            /* Generar sentencia UpDate */
            string TextoSQL = "UPDATE " + aNombreTabla +
                              " SET " + ArgumentoSentenciaUpDate(Atributos) +
                              " WHERE " + aAtributoClave + " = '" + Atributos[0] + "'";
            /* Ejecutar sentencia UPDATE */
            EjecutarSentenciaSQL(TextoSQL);
        }

        /* ************************************************* */
        public virtual string ArgumentoSentenciaDelete(params object[] Atributos)
        {
            return "";
        }

        /* ************************************************* */
        public virtual void Delete(params object[] Atributos)
        {
            /* Generar sentencia Delete */
            string TextoSQL = "DELETE FROM " + aNombreTabla +
                " WHERE " + aAtributoClave + " = '" + Atributos[0] + "'";
            /* Ejecutar sentencia DELETE */
            EjecutarSentenciaSQL(TextoSQL);
        }
        /* ************************************************* */
        public virtual object ValorAtributo(string NombreAtributo)
        {
            /* Recupera un atributo del DataSet aDatos.
			 * Pre condicion: aDatos debe tener el resultado de haber ejecutado 
			 * el metodo RecuperarDatos, es decir, una sentencia Select */
            return aDatos.Tables[0].Rows[0][NombreAtributo];
        }
    }
}
