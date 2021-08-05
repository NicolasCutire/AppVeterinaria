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
    public partial class fmAdministrador : fmMantenimiento
    {
        private CAdministrador OAdministrador;
        private CUsuarios OUsuario; // ----- Para verificar Referencia de integridad
        public fmAdministrador() : base()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitializeComponent call
            /* Crear objeto Carrera */
            OAdministrador = new CAdministrador();
            OUsuario = new CUsuarios(); // ----- Para verificar referencias de integridad
                                        /* Inicializar mantenimiento con este objeto */
            Inicializar(OAdministrador);
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
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox1.Text = "";
        }
        /* ************************************************* */
        public override void RecuperarAtributos()
        {
            textBox1.Text = OAdministrador.ValorAtributo("ID_ADMIN").ToString();
            textBox2.Text = OAdministrador.ValorAtributo("NOMBRE").ToString();
            textBox3.Text = OAdministrador.ValorAtributo("APELLIDO_P").ToString();
            textBox4.Text = OAdministrador.ValorAtributo("APELLIDO_M").ToString();
            textBox5.Text = OAdministrador.ValorAtributo("DIRECCION").ToString();
            textBox7.Text = OAdministrador.ValorAtributo("CELULAR").ToString();
            textBox8.Text = OAdministrador.ValorAtributo("EMAIL").ToString();
            comboBox1.Text = OAdministrador.ValorAtributo("ID_USUARIO").ToString();

        }
        /* ************************************************* */
        public override object[] AsignarAtributos()
        {
            object[] Atributos = {textBox1.Text,
                                   comboBox1.Text,
                                   textBox2.Text,
                                   textBox3.Text,
                                   textBox4.Text,
                                   textBox5.Text,
                                   textBox7.Text,
                                   textBox8.Text};
            return Atributos;
        }
        #endregion Métodos Sobreescritos

        /* ************************************************* */
        #region Eventos adicionales
        
        #endregion

        private void textBox1_Leave(object sender, EventArgs e)
        {
            /* Convertir Clave a mayusculas */
            textBox1.Text = textBox1.Text.ToUpper();
            /* Procesar clave para determinar si es un registro nuevo o existente */
            ProcesarClave();
        }

        private void comboBox1_Leave_1(object sender, EventArgs e)
        {
            /* Convertir Cod_Carrera a mayusculas */
            comboBox1.Text = comboBox1.Text.ToUpper();
            /* Verificar referencia de integridad */
            if (!OUsuario.ExisteClave(comboBox1.Text))
            {
                MessageBox.Show("ERROR. Código de Usuario no existe en la Base de Datos...");
                comboBox1.Focus();
            }
        }

        private void fmAdministrador_Load(object sender, EventArgs e)
        {
            OUsuario.RecuperarDatos("select * from Usuarios");
            //for (int i = 0; i <= OCliente.Datos.Tables[0].Rows.Count - 1; i++)
            //{
            //    cboCarrera.Items.Add(OCliente.Datos.Tables[0].Rows[i]["Nom_Carrera"]);
            //}
            comboBox1.DataSource = OUsuario.Datos.Tables[0];
            //cboCodCliente.DisplayMember = "ID_CLIENTE";                    
            comboBox1.DisplayMember = "ID_USUARIO";
        }
    }
}
