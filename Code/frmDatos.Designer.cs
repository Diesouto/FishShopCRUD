namespace Especies
{
    partial class frmDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAlfa = new System.Windows.Forms.TextBox();
            this.txtComercial = new System.Windows.Forms.TextBox();
            this.txtCientífico = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tabDatos = new System.Windows.Forms.TabControl();
            this.tabEspecies = new System.Windows.Forms.TabPage();
            this.txtPesoFijo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridPeso = new System.Windows.Forms.DataGridView();
            this.colDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboPeso = new System.Windows.Forms.ComboBox();
            this.comboFormatoCaducidad = new System.Windows.Forms.ComboBox();
            this.contadorCaducidad = new System.Windows.Forms.TextBox();
            this.comboFecha2 = new System.Windows.Forms.ComboBox();
            this.comboFecha1 = new System.Windows.Forms.ComboBox();
            this.comboDispensado = new System.Windows.Forms.ComboBox();
            this.comboCodigoBarras = new System.Windows.Forms.ComboBox();
            this.comboPesoPrecio = new System.Windows.Forms.ComboBox();
            this.comboCaducidad = new System.Windows.Forms.ComboBox();
            this.txtGlaseo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTara = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Dispensado = new System.Windows.Forms.Label();
            this.Peso = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboFormatoFecha2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboFormatoFecha1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPesca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFAO = new System.Windows.Forms.TextBox();
            this.txtPresentacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabDatos.SuspendLayout();
            this.tabEspecies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "PLU:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(20, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre comercial:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(20, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nombre científico:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(219, 18);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(52, 26);
            this.txtID.TabIndex = 8;
            this.txtID.TabStop = false;
            // 
            // txtAlfa
            // 
            this.txtAlfa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAlfa.Location = new System.Drawing.Point(219, 50);
            this.txtAlfa.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlfa.MaxLength = 3;
            this.txtAlfa.Name = "txtAlfa";
            this.txtAlfa.Size = new System.Drawing.Size(52, 26);
            this.txtAlfa.TabIndex = 9;
            this.txtAlfa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlfa_KeyPress);
            // 
            // txtComercial
            // 
            this.txtComercial.Location = new System.Drawing.Point(219, 82);
            this.txtComercial.Margin = new System.Windows.Forms.Padding(4);
            this.txtComercial.Name = "txtComercial";
            this.txtComercial.Size = new System.Drawing.Size(421, 26);
            this.txtComercial.TabIndex = 14;
            // 
            // txtCientífico
            // 
            this.txtCientífico.Location = new System.Drawing.Point(219, 114);
            this.txtCientífico.Margin = new System.Windows.Forms.Padding(4);
            this.txtCientífico.Name = "txtCientífico";
            this.txtCientífico.Size = new System.Drawing.Size(421, 26);
            this.txtCientífico.TabIndex = 15;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(1051, 456);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(1159, 456);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tabDatos
            // 
            this.tabDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDatos.Controls.Add(this.tabEspecies);
            this.tabDatos.Location = new System.Drawing.Point(16, 15);
            this.tabDatos.Margin = new System.Windows.Forms.Padding(4);
            this.tabDatos.Name = "tabDatos";
            this.tabDatos.Size = new System.Drawing.Size(1291, 534);
            this.tabDatos.TabIndex = 18;
            // 
            // tabEspecies
            // 
            this.tabEspecies.Controls.Add(this.txtPesoFijo);
            this.tabEspecies.Controls.Add(this.label14);
            this.tabEspecies.Controls.Add(this.dataGridPeso);
            this.tabEspecies.Controls.Add(this.comboPeso);
            this.tabEspecies.Controls.Add(this.comboFormatoCaducidad);
            this.tabEspecies.Controls.Add(this.contadorCaducidad);
            this.tabEspecies.Controls.Add(this.comboFecha2);
            this.tabEspecies.Controls.Add(this.comboFecha1);
            this.tabEspecies.Controls.Add(this.comboDispensado);
            this.tabEspecies.Controls.Add(this.comboCodigoBarras);
            this.tabEspecies.Controls.Add(this.comboPesoPrecio);
            this.tabEspecies.Controls.Add(this.comboCaducidad);
            this.tabEspecies.Controls.Add(this.txtGlaseo);
            this.tabEspecies.Controls.Add(this.label18);
            this.tabEspecies.Controls.Add(this.txtTara);
            this.tabEspecies.Controls.Add(this.label17);
            this.tabEspecies.Controls.Add(this.txtPrecio);
            this.tabEspecies.Controls.Add(this.label16);
            this.tabEspecies.Controls.Add(this.label15);
            this.tabEspecies.Controls.Add(this.txtCodigoBarras);
            this.tabEspecies.Controls.Add(this.label13);
            this.tabEspecies.Controls.Add(this.Dispensado);
            this.tabEspecies.Controls.Add(this.Peso);
            this.tabEspecies.Controls.Add(this.label12);
            this.tabEspecies.Controls.Add(this.comboFormatoFecha2);
            this.tabEspecies.Controls.Add(this.label11);
            this.tabEspecies.Controls.Add(this.comboFormatoFecha1);
            this.tabEspecies.Controls.Add(this.label10);
            this.tabEspecies.Controls.Add(this.txtProd);
            this.tabEspecies.Controls.Add(this.label9);
            this.tabEspecies.Controls.Add(this.txtPesca);
            this.tabEspecies.Controls.Add(this.label6);
            this.tabEspecies.Controls.Add(this.txtOrigen);
            this.tabEspecies.Controls.Add(this.label3);
            this.tabEspecies.Controls.Add(this.txtFAO);
            this.tabEspecies.Controls.Add(this.txtPresentacion);
            this.tabEspecies.Controls.Add(this.label4);
            this.tabEspecies.Controls.Add(this.label5);
            this.tabEspecies.Controls.Add(this.label1);
            this.tabEspecies.Controls.Add(this.btnCancelar);
            this.tabEspecies.Controls.Add(this.label2);
            this.tabEspecies.Controls.Add(this.btnAceptar);
            this.tabEspecies.Controls.Add(this.txtCientífico);
            this.tabEspecies.Controls.Add(this.txtComercial);
            this.tabEspecies.Controls.Add(this.label7);
            this.tabEspecies.Controls.Add(this.label8);
            this.tabEspecies.Controls.Add(this.txtID);
            this.tabEspecies.Controls.Add(this.txtAlfa);
            this.tabEspecies.Location = new System.Drawing.Point(4, 29);
            this.tabEspecies.Margin = new System.Windows.Forms.Padding(4);
            this.tabEspecies.Name = "tabEspecies";
            this.tabEspecies.Padding = new System.Windows.Forms.Padding(4);
            this.tabEspecies.Size = new System.Drawing.Size(1283, 501);
            this.tabEspecies.TabIndex = 0;
            this.tabEspecies.Text = "Producto";
            this.tabEspecies.UseVisualStyleBackColor = true;
            // 
            // txtPesoFijo
            // 
            this.txtPesoFijo.Location = new System.Drawing.Point(219, 387);
            this.txtPesoFijo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesoFijo.Name = "txtPesoFijo";
            this.txtPesoFijo.Size = new System.Drawing.Size(52, 26);
            this.txtPesoFijo.TabIndex = 66;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(20, 388);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(191, 25);
            this.label14.TabIndex = 65;
            this.label14.Text = "Valor Peso Fijo";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridPeso
            // 
            this.dataGridPeso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPeso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDesde,
            this.colHasta,
            this.colResultado});
            this.dataGridPeso.Location = new System.Drawing.Point(219, 323);
            this.dataGridPeso.Name = "dataGridPeso";
            this.dataGridPeso.RowHeadersWidth = 51;
            this.dataGridPeso.RowTemplate.Height = 24;
            this.dataGridPeso.Size = new System.Drawing.Size(429, 55);
            this.dataGridPeso.TabIndex = 64;
            // 
            // colDesde
            // 
            this.colDesde.HeaderText = "Desde";
            this.colDesde.MinimumWidth = 6;
            this.colDesde.Name = "colDesde";
            this.colDesde.Width = 125;
            // 
            // colHasta
            // 
            this.colHasta.HeaderText = "Hasta";
            this.colHasta.MinimumWidth = 6;
            this.colHasta.Name = "colHasta";
            this.colHasta.Width = 125;
            // 
            // colResultado
            // 
            this.colResultado.HeaderText = "Resultado";
            this.colResultado.MinimumWidth = 6;
            this.colResultado.Name = "colResultado";
            this.colResultado.Width = 125;
            // 
            // comboPeso
            // 
            this.comboPeso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPeso.FormattingEnabled = true;
            this.comboPeso.Items.AddRange(new object[] {
            "FIJO",
            "VARIABLE",
            "MULTIRANGO"});
            this.comboPeso.Location = new System.Drawing.Point(219, 289);
            this.comboPeso.Name = "comboPeso";
            this.comboPeso.Size = new System.Drawing.Size(121, 28);
            this.comboPeso.TabIndex = 63;
            this.comboPeso.SelectedIndexChanged += new System.EventHandler(this.comboPeso_SelectedIndexChanged);
            // 
            // comboFormatoCaducidad
            // 
            this.comboFormatoCaducidad.FormattingEnabled = true;
            this.comboFormatoCaducidad.Items.AddRange(new object[] {
            "dd/mm/aaaa",
            "mm/aaaa"});
            this.comboFormatoCaducidad.Location = new System.Drawing.Point(429, 255);
            this.comboFormatoCaducidad.Name = "comboFormatoCaducidad";
            this.comboFormatoCaducidad.Size = new System.Drawing.Size(121, 28);
            this.comboFormatoCaducidad.TabIndex = 62;
            // 
            // contadorCaducidad
            // 
            this.contadorCaducidad.BackColor = System.Drawing.SystemColors.Window;
            this.contadorCaducidad.Location = new System.Drawing.Point(360, 255);
            this.contadorCaducidad.Margin = new System.Windows.Forms.Padding(4);
            this.contadorCaducidad.Name = "contadorCaducidad";
            this.contadorCaducidad.Size = new System.Drawing.Size(52, 26);
            this.contadorCaducidad.TabIndex = 61;
            this.contadorCaducidad.TabStop = false;
            this.contadorCaducidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contadorCaducidad_KeyPress);
            // 
            // comboFecha2
            // 
            this.comboFecha2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFecha2.FormattingEnabled = true;
            this.comboFecha2.Items.AddRange(new object[] {
            "SI",
            "NO",
            "AUTOMATICA"});
            this.comboFecha2.Location = new System.Drawing.Point(218, 218);
            this.comboFecha2.Name = "comboFecha2";
            this.comboFecha2.Size = new System.Drawing.Size(53, 28);
            this.comboFecha2.TabIndex = 60;
            this.comboFecha2.SelectedIndexChanged += new System.EventHandler(this.comboFecha2_SelectedIndexChanged);
            // 
            // comboFecha1
            // 
            this.comboFecha1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFecha1.FormattingEnabled = true;
            this.comboFecha1.Items.AddRange(new object[] {
            "SI",
            "NO",
            "AUTOMATICA"});
            this.comboFecha1.Location = new System.Drawing.Point(218, 185);
            this.comboFecha1.Name = "comboFecha1";
            this.comboFecha1.Size = new System.Drawing.Size(53, 28);
            this.comboFecha1.TabIndex = 59;
            this.comboFecha1.SelectedIndexChanged += new System.EventHandler(this.comboFecha1_SelectedIndexChanged);
            // 
            // comboDispensado
            // 
            this.comboDispensado.AutoCompleteCustomSource.AddRange(new string[] {
            "SI",
            "NO"});
            this.comboDispensado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDispensado.FormattingEnabled = true;
            this.comboDispensado.Items.AddRange(new object[] {
            "dd/mm/aaaa",
            "mm/aaaa"});
            this.comboDispensado.Location = new System.Drawing.Point(947, 188);
            this.comboDispensado.Name = "comboDispensado";
            this.comboDispensado.Size = new System.Drawing.Size(110, 28);
            this.comboDispensado.TabIndex = 58;
            // 
            // comboCodigoBarras
            // 
            this.comboCodigoBarras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCodigoBarras.FormattingEnabled = true;
            this.comboCodigoBarras.Items.AddRange(new object[] {
            "EAN13",
            "CODE128",
            "CODE39"});
            this.comboCodigoBarras.Location = new System.Drawing.Point(1070, 226);
            this.comboCodigoBarras.Name = "comboCodigoBarras";
            this.comboCodigoBarras.Size = new System.Drawing.Size(70, 24);
            this.comboCodigoBarras.TabIndex = 57;
            // 
            // comboPesoPrecio
            // 
            this.comboPesoPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPesoPrecio.FormattingEnabled = true;
            this.comboPesoPrecio.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.comboPesoPrecio.Location = new System.Drawing.Point(947, 258);
            this.comboPesoPrecio.Name = "comboPesoPrecio";
            this.comboPesoPrecio.Size = new System.Drawing.Size(52, 28);
            this.comboPesoPrecio.TabIndex = 56;
            this.comboPesoPrecio.Visible = false;
            // 
            // comboCaducidad
            // 
            this.comboCaducidad.AutoCompleteCustomSource.AddRange(new string[] {
            "meses",
            "dias"});
            this.comboCaducidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCaducidad.FormattingEnabled = true;
            this.comboCaducidad.Items.AddRange(new object[] {
            "DIAS",
            "MESES"});
            this.comboCaducidad.Location = new System.Drawing.Point(219, 253);
            this.comboCaducidad.Name = "comboCaducidad";
            this.comboCaducidad.Size = new System.Drawing.Size(121, 28);
            this.comboCaducidad.TabIndex = 54;
            // 
            // txtGlaseo
            // 
            this.txtGlaseo.Location = new System.Drawing.Point(947, 364);
            this.txtGlaseo.Margin = new System.Windows.Forms.Padding(4);
            this.txtGlaseo.Name = "txtGlaseo";
            this.txtGlaseo.Size = new System.Drawing.Size(52, 26);
            this.txtGlaseo.TabIndex = 53;
            this.txtGlaseo.Visible = false;
            this.txtGlaseo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGlaseo_KeyPress);
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(748, 364);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(191, 25);
            this.label18.TabIndex = 52;
            this.label18.Text = "Glaseo";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label18.Visible = false;
            // 
            // txtTara
            // 
            this.txtTara.Location = new System.Drawing.Point(947, 329);
            this.txtTara.Margin = new System.Windows.Forms.Padding(4);
            this.txtTara.Name = "txtTara";
            this.txtTara.Size = new System.Drawing.Size(52, 26);
            this.txtTara.TabIndex = 51;
            this.txtTara.Visible = false;
            this.txtTara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTara_KeyPress);
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(748, 329);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(191, 25);
            this.label17.TabIndex = 50;
            this.label17.Text = "Tara";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label17.Visible = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(947, 293);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(52, 26);
            this.txtPrecio.TabIndex = 49;
            this.txtPrecio.Visible = false;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(748, 293);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(191, 25);
            this.label16.TabIndex = 48;
            this.label16.Text = "Precio";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label16.Visible = false;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(748, 258);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(191, 25);
            this.label15.TabIndex = 46;
            this.label15.Text = "Peso precio";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.Visible = false;
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(947, 223);
            this.txtCodigoBarras.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(110, 26);
            this.txtCodigoBarras.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(748, 223);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 25);
            this.label13.TabIndex = 42;
            this.label13.Text = "Código de barras";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Dispensado
            // 
            this.Dispensado.Location = new System.Drawing.Point(748, 188);
            this.Dispensado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dispensado.Name = "Dispensado";
            this.Dispensado.Size = new System.Drawing.Size(191, 25);
            this.Dispensado.TabIndex = 40;
            this.Dispensado.Text = "Dispensado";
            this.Dispensado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Peso
            // 
            this.Peso.Location = new System.Drawing.Point(20, 288);
            this.Peso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(191, 25);
            this.Peso.TabIndex = 38;
            this.Peso.Text = "Peso";
            this.Peso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(20, 253);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 25);
            this.label12.TabIndex = 36;
            this.label12.Text = "Caducidad";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboFormatoFecha2
            // 
            this.comboFormatoFecha2.FormattingEnabled = true;
            this.comboFormatoFecha2.Items.AddRange(new object[] {
            "dd/mm/aaaa",
            "mm/aaaa"});
            this.comboFormatoFecha2.Location = new System.Drawing.Point(291, 219);
            this.comboFormatoFecha2.Name = "comboFormatoFecha2";
            this.comboFormatoFecha2.Size = new System.Drawing.Size(121, 28);
            this.comboFormatoFecha2.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(20, 219);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 25);
            this.label11.TabIndex = 33;
            this.label11.Text = "Fecha 2";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboFormatoFecha1
            // 
            this.comboFormatoFecha1.FormattingEnabled = true;
            this.comboFormatoFecha1.Items.AddRange(new object[] {
            "dd/mm/aaaa",
            "mm/aaaa"});
            this.comboFormatoFecha1.Location = new System.Drawing.Point(291, 185);
            this.comboFormatoFecha1.Name = "comboFormatoFecha1";
            this.comboFormatoFecha1.Size = new System.Drawing.Size(121, 28);
            this.comboFormatoFecha1.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(20, 185);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "Fecha 1";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProd
            // 
            this.txtProd.Location = new System.Drawing.Point(947, 154);
            this.txtProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(193, 26);
            this.txtProd.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(748, 154);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "Producción";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPesca
            // 
            this.txtPesca.Location = new System.Drawing.Point(947, 119);
            this.txtPesca.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesca.Name = "txtPesca";
            this.txtPesca.Size = new System.Drawing.Size(193, 26);
            this.txtPesca.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(748, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Arte de Pesca";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(947, 85);
            this.txtOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(193, 26);
            this.txtOrigen.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(748, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Origen";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFAO
            // 
            this.txtFAO.Location = new System.Drawing.Point(947, 51);
            this.txtFAO.Margin = new System.Windows.Forms.Padding(4);
            this.txtFAO.Name = "txtFAO";
            this.txtFAO.Size = new System.Drawing.Size(193, 26);
            this.txtFAO.TabIndex = 23;
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.Location = new System.Drawing.Point(219, 148);
            this.txtPresentacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Size = new System.Drawing.Size(421, 26);
            this.txtPresentacion.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Presentación:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(748, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Zona FAO:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1322, 564);
            this.Controls.Add(this.tabDatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDatos";
            this.Load += new System.EventHandler(this.frmDatos_Load);
            this.tabDatos.ResumeLayout(false);
            this.tabEspecies.ResumeLayout(false);
            this.tabEspecies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPeso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtAlfa;
        public System.Windows.Forms.TextBox txtComercial;
        public System.Windows.Forms.TextBox txtCientífico;
        private System.Windows.Forms.TabControl tabDatos;
        private System.Windows.Forms.TabPage tabEspecies;
        public System.Windows.Forms.TextBox txtFAO;
        public System.Windows.Forms.TextBox txtPresentacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtPesca;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtGlaseo;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox txtTara;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Dispensado;
        private System.Windows.Forms.Label Peso;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox contadorCaducidad;
        public System.Windows.Forms.TextBox txtPesoFijo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResultado;
        public System.Windows.Forms.ComboBox comboFecha1;
        public System.Windows.Forms.ComboBox comboFormatoFecha1;
        public System.Windows.Forms.ComboBox comboFormatoFecha2;
        public System.Windows.Forms.ComboBox comboDispensado;
        public System.Windows.Forms.ComboBox comboCodigoBarras;
        public System.Windows.Forms.ComboBox comboPesoPrecio;
        public System.Windows.Forms.ComboBox comboCaducidad;
        public System.Windows.Forms.ComboBox comboFecha2;
        public System.Windows.Forms.ComboBox comboPeso;
        public System.Windows.Forms.ComboBox comboFormatoCaducidad;
    }
}