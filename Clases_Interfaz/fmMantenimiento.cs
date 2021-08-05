using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Clases_Entidad;

namespace Clases_Interfaz
{

	public class fmMantenimiento : System.Windows.Forms.Form
	{
        private CEntidad OEntidad;

		private System.ComponentModel.Container components = null;
		public System.Windows.Forms.Panel paTitulo;
		public System.Windows.Forms.Label laTitulo;
		public System.Windows.Forms.Panel paBotones;
		public System.Windows.Forms.Button buSalir;
		public System.Windows.Forms.Button buGrabar;
		private System.Windows.Forms.Label laMensaje;
		private System.Windows.Forms.Button buNuevo;
		public System.Windows.Forms.Panel paDatos;

		public fmMantenimiento()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.paTitulo = new System.Windows.Forms.Panel();
			this.laTitulo = new System.Windows.Forms.Label();
			this.paBotones = new System.Windows.Forms.Panel();
			this.buSalir = new System.Windows.Forms.Button();
			this.buGrabar = new System.Windows.Forms.Button();
			this.paDatos = new System.Windows.Forms.Panel();
			this.laMensaje = new System.Windows.Forms.Label();
			this.buNuevo = new System.Windows.Forms.Button();
			this.paTitulo.SuspendLayout();
			this.paBotones.SuspendLayout();
			this.SuspendLayout();
			// 
			// paTitulo
			// 
			this.paTitulo.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.paTitulo.Controls.Add(this.laTitulo);
			this.paTitulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.paTitulo.Location = new System.Drawing.Point(0, 0);
			this.paTitulo.Name = "paTitulo";
			this.paTitulo.Size = new System.Drawing.Size(496, 32);
			this.paTitulo.TabIndex = 1;
			// 
			// laTitulo
			// 
			this.laTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.laTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.laTitulo.Location = new System.Drawing.Point(198, 5);
			this.laTitulo.Name = "laTitulo";
			this.laTitulo.TabIndex = 2;
			this.laTitulo.Text = "label1";
			// 
			// paBotones
			// 
			this.paBotones.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.paBotones.Controls.Add(this.buNuevo);
			this.paBotones.Controls.Add(this.laMensaje);
			this.paBotones.Controls.Add(this.buSalir);
			this.paBotones.Controls.Add(this.buGrabar);
			this.paBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.paBotones.Location = new System.Drawing.Point(0, 294);
			this.paBotones.Name = "paBotones";
			this.paBotones.Size = new System.Drawing.Size(496, 40);
			this.paBotones.TabIndex = 4;
			// 
			// buSalir
			// 
			this.buSalir.Location = new System.Drawing.Point(403, 9);
			this.buSalir.Name = "buSalir";
			this.buSalir.TabIndex = 5;
			this.buSalir.Text = "&Salir";
			this.buSalir.Click += new System.EventHandler(this.buSalir_Click);
			// 
			// buGrabar
			// 
			this.buGrabar.Location = new System.Drawing.Point(19, 9);
			this.buGrabar.Name = "buGrabar";
			this.buGrabar.TabIndex = 6;
			this.buGrabar.Text = "&Grabar";
			this.buGrabar.Click += new System.EventHandler(this.buGrabar_Click);
			// 
			// paDatos
			// 
			this.paDatos.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.paDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.paDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.paDatos.Location = new System.Drawing.Point(0, 32);
			this.paDatos.Name = "paDatos";
			this.paDatos.Size = new System.Drawing.Size(496, 262);
			this.paDatos.TabIndex = 3;
			// 
			// laMensaje
			// 
			this.laMensaje.ForeColor = System.Drawing.Color.Red;
			this.laMensaje.Location = new System.Drawing.Point(112, 8);
			this.laMensaje.Name = "laMensaje";
			this.laMensaje.Size = new System.Drawing.Size(160, 23);
			this.laMensaje.TabIndex = 7;
			// 
			// buNuevo
			// 
			this.buNuevo.Location = new System.Drawing.Point(312, 8);
			this.buNuevo.Name = "buNuevo";
			this.buNuevo.TabIndex = 8;
			this.buNuevo.Text = "Nuevo";
			this.buNuevo.Click += new System.EventHandler(this.buNuevo_Click);
			// 
			// fmMantenimiento
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(496, 334);
			this.Controls.Add(this.paDatos);
			this.Controls.Add(this.paBotones);
			this.Controls.Add(this.paTitulo);
			this.Name = "fmMantenimiento";
			this.Text = "Mantenimiento";
			this.paTitulo.ResumeLayout(false);
			this.paBotones.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/* ************************************************* */
		public void Inicializar(CEntidad OEntidad_)
		{
		   OEntidad = OEntidad_;
		}

		/* ************************************************* */
		public virtual void InicializarAtributoClave()
		{
			
		}
		/* ************************************************* */
		public virtual void InicializarAtributosNoClave()
		{
			
		}

		/* ************************************************* */
		public virtual void InicializarAtributos()
		{
			InicializarAtributoClave();
			InicializarAtributosNoClave();
			laMensaje.Text = "";
		}

		/* ************************************************* */
		public virtual void RecuperarAtributos()
		{

		}

		/* ************************************************* */
		public virtual void ProcesarClave()
		{
			/* Recuperar atributos, el primer atributo es la clave */
			object[] Atributos = AsignarAtributos();
			// ----- Verificar si existe clave primaria 
			if (OEntidad.ExisteClave(Atributos))
			{
				/* Registro existente, Recuperar Atributos */
				RecuperarAtributos();
				laMensaje.Text = "Registro Existente";
			}
			else
			{
				/* Registro nuevo, inicializar atributos no clave */
				InicializarAtributosNoClave();
				laMensaje.Text = "Registro Nuevo";
			}
		}

		/* ************************************************* */
		public virtual object[] AsignarAtributos()
		{
           return null;
		}

		/* ************************************************* */
		public virtual void ProcesarGrabar()
		{
			/* Recuperar atributos, el primer atributo es la clave */
			object[] Atributos = AsignarAtributos();
			// ----- Verificar si existe clave primaria 
			if (OEntidad.ExisteClave(Atributos))
              OEntidad.UpDate(Atributos);
			else
              OEntidad.Insert(Atributos);
			/* Inicializar un nuevo formato */
			InicializarAtributos();
		}

		/* ************************************************* */
		private void buGrabar_Click(object sender, System.EventArgs e)
		{
		  ProcesarGrabar();
		}

		/* ************************************************* */
		private void buSalir_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		/* ************************************************* */
		private void buNuevo_Click(object sender, System.EventArgs e)
		{
			InicializarAtributos();
		}
	}
}
