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
    public partial class fmJaulas : fmMantenimiento
    {
        private CJaulas OJaulas; // ----- Para verificar Referencia de integridad
        public fmJaulas() : base()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitializeComponent call
            /* Crear objeto Carrera */
            OJaulas = new CJaulas(); // ----- Para verificar referencias de integridad
                                        /* Inicializar mantenimiento con este objeto */
            Inicializar(OJaulas);
        }
        #region Métodos Sobreescritos
        /* Los siguientes métodos se sobre escriben, para adecuar este
		   formato, a las necesidades de un mantenimiento de Alumnos */
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
        }
        /* ************************************************* */
        public override void RecuperarAtributos()
        {
            textBox1.Text = OJaulas.ValorAtributo("ID_JAULA").ToString();
            textBox2.Text = OJaulas.ValorAtributo("TIPO_JAULA").ToString();
            textBox6.Text = OJaulas.ValorAtributo("CAPACIDAD").ToString();
            textBox7.Text = OJaulas.ValorAtributo("ESTADO").ToString();
            textBox3.Text = OJaulas.ValorAtributo("ALTO").ToString();
            textBox4.Text = OJaulas.ValorAtributo("ANCHO").ToString();
            textBox5.Text = OJaulas.ValorAtributo("FONDO").ToString();

        }
        /* ************************************************* */
        public override object[] AsignarAtributos()
        {
            object[] Atributos = {textBox1.Text,                                   
                                   textBox2.Text,
                                   textBox6.Text,
                                   textBox7.Text,
                                   textBox3.Text,
                                   textBox4.Text,
                                   textBox5.Text };
            return Atributos;
        }
        #endregion MEtodos sobresecritos

        private void textBox1_Leave(object sender, EventArgs e)
        {
            /* Convertir Clave a mayusculas */
            textBox1.Text = textBox1.Text.ToUpper();
            /* Procesar clave para determinar si es un registro nuevo o existente */
            ProcesarClave();
        }
    }
}
