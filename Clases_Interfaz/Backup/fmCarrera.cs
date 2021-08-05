using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Clases_Entidad;

namespace Clases_Interfaz
{
	public class fmCarrera : fmMantenimiento
	{

		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox tbCod_Carrera;
		private System.Windows.Forms.TextBox tbNom_Carrera;
		private System.Windows.Forms.TextBox tbObservaciones;
		private System.Windows.Forms.Label laCod_Carrera;
		private System.Windows.Forms.Label laNom_Carrera;
		private System.Windows.Forms.Label laObservaciones;
		private CCarrera OCarrera;

		public fmCarrera() : base()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();            
			// TODO: Add any initialization after the InitializeComponent call
			/* Crear objeto Carrera */
            OCarrera = new CCarrera();
			/* Inicializar mantenimiento con este objeto */
			Inicializar(OCarrera);
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
			this.tbCod_Carrera = new System.Windows.Forms.TextBox();
			this.tbNom_Carrera = new System.Windows.Forms.TextBox();
			this.tbObservaciones = new System.Windows.Forms.TextBox();
			this.laCod_Carrera = new System.Windows.Forms.Label();
			this.laNom_Carrera = new System.Windows.Forms.Label();
			this.laObservaciones = new System.Windows.Forms.Label();
			this.paDatos.SuspendLayout();
			// 
			// paTitulo
			// 
			this.paTitulo.Name = "paTitulo";
			// 
			// laTitulo
			// 
			this.laTitulo.ForeColor = System.Drawing.Color.Yellow;
			this.laTitulo.Location = new System.Drawing.Point(112, 8);
			this.laTitulo.Name = "laTitulo";
			this.laTitulo.Size = new System.Drawing.Size(256, 23);
			this.laTitulo.Text = "CARRERAS PROFESIONALES";
			// 
			// paBotones
			// 
			this.paBotones.Name = "paBotones";
			// 
			// buSalir
			// 
			this.buSalir.Name = "buSalir";
			// 
			// buGrabar
			// 
			this.buGrabar.Name = "buGrabar";
			// 
			// paDatos
			// 
			this.paDatos.Controls.Add(this.laObservaciones);
			this.paDatos.Controls.Add(this.laNom_Carrera);
			this.paDatos.Controls.Add(this.laCod_Carrera);
			this.paDatos.Controls.Add(this.tbObservaciones);
			this.paDatos.Controls.Add(this.tbNom_Carrera);
			this.paDatos.Controls.Add(this.tbCod_Carrera);
			this.paDatos.Name = "paDatos";
			// 
			// tbCod_Carrera
			// 
			this.tbCod_Carrera.Location = new System.Drawing.Point(184, 24);
			this.tbCod_Carrera.Name = "tbCod_Carrera";
			this.tbCod_Carrera.Size = new System.Drawing.Size(32, 20);
			this.tbCod_Carrera.TabIndex = 0;
			this.tbCod_Carrera.Text = "";
			this.tbCod_Carrera.Leave += new System.EventHandler(this.tbCod_Carrera_Leave);
			// 
			// tbNom_Carrera
			// 
			this.tbNom_Carrera.Location = new System.Drawing.Point(184, 80);
			this.tbNom_Carrera.Name = "tbNom_Carrera";
			this.tbNom_Carrera.Size = new System.Drawing.Size(264, 20);
			this.tbNom_Carrera.TabIndex = 1;
			this.tbNom_Carrera.Text = "";
			// 
			// tbObservaciones
			// 
			this.tbObservaciones.Location = new System.Drawing.Point(184, 144);
			this.tbObservaciones.Name = "tbObservaciones";
			this.tbObservaciones.Size = new System.Drawing.Size(264, 20);
			this.tbObservaciones.TabIndex = 2;
			this.tbObservaciones.Text = "";
			// 
			// laCod_Carrera
			// 
			this.laCod_Carrera.Location = new System.Drawing.Point(72, 24);
			this.laCod_Carrera.Name = "laCod_Carrera";
			this.laCod_Carrera.TabIndex = 3;
			this.laCod_Carrera.Text = "Cód. Carrera:";
			this.laCod_Carrera.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// laNom_Carrera
			// 
			this.laNom_Carrera.Location = new System.Drawing.Point(72, 80);
			this.laNom_Carrera.Name = "laNom_Carrera";
			this.laNom_Carrera.TabIndex = 4;
			this.laNom_Carrera.Text = "Nombre Carrera:";
			this.laNom_Carrera.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// laObservaciones
			// 
			this.laObservaciones.Location = new System.Drawing.Point(72, 144);
			this.laObservaciones.Name = "laObservaciones";
			this.laObservaciones.TabIndex = 5;
			this.laObservaciones.Text = "Observaciones:";
			this.laObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// fmCarrera
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(496, 334);
			this.Name = "fmCarrera";
			this.Text = "Mantenimiento de CARRERAS";
			this.paDatos.ResumeLayout(false);

		}
		#endregion

		#region Métodos Sobreescritos
		/* Los siguientes métodos se sobre escriben, para adecuar este
		   formato, a las necesidades de un mantenimiento de Carreras */
		/* ************************************************* */
		public override void InicializarAtributoClave()
		{
			/* Inicializar atributo clave */
			tbCod_Carrera.Text = "";
			/* Poner foco en el codigo de carrera */
			tbCod_Carrera.Focus();			
		}
		/* ************************************************* */
		public override void InicializarAtributosNoClave()
		{
			/* Inicializar atributos */
			tbNom_Carrera.Text = "";
			tbObservaciones.Text = "";			
		}
		/* ************************************************* */
		public override void RecuperarAtributos()
		{
           tbNom_Carrera.Text = OCarrera.ValorAtributo("Nom_Carrera").ToString();
           tbObservaciones.Text = OCarrera.ValorAtributo("Observaciones").ToString();
		}
		/* ************************************************* */
		public override object[] AsignarAtributos()
		{
			Object [] Atributos = {tbCod_Carrera.Text,tbNom_Carrera.Text,tbObservaciones.Text};
			return Atributos;
		}
		#endregion Métodos Sobreescritos

		/* ************************************************* */
		#region Eventos adicionales
		private void tbCod_Carrera_Leave(object sender, System.EventArgs e)
		{
			/* Convertir Clave a mayusculas */
			tbCod_Carrera.Text = tbCod_Carrera.Text.ToUpper();
			/* Procesar clave para determinar si es un registro nuevo o existente */
			ProcesarClave();
		}
		#endregion Eventos adicionales
	}
}

