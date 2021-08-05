using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Clases_Entidad;

namespace Clases_Interfaz
{
	public class fmMascotas : fmMantenimiento
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label laCod_Alumno;
		private System.Windows.Forms.Label laCod_Cliente;
		private System.Windows.Forms.TextBox tbCod_Mascota;
		private System.ComponentModel.IContainer components = null;

		private CMascotas OMascota;
		private System.Windows.Forms.TextBox tbNombre;
		private System.Windows.Forms.Label laPaterno;
        private TextBox tbSexo;
        private Label label3;
        private ComboBox cboNombreCliente;
        private DateTimePicker dtpkFechaNac;
        private Label label4;
        private ComboBox comboBox2;
        private Label label6;
        private ComboBox comboBox1;
        private Label label5;
        private ComboBox comboBox3;
        private Label label7;
        private CClientes OCliente;
        private CEspecie OEspecie;
        private CRaza ORaza;
        private CJaulas OJaula;// ----- Para verificar Referencia de integridad

		public fmMascotas() : base()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
			/* Crear objeto Carrera */
			OMascota = new CMascotas();
			OCliente = new CClientes();
            OEspecie = new CEspecie();
            ORaza = new CRaza();
            OJaula = new CJaulas();// ----- Para verificar referencias de integridad
                                       /* Inicializar mantenimiento con este objeto */
            Inicializar(OMascota);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.laCod_Alumno = new System.Windows.Forms.Label();
            this.laCod_Cliente = new System.Windows.Forms.Label();
            this.tbCod_Mascota = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.laPaterno = new System.Windows.Forms.Label();
            this.tbSexo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNombreCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkFechaNac = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.paTitulo.SuspendLayout();
            this.paBotones.SuspendLayout();
            this.paDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // paBotones
            // 
            this.paBotones.Location = new System.Drawing.Point(0, 264);
            // 
            // buGrabar
            // 
            this.buGrabar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            // 
            // paDatos
            // 
            this.paDatos.Controls.Add(this.comboBox3);
            this.paDatos.Controls.Add(this.label7);
            this.paDatos.Controls.Add(this.comboBox2);
            this.paDatos.Controls.Add(this.label6);
            this.paDatos.Controls.Add(this.comboBox1);
            this.paDatos.Controls.Add(this.label5);
            this.paDatos.Controls.Add(this.dtpkFechaNac);
            this.paDatos.Controls.Add(this.label4);
            this.paDatos.Controls.Add(this.cboNombreCliente);
            this.paDatos.Controls.Add(this.tbSexo);
            this.paDatos.Controls.Add(this.label3);
            this.paDatos.Controls.Add(this.tbNombre);
            this.paDatos.Controls.Add(this.laPaterno);
            this.paDatos.Controls.Add(this.tbCod_Mascota);
            this.paDatos.Controls.Add(this.laCod_Cliente);
            this.paDatos.Controls.Add(this.laCod_Alumno);
            this.paDatos.Size = new System.Drawing.Size(496, 232);
            this.paDatos.Paint += new System.Windows.Forms.PaintEventHandler(this.paDatos_Paint);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(208, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // laCod_Alumno
            // 
            this.laCod_Alumno.Location = new System.Drawing.Point(3, 2);
            this.laCod_Alumno.Name = "laCod_Alumno";
            this.laCod_Alumno.Size = new System.Drawing.Size(100, 23);
            this.laCod_Alumno.TabIndex = 0;
            this.laCod_Alumno.Text = "Cód. Mascota";
            this.laCod_Alumno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // laCod_Cliente
            // 
            this.laCod_Cliente.Location = new System.Drawing.Point(1, 120);
            this.laCod_Cliente.Name = "laCod_Cliente";
            this.laCod_Cliente.Size = new System.Drawing.Size(100, 23);
            this.laCod_Cliente.TabIndex = 2;
            this.laCod_Cliente.Text = "Cód. Cliente:";
            this.laCod_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCod_Mascota
            // 
            this.tbCod_Mascota.Location = new System.Drawing.Point(107, 2);
            this.tbCod_Mascota.Name = "tbCod_Mascota";
            this.tbCod_Mascota.Size = new System.Drawing.Size(88, 20);
            this.tbCod_Mascota.TabIndex = 0;
            this.tbCod_Mascota.Leave += new System.EventHandler(this.tbCod_Alumno_Leave);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(107, 28);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(296, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // laPaterno
            // 
            this.laPaterno.Location = new System.Drawing.Point(3, 28);
            this.laPaterno.Name = "laPaterno";
            this.laPaterno.Size = new System.Drawing.Size(100, 23);
            this.laPaterno.TabIndex = 6;
            this.laPaterno.Text = "Nombre";
            this.laPaterno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSexo
            // 
            this.tbSexo.Location = new System.Drawing.Point(107, 54);
            this.tbSexo.Name = "tbSexo";
            this.tbSexo.Size = new System.Drawing.Size(296, 20);
            this.tbSexo.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sexo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboNombreCliente
            // 
            this.cboNombreCliente.FormattingEnabled = true;
            this.cboNombreCliente.Location = new System.Drawing.Point(107, 122);
            this.cboNombreCliente.Name = "cboNombreCliente";
            this.cboNombreCliente.Size = new System.Drawing.Size(141, 21);
            this.cboNombreCliente.TabIndex = 14;
            this.cboNombreCliente.Leave += new System.EventHandler(this.cboNombreCliente_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "FechaNacimiento:";
            // 
            // dtpkFechaNac
            // 
            this.dtpkFechaNac.Location = new System.Drawing.Point(107, 84);
            this.dtpkFechaNac.Name = "dtpkFechaNac";
            this.dtpkFechaNac.Size = new System.Drawing.Size(200, 20);
            this.dtpkFechaNac.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(1, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cód. Especie:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(107, 176);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(141, 21);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.Leave += new System.EventHandler(this.comboBox2_Leave);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(1, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cód. Raza:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(107, 199);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(141, 21);
            this.comboBox3.TabIndex = 22;
            this.comboBox3.Leave += new System.EventHandler(this.comboBox3_Leave);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(1, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Cód. Jaula:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fmMascotas
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(496, 304);
            this.Name = "fmMascotas";
            this.Text = "Mantenimiento de MASCOTAS";
            this.Load += new System.EventHandler(this.fmAlumno_Load);
            this.paTitulo.ResumeLayout(false);
            this.paBotones.ResumeLayout(false);
            this.paDatos.ResumeLayout(false);
            this.paDatos.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region Métodos Sobreescritos
		/* Los siguientes métodos se sobre escriben, para adecuar este
		   formato, a las necesidades de un mantenimiento de Alumnos */
		/* ************************************************* */
		public override void InicializarAtributoClave()
		{
			/* Inicializar atributo clave */
			tbCod_Mascota.Text = "";
			/* Poner foco en el codigo de carrera */
			tbCod_Mascota.Focus();			
		}
		/* ************************************************* */
		public override void InicializarAtributosNoClave()
		{
			/* Inicializar atributos */
			tbNombre.Text = "";
			cboNombreCliente.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            tbSexo.Text = "";
            dtpkFechaNac.Text ="";
		}
		/* ************************************************* */
		public override void RecuperarAtributos()
		{
			tbNombre.Text = OMascota.ValorAtributo("NOMBRE").ToString();
            cboNombreCliente.Text = OMascota.ValorAtributo("ID_CLIENTE").ToString();
            comboBox1.Text = OMascota.ValorAtributo("ID_ESPECIE").ToString();
			comboBox2.Text = OMascota.ValorAtributo("ID_RAZA").ToString();
            comboBox3.Text = OMascota.ValorAtributo("ID_JAULA").ToString();
            tbSexo.Text = OMascota.ValorAtributo("SEXO").ToString();
            dtpkFechaNac.Text = OMascota.ValorAtributo("F_NAC").ToString();
		}
		/* ************************************************* */
		public override object[] AsignarAtributos()
		{
            object[] Atributos = {tbCod_Mascota.Text,
                                   cboNombreCliente.Text,
                                   tbNombre.Text,
                                   comboBox1.Text,
                                   comboBox2.Text,
                                   comboBox3.Text,					   
								   tbSexo.Text,
                                   dtpkFechaNac.Value.Date.ToShortDateString()};
			return Atributos;
		}
		#endregion Métodos Sobreescritos

		/* ************************************************* */
		#region Eventos adicionales
		private void tbCod_Alumno_Leave(object sender, System.EventArgs e)
		{
			/* Convertir Clave a mayusculas */
			tbCod_Mascota.Text = tbCod_Mascota.Text.ToUpper();
			/* Procesar clave para determinar si es un registro nuevo o existente */
			ProcesarClave();		
		}

		private void tbCod_Carrera_Leave(object sender, System.EventArgs e)
		{
            
		}
		#endregion Eventos adicionales

        private void fmAlumno_Load(object sender, EventArgs e)
        {
            OCliente.RecuperarDatos("select * from Clientes");
            OEspecie.RecuperarDatos("select * from Especie");
            ORaza.RecuperarDatos("select * from Raza");
            OJaula.RecuperarDatos("select * from Jaulas");
            //for (int i = 0; i <= OCliente.Datos.Tables[0].Rows.Count - 1; i++)
            //{
            //    cboCarrera.Items.Add(OCliente.Datos.Tables[0].Rows[i]["Nom_Carrera"]);
            //}
            cboNombreCliente.DataSource = OCliente.Datos.Tables[0];                   
            cboNombreCliente.DisplayMember = "ID_CLIENTE";
            comboBox1.DataSource = OEspecie.Datos.Tables[0];
            comboBox1.DisplayMember = "ID_ESPECIE";
            comboBox2.DataSource = ORaza.Datos.Tables[0];
            comboBox2.DisplayMember = "ID_RAZA";
            comboBox3.DataSource = OJaula.Datos.Tables[0];
            comboBox3.DisplayMember = "ID_JAULA ";

        }

        private void paDatos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboNombreCliente_Leave(object sender, EventArgs e)
        {
            /* Convertir Cod_Carrera a mayusculas */
            cboNombreCliente.Text = cboNombreCliente.Text.ToUpper();
            /* Verificar referencia de integridad */
            if (!OCliente.ExisteClave(cboNombreCliente.Text))
            {
                MessageBox.Show("ERROR. Código de Cliente no existe en la Base de Datos...");
                cboNombreCliente.Focus();
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            /* Convertir Cod_Carrera a mayusculas */
            comboBox1.Text = comboBox1.Text.ToUpper();
            /* Verificar referencia de integridad */
            if (!OEspecie.ExisteClave(comboBox1.Text))
            {
                MessageBox.Show("ERROR. Código de especie no existe en la Base de Datos...");
                comboBox1.Focus();
            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            /* Convertir Cod_Carrera a mayusculas */
            comboBox2.Text = comboBox2.Text.ToUpper();
            /* Verificar referencia de integridad */
            if (!ORaza.ExisteClave(comboBox2.Text))
            {
                MessageBox.Show("ERROR. Código de Raza no existe en la Base de Datos...");
                comboBox2.Focus();
            }
        }

        private void comboBox3_Leave(object sender, EventArgs e)
        {
            /* Convertir Cod_Carrera a mayusculas */
            comboBox3.Text = comboBox3.Text.ToUpper();
            /* Verificar referencia de integridad */
            if (!OJaula.ExisteClave(comboBox3.Text))
            {
                MessageBox.Show("ERROR. Código de Jaula no existe en la Base de Datos...");
                comboBox3.Focus();
            }
        }
    }
}

