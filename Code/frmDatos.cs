using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Especies
{
    public partial class frmDatos : Form
    {
        public bool bNuevo = false;
        public ListViewItem item;

        public frmDatos()
        {
            InitializeComponent();
            initialiceOtherComponents();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Comprobar que tiene todos los datos cubiertos.
            if (string.IsNullOrEmpty(txtAlfa.Text.Trim())
                || string.IsNullOrEmpty(txtComercial.Text.Trim())
                || string.IsNullOrEmpty(txtCientífico.Text.Trim())
                || string.IsNullOrEmpty(txtPresentacion.Text.Trim())
                || string.IsNullOrEmpty(txtFAO.Text.Trim())
                || string.IsNullOrEmpty(txtOrigen.Text.Trim())
                || string.IsNullOrEmpty(txtPesca.Text.Trim())
                || string.IsNullOrEmpty(txtProd.Text.Trim())
                || string.IsNullOrEmpty(txtCodigoBarras.Text.Trim()))
            {
                MessageBox.Show("Es necesario rellenar todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                item.Text = txtID.Text;
                item.SubItems[1].Text = txtAlfa.Text;
                item.SubItems[2].Text = txtComercial.Text;
                item.SubItems[3].Text = txtCientífico.Text;
                item.SubItems[4].Text = txtPresentacion.Text;
                item.SubItems[5].Text = txtFAO.Text;
                item.SubItems[6].Text = txtOrigen.Text;
                item.SubItems[7].Text = txtPesca.Text;
                item.SubItems[8].Text = txtProd.Text;
                item.SubItems[9].Text = comboFecha1.Text;
                item.SubItems[10].Text = comboFormatoFecha1.Text;
                item.SubItems[11].Text = comboFecha2.Text;
                item.SubItems[12].Text = comboFormatoFecha2.Text;
                item.SubItems[13].Text = comboCaducidad.Text;
                item.SubItems[14].Text = comboFormatoCaducidad.Text;
                item.SubItems[15].Text = comboPeso.Text;
                item.SubItems[16].Text = txtPesoFijo.Text;
                item.SubItems[17].Text = comboDispensado.Text;
                item.SubItems[18].Text = txtCodigoBarras.Text;
                item.SubItems[19].Text = comboCodigoBarras.Text;
                item.SubItems[20].Text = comboPesoPrecio.Text;
                item.SubItems[21].Text = txtPrecio.Text;
                item.SubItems[22].Text = txtTara.Text;
                item.SubItems[23].Text = txtGlaseo.Text;



                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void frmDatos_Load(object sender, EventArgs e)
        {
            Text = string.Format("Datos de {0}", item.Text);
        }


        private void comboFecha1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFecha1.SelectedItem.Equals("NO"))
            {
                comboFormatoFecha1.Visible = false;
            }
            else
                comboFormatoFecha1.Visible = true;
        }

        private void comboFecha2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFecha2.SelectedItem.Equals("NO"))
            {
                comboFormatoFecha2.Visible = false;
            }
            else
                comboFormatoFecha2.Visible = true;
        }

        private void comboPeso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPeso.SelectedItem.Equals("MULTIRANGO"))
            {
                dataGridPeso.Visible = true;
                txtPesoFijo.Visible = false;
            }
            else if (comboPeso.SelectedItem.Equals("FIJO"))
            {
                dataGridPeso.Visible = false;
                txtPesoFijo.Visible = true;
            }
            else
            {
                dataGridPeso.Visible = false;
                txtPesoFijo.Visible = false;
            }
        }

        private void txtAlfa_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloEnteros(sender, e);
        }

        public void soloEnteros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void soloFloat(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void contadorCaducidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloEnteros(sender, e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloFloat(sender, e);
        }

        private void txtTara_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloFloat(sender, e);
        }

        private void txtGlaseo_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloFloat(sender, e);
        }

        public void initialiceOtherComponents()
        {
            this.comboCaducidad.SelectedIndex = 0;
            this.comboFormatoCaducidad.SelectedIndex = 0;
            this.comboCodigoBarras.SelectedIndex = 0;
            this.comboDispensado.SelectedIndex = 0;
            this.comboFecha1.SelectedIndex = 0;
            this.comboFecha2.SelectedIndex = 0;
            this.comboFormatoFecha1.SelectedIndex = 0;
            this.comboFormatoFecha2.SelectedIndex = 0;
            this.comboPeso.SelectedIndex = 0;
            this.comboPesoPrecio.SelectedIndex = 0;
        }
    }
}
