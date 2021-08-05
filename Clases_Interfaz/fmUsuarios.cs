using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases_Entidad;

namespace Clases_Interfaz
{
    public partial class fmUsuarios : fmMantenimiento
    {
        private CUsuarios OUsuarios;
        public fmUsuarios() : base()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            // TODO: Add any initialization after the InitializeComponent call
            /* Crear objeto Carrera */
            OUsuarios = new CUsuarios();
            /* Inicializar mantenimiento con este objeto */
            Inicializar(OUsuarios);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #region Métodos Sobreescritos
        /* Los siguientes métodos se sobre escriben, para adecuar este
		   formato, a las necesidades de un mantenimiento de Carreras */
        /* ************************************************* */
        public override void InicializarAtributoClave()
        {
            /* Inicializar atributo clave */
            textBox1.Text = "";
            /* Poner foco en el codigo de carrera */
            textBox1.Focus();
        }
        /* ************************************************* */
        public override void InicializarAtributosNoClave()
        {
            /* Inicializar atributos */
            
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }
        /* ************************************************* */
        public override void RecuperarAtributos()
        {
            textBox1.Text = OUsuarios.ValorAtributo("ID_USUARIO").ToString();
            textBox2.Text = OUsuarios.ValorAtributo("PASWORD").ToString();
            textBox3.Text = OUsuarios.ValorAtributo("EMAIL").ToString();
            textBox4.Text = OUsuarios.ValorAtributo("PREG_SECRETA").ToString();
            textBox5.Text = OUsuarios.ValorAtributo("RESP_SECRETA").ToString();
            textBox6.Text = OUsuarios.ValorAtributo("NOMBRE").ToString();
            textBox7.Text = OUsuarios.ValorAtributo("APELLIDO_P").ToString();
            textBox8.Text = OUsuarios.ValorAtributo("APELLIDO_M").ToString();

        }
        /* ************************************************* */
        public override object[] AsignarAtributos()
        {
            Object[] Atributos = {textBox1.Text,textBox2.Text,textBox3.Text,
            textBox4.Text,textBox5.Text,textBox6.Text,textBox7.Text,textBox8.Text};
            return Atributos;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            /* Convertir Clave a mayusculas */
            textBox1.Text = textBox1.Text.ToUpper();
            /* Procesar clave para determinar si es un registro nuevo o existente */
            ProcesarClave();
        }
        #endregion Métodos Sobreescritos

        /* ************************************************* */
    }
}
