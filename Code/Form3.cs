using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Especies
{
    public partial class Form3 : Form
    {
        string appPath = Path.GetDirectoryName( Application.ExecutablePath);
        string csv = "Empresas.csv";
        //string csv = Application.ProductName + ".csv";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.CargaDatos();
        }


        private void btnGuarda_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (ListViewItem li in lvEspecies.Items)
                {
                    List<string> elementos = new List<string>();
                    for (int i = 0; i < lvEspecies.Columns.Count; i++)
                    {
                        elementos.Add(li.SubItems[i].Text);
                    }
                    sb.AppendLine(string.Join(";", elementos.ToArray()));
                }

                string archivo = Path.Combine(appPath, csv);
                StreamWriter sw = new StreamWriter(archivo);
                sw.Write(sb.ToString());
                sw.Close();
                sw.Dispose();
                lblDatosNoGuardados.Visible = false;

                MessageBox.Show("Datos guardardos", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNueva_Click(object sender, EventArgs e) {
            frmDatosEmpresa frm = new frmDatosEmpresa();
            frm.bNuevo = true;
            frm.item = new ListViewItem((lvEspecies.Items.Count + 1).ToString("000"));
            frm.txtID.Text = frm.item.Text;
            for (int i = 1; i < 9; i++) {
                frm.item.SubItems.Add(string.Empty);
            }

            if (frm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                lblDatosNoGuardados.Visible = true;
                ListViewItem li = new ListViewItem();
                li.Tag = frm.empresa;
                li.SubItems.Add(frm.empresa.Nombre1);
                li.SubItems.Add(frm.empresa.Nombre2);
                li.SubItems.Add(frm.empresa.Direccion1);
                li.SubItems.Add(frm.empresa.Direccion2);
                li.SubItems.Add(frm.empresa.NIF);
                li.SubItems.Add(frm.empresa.RegSanitario);
                li.SubItems.Add(frm.empresa.Pais);
                li.SubItems.Add(frm.empresa.Provincia);

                lvEspecies.Items.Add(li);
            }

            this.RenumeraGrid();
        }

        private void btnEdita_Click(object sender, EventArgs e)
        {
            if (lvEspecies.SelectedItems.Count > 0)
            {
                frmDatosEmpresa frm = new frmDatosEmpresa();
                frm.bNuevo = false;

                frm.item = lvEspecies.SelectedItems[0];
                frm.txtID.Text = frm.item.Text;
                frm.txtNombre1.Text = frm.item.SubItems[1].Text;
                frm.txtNombre2.Text = frm.item.SubItems[2].Text;
                frm.txtDireccion1.Text = frm.item.SubItems[3].Text;
                frm.txtDireccion2.Text = frm.item.SubItems[4].Text;
                frm.txtNIF.Text = frm.item.SubItems[5].Text;
                frm.txtRegSanitario.Text = frm.item.SubItems[6].Text;
                frm.txtPais.Text = frm.item.SubItems[7].Text;
                frm.txtProvincia.Text = frm.item.SubItems[8].Text;

                if (frm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    lblDatosNoGuardados.Visible = true;
                    lvEspecies.SelectedItems[0].Text = frm.item.Text;
                    for (int i = 1; i < frm.item.SubItems.Count; i++)
                    {
                        lvEspecies.SelectedItems[0].SubItems[i].Text = frm.item.SubItems[i].Text;
                    }
                }

                this.RenumeraGrid();
            }

        }

        private void btnElimina_Click(object sender, EventArgs e) {
            if (lvEspecies.SelectedItems.Count > 0) {
                if (MessageBox.Show(string.Format("¿Eliminar el registro {0}?", lvEspecies.SelectedItems[0].Text), "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                    lblDatosNoGuardados.Visible = true;
                    lvEspecies.Items.Remove(lvEspecies.SelectedItems[0]);
                    this.RenumeraGrid();
                }
            }
        }

        #region Métodos
        private void RenumeraGrid()
        {
            int contador = 1;
            foreach (ListViewItem li in lvEspecies.Items)
            {
                li.Text = contador.ToString("000");
                contador++;
            }
        }

        private void CargaDatos()
        {
            lvEspecies.Items.Clear();

            string archivo = Path.Combine(appPath, csv);
            if (File.Exists(archivo)){
                try {
                    using (StreamReader sr = new StreamReader(archivo)) {
                        string linea = sr.ReadLine();
                        while (!string.IsNullOrEmpty(linea)) {
                            List<string> campos = linea.Split(';').ToList<string>();

                            ListViewItem li = new ListViewItem(campos[0]);
                            for (int i = 1; i < campos.Count; i++) {
                                li.SubItems.Add(campos[i]);
                            }
                            // rellenar todas las columnas 
                            for (int i = campos.Count; i < lvEspecies.Columns.Count; i++) {
                                li.SubItems.Add(string.Empty + "--");
                            }
                            lvEspecies.Items.Add(li);

                            linea = sr.ReadLine();
                        }
                        sr.Close();
                    }

                } catch(IOException ioex) {
                    MessageBox.Show(ioex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }

        }
        #endregion

        private void lvEspecies_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvEspecies.SelectedItems.Count > 0)
            {
                this.btnEdita_Click(sender, null);
            }
        }

    }
}
