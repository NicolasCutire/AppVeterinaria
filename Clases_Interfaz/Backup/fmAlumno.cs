using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Clases_Entidad;

namespace Clases_Interfaz
{
	public class fmAlumno : fmMantenimiento
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label laCod_Alumno;
		private System.Windows.Forms.Label laNombres;
		private System.Windows.Forms.Label laCod_Carrera;
		private System.Windows.Forms.TextBox tbCod_Alumno;
		private System.Windows.Forms.TextBox tbNombres;
		private System.Windows.Forms.TextBox tbCod_Carrera;
		private System.ComponentModel.IContainer components = null;

		private CAlumno OAlumno;
		private System.Windows.Forms.TextBox tbPaterno;
		private System.Windows.Forms.Label laPaterno;
		private System.Windows.Forms.TextBox tbMaterno;
		private System.Windows.Forms.Label laMaterno;
        private ComboBox cboCarrera;
		private CCarrera OCarrera; // ----- Para verificar Referencia de integridad

		public fmAlumno() : base()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
			/* Crear objeto Carrera */
			OAlumno = new CAlumno();
			OCarrera = new CCarrera(); // ----- Para verificar referencias de integridad
			/* Inicializar mantenimiento con este objeto */
			Inicializar(OAlumno);
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
            this.laNombres = new System.Windows.Forms.Label();
            this.laCod_Carrera = new System.Windows.Forms.Label();
            this.tbCod_Alumno = new System.Windows.Forms.TextBox();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.tbCod_Carrera = new System.Windows.Forms.TextBox();
            this.tbPaterno = new System.Windows.Forms.TextBox();
            this.laPaterno = new System.Windows.Forms.Label();
            this.tbMaterno = new System.Windows.Forms.TextBox();
            this.laMaterno = new System.Windows.Forms.Label();
            this.cboCarrera = new System.Windows.Forms.ComboBox();
            this.paTitulo.SuspendLayout();
            this.paBotones.SuspendLayout();
            this.paDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // buGrabar
            // 
            this.buGrabar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            // 
            // paDatos
            // 
            this.paDatos.Controls.Add(this.cboCarrera);
            this.paDatos.Controls.Add(this.tbMaterno);
            this.paDatos.Controls.Add(this.laMaterno);
            this.paDatos.Controls.Add(this.tbPaterno);
            this.paDatos.Controls.Add(this.laPaterno);
            this.paDatos.Controls.Add(this.tbCod_Carrera);
            this.paDatos.Controls.Add(this.tbNombres);
            this.paDatos.Controls.Add(this.tbCod_Alumno);
            this.paDatos.Controls.Add(this.laCod_Carrera);
            this.paDatos.Controls.Add(this.laNombres);
            this.paDatos.Controls.Add(this.laCod_Alumno);
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
            this.laCod_Alumno.Location = new System.Drawing.Point(32, 32);
            this.laCod_Alumno.Name = "laCod_Alumno";
            this.laCod_Alumno.Size = new System.Drawing.Size(100, 23);
            this.laCod_Alumno.TabIndex = 0;
            this.laCod_Alumno.Text = "Cód. Alumno:";
            this.laCod_Alumno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // laNombres
            // 
            this.laNombres.Location = new System.Drawing.Point(32, 160);
            this.laNombres.Name = "laNombres";
            this.laNombres.Size = new System.Drawing.Size(100, 23);
            this.laNombres.TabIndex = 1;
            this.laNombres.Text = "Nombres:";
            this.laNombres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // laCod_Carrera
            // 
            this.laCod_Carrera.Location = new System.Drawing.Point(32, 200);
            this.laCod_Carrera.Name = "laCod_Carrera";
            this.laCod_Carrera.Size = new System.Drawing.Size(100, 23);
            this.laCod_Carrera.TabIndex = 2;
            this.laCod_Carrera.Text = "Cód. Carrera:";
            this.laCod_Carrera.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCod_Alumno
            // 
            this.tbCod_Alumno.Location = new System.Drawing.Point(136, 32);
            this.tbCod_Alumno.Name = "tbCod_Alumno";
            this.tbCod_Alumno.Size = new System.Drawing.Size(88, 20);
            this.tbCod_Alumno.TabIndex = 0;
            this.tbCod_Alumno.Leave += new System.EventHandler(this.tbCod_Alumno_Leave);
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(136, 160);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(296, 20);
            this.tbNombres.TabIndex = 4;
            // 
            // tbCod_Carrera
            // 
            this.tbCod_Carrera.Location = new System.Drawing.Point(136, 200);
            this.tbCod_Carrera.Name = "tbCod_Carrera";
            this.tbCod_Carrera.Size = new System.Drawing.Size(32, 20);
            this.tbCod_Carrera.TabIndex = 5;
            this.tbCod_Carrera.Leave += new System.EventHandler(this.tbCod_Carrera_Leave);
            // 
            // tbPaterno
            // 
            this.tbPaterno.Location = new System.Drawing.Point(136, 72);
            this.tbPaterno.Name = "tbPaterno";
            this.tbPaterno.Size = new System.Drawing.Size(296, 20);
            this.tbPaterno.TabIndex = 1;
            // 
            // laPaterno
            // 
            this.laPaterno.Location = new System.Drawing.Point(32, 72);
            this.laPaterno.Name = "laPaterno";
            this.laPaterno.Size = new System.Drawing.Size(100, 23);
            this.laPaterno.TabIndex = 6;
            this.laPaterno.Text = "Apellido Paterno:";
            this.laPaterno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbMaterno
            // 
            this.tbMaterno.Location = new System.Drawing.Point(136, 112);
            this.tbMaterno.Name = "tbMaterno";
            this.tbMaterno.Size = new System.Drawing.Size(296, 20);
            this.tbMaterno.TabIndex = 2;
            // 
            // laMaterno
            // 
            this.laMaterno.Location = new System.Drawing.Point(32, 112);
            this.laMaterno.Name = "laMaterno";
            this.laMaterno.Size = new System.Drawing.Size(100, 23);
            this.laMaterno.TabIndex = 8;
            this.laMaterno.Text = "Apellido Materno:";
            this.laMaterno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCarrera
            // 
            this.cboCarrera.FormattingEnabled = true;
            this.cboCarrera.Location = new System.Drawing.Point(174, 199);
            this.cboCarrera.Name = "cboCarrera";
            this.cboCarrera.Size = new System.Drawing.Size(211, 21);
            this.cboCarrera.TabIndex = 9;
            // 
            // fmAlumno
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(496, 334);
            this.Name = "fmAlumno";
            this.Text = "Mantenimiento de ALUMNOS";
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
			tbCod_Alumno.Text = "";
			/* Poner foco en el codigo de carrera */
			tbCod_Alumno.Focus();			
		}
		/* ************************************************* */
		public override void InicializarAtributosNoClave()
		{
			/* Inicializar atributos */
			tbPaterno.Text = "";
			tbMaterno.Text = "";
			tbNombres.Text = "";
			tbCod_Carrera.Text = "";			
		}
		/* ************************************************* */
		public override void RecuperarAtributos()
		{
			tbPaterno.Text = OAlumno.ValorAtributo("Paterno").ToString();
			tbMaterno.Text = OAlumno.ValorAtributo("Materno").ToString();
			tbNombres.Text = OAlumno.ValorAtributo("Nombres").ToString();
			tbCod_Carrera.Text = OAlumno.ValorAtributo("Cod_Carrera").ToString();
		}
		/* ************************************************* */
		public override object[] AsignarAtributos()
		{
			object [] Atributos = {tbCod_Alumno.Text,
								   tbPaterno.Text,
								   tbMaterno.Text,
								   tbNombres.Text,
								   tbCod_Carrera.Text};
			return Atributos;
		}
		#endregion Métodos Sobreescritos

		/* ************************************************* */
		#region Eventos adicionales
		private void tbCod_Alumno_Leave(object sender, System.EventArgs e)
		{
			/* Convertir Clave a mayusculas */
			tbCod_Alumno.Text = tbCod_Alumno.Text.ToUpper();
			/* Procesar clave para determinar si es un registro nuevo o existente */
			ProcesarClave();		
		}

		private void tbCod_Carrera_Leave(object sender, System.EventArgs e)
		{
			/* Convertir Cod_Carrera a mayusculas */
			tbCod_Carrera.Text = tbCod_Carrera.Text.ToUpper();
			/* Verificar referencia de integridad */
			if (!OCarrera.ExisteClave(tbCod_Carrera.Text))
			{
				MessageBox.Show("ERROR. Código de Carrera no existe en la Base de Datos...");
                tbCod_Carrera.Focus();
			}
		}
		#endregion Eventos adicionales

        private void fmAlumno_Load(object sender, EventArgs e)
        {
            OCarrera.RecuperarDatos("select * from Carrera");
            //for (int i = 0; i <= OCarrera.Datos.Tables[0].Rows.Count - 1; i++)
            //{
            //    cboCarrera.Items.Add(OCarrera.Datos.Tables[0].Rows[i]["Nom_Carrera"]);
            //}
            cboCarrera.DataSource = OCarrera.Datos.Tables[0];
            cboCarrera.DisplayMember = "Nom_Carrera";
        }
    }
}

