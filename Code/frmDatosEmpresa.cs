using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Especies
{
    public partial class frmDatosEmpresa : Form
    {
        public bool bNuevo = false;
        public ListViewItem item;
        public Empresa empresa = new Empresa();

        public frmDatosEmpresa()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Comprobar que tiene todos los datos cubiertos.
            if (string.IsNullOrEmpty(txtNombre1.Text.Trim())
                || string.IsNullOrEmpty(txtNombre2.Text.Trim())
                || string.IsNullOrEmpty(txtDireccion1.Text.Trim())
                || string.IsNullOrEmpty(txtDireccion2.Text.Trim())
                || string.IsNullOrEmpty(txtNIF.Text.Trim())
                || string.IsNullOrEmpty(txtRegSanitario.Text.Trim())
                || string.IsNullOrEmpty(txtPais.Text.Trim())
                || string.IsNullOrEmpty(txtProvincia.Text.Trim()))
            {
                MessageBox.Show("Es necesario rellenar todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                empresa.ID = int.Parse(txtID.Text);
                empresa.Nombre1 = txtNombre1.Text;
                empresa.Nombre2 = txtNombre2.Text;
                empresa.Direccion1 = txtDireccion1.Text;
                empresa.Direccion2 = txtDireccion2.Text;
                empresa.NIF = txtNIF.Text;
                empresa.RegSanitario = txtRegSanitario.Text;
                empresa.Pais = txtPais.Text;
                empresa.Provincia = txtProvincia.Text;
                guardaLogo();

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void frmDatosEmpresa_Load(object sender, EventArgs e)
        {
            Text = string.Format("Datos de {0}", item.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonImgLogo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Abre imagen";
                dlg.Filter = "bmp files (*.bmp)|*.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    var imagen = dlg.FileName;
                    empresa.Logo = new Bitmap(imagen);
                    picLogo.Image = empresa.Logo;
                }
            }
        }

        private void guardaLogo()
        {
            //Copiar logo donde se ejecuta la aplicación
            Bitmap bm = new Bitmap(empresa.Logo);
            String nombreArchivo = "LOG" + empresa.ID + ".BMP";
            bm.Save(nombreArchivo, System.Drawing.Imaging.ImageFormat.Bmp);
        }
    }
}
