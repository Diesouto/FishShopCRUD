namespace Especies
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lvEspecies = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNom1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNom2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDir1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDir2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNIF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSanitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPaisSanitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProvinciaSanitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.colNom1,
            this.colNom2,
            this.colDir1,
            this.colDir2,
            this.colNIF,
            this.colSanitario,
            this.colPaisSanitario,
            this.colProvinciaSanitario});
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
            // colNom1
            // 
            this.colNom1.Text = "Nombre 1";
            this.colNom1.Width = 109;
            // 
            // colNom2
            // 
            this.colNom2.Text = "Nombre 2";
            this.colNom2.Width = 140;
            // 
            // colDir1
            // 
            this.colDir1.Text = "Dirección 1";
            this.colDir1.Width = 131;
            // 
            // colDir2
            // 
            this.colDir2.Text = "Dirección 2";
            this.colDir2.Width = 127;
            // 
            // colNIF
            // 
            this.colNIF.Text = "NIF/CIF";
            this.colNIF.Width = 79;
            // 
            // colSanitario
            // 
            this.colSanitario.Text = "Reg Sanitario";
            this.colSanitario.Width = 117;
            // 
            // colPaisSanitario
            // 
            this.colPaisSanitario.Text = "Pais reg sanitario";
            // 
            // colProvinciaSanitario
            // 
            this.colProvinciaSanitario.Text = "Provincia reg sanitario";
            this.colProvinciaSanitario.Width = 182;
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
            this.btnElimina.Location = new System.Drawing.Point(55, 346);
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
            // Form3
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
            this.Name = "Form3";
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.Form3_Load);
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
        private System.Windows.Forms.ColumnHeader colNom1;
        private System.Windows.Forms.ColumnHeader colNom2;
        private System.Windows.Forms.ColumnHeader colDir1;
        private System.Windows.Forms.ColumnHeader colDir2;
        private System.Windows.Forms.ColumnHeader colNIF;
        private System.Windows.Forms.ColumnHeader colSanitario;
        private System.Windows.Forms.Label lblDatosNoGuardados;
        private System.Windows.Forms.ColumnHeader colPaisSanitario;
        private System.Windows.Forms.ColumnHeader colProvinciaSanitario;
    }
}

