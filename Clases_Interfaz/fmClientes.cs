using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Clases_Entidad;

namespace Clases_Interfaz
{
	public class fmClientes : fmMantenimiento
	{

		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox tbCod_Cliente;
		private System.Windows.Forms.TextBox tbNom_Cliente;
		private System.Windows.Forms.TextBox tbAP;
		private System.Windows.Forms.Label laCod_Carrera;
		private System.Windows.Forms.Label laNom_Carrera;
		private System.Windows.Forms.Label laObservaciones;
        private Label label7;
        private TextBox tbCelular;
        private Label label2;
        private TextBox tbDir;
        private Label label1;
        private TextBox tbAM;
        private Label label3;
        private TextBox tbEmail;
        private CClientes OCliente;

		public fmClientes() : base()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();            
			// TODO: Add any initialization after the InitializeComponent call
			/* Crear objeto Carrera */
            OCliente = new CClientes();
			/* Inicializar mantenimiento con este objeto */
			Inicializar(OCliente);
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
            this.tbCod_Cliente = new System.Windows.Forms.TextBox();
            this.tbNom_Cliente = new System.Windows.Forms.TextBox();
            this.tbAP = new System.Windows.Forms.TextBox();
            this.laCod_Carrera = new System.Windows.Forms.Label();
            this.laNom_Carrera = new System.Windows.Forms.Label();
            this.laObservaciones = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCelular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.paTitulo.SuspendLayout();
            this.paBotones.SuspendLayout();
            this.paDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // laTitulo
            // 
            this.laTitulo.ForeColor = System.Drawing.Color.Yellow;
            this.laTitulo.Location = new System.Drawing.Point(112, 8);
            this.laTitulo.Size = new System.Drawing.Size(256, 23);
            this.laTitulo.Text = "CLIENTES";
            // 
            // paDatos
            // 
            this.paDatos.Controls.Add(this.label3);
            this.paDatos.Controls.Add(this.tbEmail);
            this.paDatos.Controls.Add(this.label7);
            this.paDatos.Controls.Add(this.tbCelular);
            this.paDatos.Controls.Add(this.label2);
            this.paDatos.Controls.Add(this.tbDir);
            this.paDatos.Controls.Add(this.label1);
            this.paDatos.Controls.Add(this.tbAM);
            this.paDatos.Controls.Add(this.laObservaciones);
            this.paDatos.Controls.Add(this.laNom_Carrera);
            this.paDatos.Controls.Add(this.laCod_Carrera);
            this.paDatos.Controls.Add(this.tbAP);
            this.paDatos.Controls.Add(this.tbNom_Cliente);
            this.paDatos.Controls.Add(this.tbCod_Cliente);
            // 
            // tbCod_Cliente
            // 
            this.tbCod_Cliente.Location = new System.Drawing.Point(105, 2);
            this.tbCod_Cliente.Name = "tbCod_Cliente";
            this.tbCod_Cliente.Size = new System.Drawing.Size(77, 20);
            this.tbCod_Cliente.TabIndex = 0;
            this.tbCod_Cliente.Leave += new System.EventHandler(this.tbCod_Carrera_Leave);
            // 
            // tbNom_Cliente
            // 
            this.tbNom_Cliente.Location = new System.Drawing.Point(105, 28);
            this.tbNom_Cliente.Name = "tbNom_Cliente";
            this.tbNom_Cliente.Size = new System.Drawing.Size(264, 20);
            this.tbNom_Cliente.TabIndex = 1;
            // 
            // tbAP
            // 
            this.tbAP.Location = new System.Drawing.Point(105, 54);
            this.tbAP.Name = "tbAP";
            this.tbAP.Size = new System.Drawing.Size(264, 20);
            this.tbAP.TabIndex = 2;
            // 
            // laCod_Carrera
            // 
            this.laCod_Carrera.Location = new System.Drawing.Point(-28, 2);
            this.laCod_Carrera.Name = "laCod_Carrera";
            this.laCod_Carrera.Size = new System.Drawing.Size(100, 23);
            this.laCod_Carrera.TabIndex = 3;
            this.laCod_Carrera.Text = "Cod:Cliente";
            this.laCod_Carrera.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // laNom_Carrera
            // 
            this.laNom_Carrera.Location = new System.Drawing.Point(-7, 25);
            this.laNom_Carrera.Name = "laNom_Carrera";
            this.laNom_Carrera.Size = new System.Drawing.Size(100, 23);
            this.laNom_Carrera.TabIndex = 4;
            this.laNom_Carrera.Text = "Nombre Cliente:";
            this.laNom_Carrera.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // laObservaciones
            // 
            this.laObservaciones.Location = new System.Drawing.Point(-7, 48);
            this.laObservaciones.Name = "laObservaciones";
            this.laObservaciones.Size = new System.Drawing.Size(100, 23);
            this.laObservaciones.TabIndex = 5;
            this.laObservaciones.Text = "Apellido Paterno";
            this.laObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-7, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Apellido Materno";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAM
            // 
            this.tbAM.Location = new System.Drawing.Point(105, 77);
            this.tbAM.Name = "tbAM";
            this.tbAM.Size = new System.Drawing.Size(264, 20);
            this.tbAM.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(-7, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Direccion";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbDir
            // 
            this.tbDir.Location = new System.Drawing.Point(105, 100);
            this.tbDir.Name = "tbDir";
            this.tbDir.Size = new System.Drawing.Size(264, 20);
            this.tbDir.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(-8, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Celular";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCelular
            // 
            this.tbCelular.Location = new System.Drawing.Point(104, 126);
            this.tbCelular.Name = "tbCelular";
            this.tbCelular.Size = new System.Drawing.Size(264, 20);
            this.tbCelular.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(-7, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Email";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(105, 152);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(264, 20);
            this.tbEmail.TabIndex = 20;
            // 
            // fmClientes
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(496, 334);
            this.Name = "fmClientes";
            this.Text = "Mantenimiento de CLIENTES";
            this.paTitulo.ResumeLayout(false);
            this.paBotones.ResumeLayout(false);
            this.paDatos.ResumeLayout(false);
            this.paDatos.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region Métodos Sobreescritos
		/* Los siguientes métodos se sobre escriben, para adecuar este
		   formato, a las necesidades de un mantenimiento de Carreras */
		/* ************************************************* */
		public override void InicializarAtributoClave()
		{
			/* Inicializar atributo clave */
			tbCod_Cliente.Text = "";
			/* Poner foco en el codigo de carrera */
			tbCod_Cliente.Focus();			
		}
		/* ************************************************* */
		public override void InicializarAtributosNoClave()
		{
			/* Inicializar atributos */
			tbNom_Cliente.Text = "";
			tbAP.Text = "";
            tbAM.Text = "";
            tbDir.Text = "";
            tbCelular.Text = "";
            tbEmail.Text = "";
		}
		/* ************************************************* */
		public override void RecuperarAtributos()
		{
            tbNom_Cliente.Text = OCliente.ValorAtributo("NOMBRE").ToString();
            tbAP.Text = OCliente.ValorAtributo("APELLIDO_P").ToString();
            tbAM.Text = OCliente.ValorAtributo("APELLIDO_M").ToString();
            tbDir.Text = OCliente.ValorAtributo("DIRECCION").ToString();
            tbCelular.Text = OCliente.ValorAtributo("CELULAR").ToString();
            tbEmail.Text = OCliente.ValorAtributo("EMAIL").ToString();

        }
		/* ************************************************* */
		public override object[] AsignarAtributos()
		{
			Object [] Atributos = {tbCod_Cliente.Text,
                                    tbNom_Cliente.Text,
                                    tbAP.Text,
                                    tbAM.Text,
                                    tbDir.Text,
                                    tbCelular.Text,
                                    tbEmail.Text};
			return Atributos;
		}
		#endregion Métodos Sobreescritos

		/* ************************************************* */
		#region Eventos adicionales
		private void tbCod_Carrera_Leave(object sender, System.EventArgs e)
		{
			/* Convertir Clave a mayusculas */
			tbCod_Cliente.Text = tbCod_Cliente.Text.ToUpper();
			/* Procesar clave para determinar si es un registro nuevo o existente */
			ProcesarClave();
		}
        #endregion Eventos adicionales


    }
}

