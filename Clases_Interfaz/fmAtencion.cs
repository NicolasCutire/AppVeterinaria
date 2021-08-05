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
    public partial class fmAtencion : fmMantenimiento
    {
        private CAtencion OAtencion;
        private CMascotas OMascota;
        private CMedico OMedico;// ----- Para verificar Referencia de integridad
        public fmAtencion() : base()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitializeComponent call
            /* Crear objeto Carrera */
            OAtencion = new CAtencion();
            OMedico = new CMedico();
            OMascota = new CMascotas(); // ----- Para verificar referencias de integridad
                                        /* Inicializar mantenimiento con este objeto */
            Inicializar(OAtencion);
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
            dtpkFechaAtencion.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }
        /* ************************************************* */
        public override void RecuperarAtributos()
        {
            textBox1.Text = OAtencion.ValorAtributo("ID_Atencion").ToString();
            textBox2.Text = OAtencion.ValorAtributo("RESUMEN").ToString();
            dtpkFechaAtencion.Text = OAtencion.ValorAtributo("FECHA").ToString();
            textBox3.Text = OAtencion.ValorAtributo("OBSERVACIONES").ToString();
            comboBox1.Text = OAtencion.ValorAtributo("ID_MASCOTA").ToString();
            comboBox2.Text = OAtencion.ValorAtributo("ID_MEDICO").ToString();

        }
        /* ************************************************* */
        public override object[] AsignarAtributos()
        {
            object[] Atributos = {textBox1.Text,
                                   comboBox1.Text,
                                   comboBox2.Text,
                                   textBox2.Text,
                                   dtpkFechaAtencion.Value.Date.ToShortDateString(),
                                   textBox3.Text};
            return Atributos;
        }
        #endregion MEtodos sobresecritos

        private void fmAtencion_Load(object sender, EventArgs e)
        {
            OMascota.RecuperarDatos("select * from Mascota");
            OMedico.RecuperarDatos("select * from Medico");
            //for (int i = 0; i <= OCliente.Datos.Tables[0].Rows.Count - 1; i++)
            //{
            //    cboCarrera.Items.Add(OCliente.Datos.Tables[0].Rows[i]["Nom_Carrera"]);
            //}
            comboBox1.DataSource = OMascota.Datos.Tables[0];
            comboBox2.DataSource = OMedico.Datos.Tables[0];
            comboBox2.DisplayMember = "ID_MEDICO";
            comboBox1.DisplayMember = "ID_MASCOTA";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            /* Convertir Clave a mayusculas */
            textBox1.Text = textBox1.Text.ToUpper();
            /* Procesar clave para determinar si es un registro nuevo o existente */
            ProcesarClave();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            /* Convertir Cod_Carrera a mayusculas */
            comboBox1.Text = comboBox1.Text.ToUpper();
            /* Verificar referencia de integridad */
            if (!OMascota.ExisteClave(comboBox1.Text))
            {
                MessageBox.Show("ERROR. Código de Mascota no existe en la Base de Datos...");
                comboBox1.Focus();
            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            /* Convertir Cod_Carrera a mayusculas */
            comboBox2.Text = comboBox2.Text.ToUpper();
            /* Verificar referencia de integridad */
            if (!OMedico.ExisteClave(comboBox2.Text))
            {
                MessageBox.Show("ERROR. Código de Medico no existe en la Base de Datos...");
                comboBox2.Focus();
            }
        }
    }
}
