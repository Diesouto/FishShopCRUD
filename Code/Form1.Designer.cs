namespace Especies
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvEspecies = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colComercial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCientifico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPresentación = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colZona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOrigen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFecha1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFFecha1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFecha2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFFecha2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCaducidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContCaducidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFCaducidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPeso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVPeso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDispensado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCodBarras = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTipoCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHPesoPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHTara = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHGlaseo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnGuarda = new System.Windows.Forms.Button();
            this.btnEdita = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnNueva = new System.Windows.Forms.Button();
            this.lblDatosNoGuardados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvEspecies
            // 
            this.lvEspecies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvEspecies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colCodigo,
            this.colComercial,
            this.colCientifico,
            this.colPresentación,
            this.colZona,
            this.colOrigen,
            this.colArte,
            this.colProd,
            this.colFecha1,
            this.colFFecha1,
            this.colFecha2,
            this.colFFecha2,
            this.colCaducidad,
            this.colContCaducidad,
            this.colFCaducidad,
            this.colPeso,
            this.colVPeso,
            this.colDispensado,
            this.colCodBarras,
            this.colTipoCodigo,
            this.colHPesoPrecio,
            this.colHPrecio,
            this.colHTara,
            this.colHGlaseo});
            this.lvEspecies.FullRowSelect = true;
            this.lvEspecies.HideSelection = false;
            this.lvEspecies.Location = new System.Drawing.Point(16, 15);
            this.lvEspecies.Margin = new System.Windows.Forms.Padding(4);
            this.lvEspecies.Name = "lvEspecies";
            this.lvEspecies.Size = new System.Drawing.Size(1040, 323);
            this.lvEspecies.TabIndex = 0;
            this.lvEspecies.UseCompatibleStateImageBehavior = false;
            this.lvEspecies.View = System.Windows.Forms.View.Details;
            this.lvEspecies.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvEspecies_MouseDoubleClick);
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 50;
            // 
            // colCodigo
            // 
            this.colCodigo.Text = "PLU";
            this.colCodigo.Width = 52;
            // 
            // colComercial
            // 
            this.colComercial.Text = "Nombre comercial";
            this.colComercial.Width = 185;
            // 
            // colCientifico
            // 
            this.colCientifico.Text = "Nombre científico";
            this.colCientifico.Width = 185;
            // 
            // colPresentación
            // 
            this.colPresentación.Text = "Presentación";
            this.colPresentación.Width = 166;
            // 
            // colZona
            // 
            this.colZona.Text = "Zona FAO";
            this.colZona.Width = 112;
            // 
            // colOrigen
            // 
            this.colOrigen.Text = "Origen";
            // 
            // colArte
            // 
            this.colArte.Text = "Arte Pesca";
            // 
            // colProd
            // 
            this.colProd.Text = "Producción";
            // 
            // colFecha1
            // 
            this.colFecha1.Text = "Fecha 1";
            // 
            // colFFecha1
            // 
            this.colFFecha1.Text = "Formato 1";
            // 
            // colFecha2
            // 
            this.colFecha2.Text = "Fecha 2";
            // 
            // colFFecha2
            // 
            this.colFFecha2.Text = "Formato 2";
            // 
            // colCaducidad
            // 
            this.colCaducidad.Text = "Caducidad";
            // 
            // colContCaducidad
            // 
            this.colContCaducidad.Text = "Contador caducidad";
            // 
            // colFCaducidad
            // 
            this.colFCaducidad.Text = "Formato caducidad";
            // 
            // colPeso
            // 
            this.colPeso.Text = "Peso";
            // 
            // colVPeso
            // 
            this.colVPeso.Text = "ValorPeso";
            // 
            // colDispensado
            // 
            this.colDispensado.Text = "Dispensado";
            // 
            // colCodBarras
            // 
            this.colCodBarras.Text = "Código Barras";
            // 
            // colTipoCodigo
            // 
            this.colTipoCodigo.Text = "Tipo Codigo";
            // 
            // colHPesoPrecio
            // 
            this.colHPesoPrecio.Text = "Peso Precio";
            // 
            // colHPrecio
            // 
            this.colHPrecio.Text = "Precio";
            // 
            // colHTara
            // 
            this.colHTara.Text = "Tara";
            // 
            // colHGlaseo
            // 
            this.colHGlaseo.Text = "Glaseo";
            // 
            // btnGuarda
            // 
            this.btnGuarda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuarda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuarda.Image = global::Especies.Properties.Resources.disk;
            this.btnGuarda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuarda.Location = new System.Drawing.Point(132, 346);
            this.btnGuarda.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuarda.Name = "btnGuarda";
            this.btnGuarda.Size = new System.Drawing.Size(100, 28);
            this.btnGuarda.TabIndex = 4;
            this.btnGuarda.Text = "Guardar";
            this.btnGuarda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnGuarda, "Guardar datos");
            this.btnGuarda.UseVisualStyleBackColor = true;
            this.btnGuarda.Click += new System.EventHandler(this.btnGuarda_Click);
            // 
            // btnEdita
            // 
            this.btnEdita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdita.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdita.Image = global::Especies.Properties.Resources.application_form_edit;
            this.btnEdita.Location = new System.Drawing.Point(93, 346);
            this.btnEdita.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdita.Name = "btnEdita";
            this.btnEdita.Size = new System.Drawing.Size(31, 28);
            this.btnEdita.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnEdita, "Editar especie");
            this.btnEdita.UseVisualStyleBackColor = true;
            this.btnEdita.Click += new System.EventHandler(this.btnEdita_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnElimina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElimina.Image = global::Especies.Properties.Resources.application_form_delete;
            this.btnElimina.Location = new System.Drawing.Point(54, 346);
            this.btnElimina.Margin = new System.Windows.Forms.Padding(4);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(31, 28);
            this.btnElimina.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnElimina, "Eliminar especie");
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnNueva
            // 
            this.btnNueva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNueva.Image = global::Especies.Properties.Resources.application_form_add;
            this.btnNueva.Location = new System.Drawing.Point(16, 346);
            this.btnNueva.Margin = new System.Windows.Forms.Padding(4);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(31, 28);
            this.btnNueva.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnNueva, "Añadir especie");
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // lblDatosNoGuardados
            // 
            this.lblDatosNoGuardados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDatosNoGuardados.AutoSize = true;
            this.lblDatosNoGuardados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosNoGuardados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDatosNoGuardados.Location = new System.Drawing.Point(239, 352);
            this.lblDatosNoGuardados.Name = "lblDatosNoGuardados";
            this.lblDatosNoGuardados.Size = new System.Drawing.Size(184, 20);
            this.lblDatosNoGuardados.TabIndex = 5;
            this.lblDatosNoGuardados.Text = "Datos no guardados!";
            this.lblDatosNoGuardados.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 389);
            this.Controls.Add(this.lblDatosNoGuardados);
            this.Controls.Add(this.btnGuarda);
            this.Controls.Add(this.btnEdita);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.lvEspecies);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ESPECIES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvEspecies;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnEdita;
        private System.Windows.Forms.Button btnGuarda;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colCodigo;
        private System.Windows.Forms.ColumnHeader colComercial;
        private System.Windows.Forms.ColumnHeader colCientifico;
        private System.Windows.Forms.ColumnHeader colPresentación;
        private System.Windows.Forms.ColumnHeader colZona;
        private System.Windows.Forms.Label lblDatosNoGuardados;
        private System.Windows.Forms.ColumnHeader colOrigen;
        private System.Windows.Forms.ColumnHeader colArte;
        private System.Windows.Forms.ColumnHeader colProd;
        private System.Windows.Forms.ColumnHeader colFecha1;
        private System.Windows.Forms.ColumnHeader colFFecha1;
        private System.Windows.Forms.ColumnHeader colFecha2;
        private System.Windows.Forms.ColumnHeader colFFecha2;
        private System.Windows.Forms.ColumnHeader colCaducidad;
        private System.Windows.Forms.ColumnHeader colContCaducidad;
        private System.Windows.Forms.ColumnHeader colFCaducidad;
        private System.Windows.Forms.ColumnHeader colPeso;
        private System.Windows.Forms.ColumnHeader colVPeso;
        private System.Windows.Forms.ColumnHeader colDispensado;
        private System.Windows.Forms.ColumnHeader colCodBarras;
        private System.Windows.Forms.ColumnHeader colTipoCodigo;
        private System.Windows.Forms.ColumnHeader colHPesoPrecio;
        private System.Windows.Forms.ColumnHeader colHPrecio;
        private System.Windows.Forms.ColumnHeader colHTara;
        private System.Windows.Forms.ColumnHeader colHGlaseo;
    }
}

