using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.CodeDom;

namespace Especies
{
    public partial class Form1 : Form
    {
        string appPath = Path.GetDirectoryName( Application.ExecutablePath);
        string csv = Application.ProductName + ".csv";
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CargaDatos();
        }


        private void btnGuarda_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                List<string> checkPLU = new List<string>();
                foreach (ListViewItem li in lvEspecies.Items)
                {
                    List<string> elementos = new List<string>();
                    for (int i = 0; i < lvEspecies.Columns.Count; i++)
                    {
                        string check = li.SubItems[i].Text;

                        //PLU repetido?
                        if (i == 1)
                        {
                            checkPLU.Add(check);
                            if (checkPLU.Distinct().Count() != checkPLU.Count())
                            {
                                throw new Exception("El formulario contiene un PLU repetido");
                            }
                        }

                        //Consulta si tiene ';' 
                        if (noPuntoyComa(check)) throw new Exception("El formulario no debe contener ';'");

                        //Sustituye SI => 0; NO => 1; OTRO => 2
                        check = sustituye(check);

                        //Añade
                        elementos.Add(check);
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
            frmDatos frm = new frmDatos();
            frm.bNuevo = true;
            frm.item = new ListViewItem((lvEspecies.Items.Count + 1).ToString("000"));
            frm.txtID.Text = frm.item.Text;
            for (int i = 1; i < 25; i++) {
                frm.item.SubItems.Add(string.Empty);
            }

            if (frm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                lblDatosNoGuardados.Visible = true;
                lvEspecies.Items.Add(frm.item);
            }

            this.RenumeraGrid();
        }

        private void btnEdita_Click(object sender, EventArgs e)
        {
            if (lvEspecies.SelectedItems.Count > 0)
            {
                frmDatos frm = new frmDatos();
                frm.bNuevo = false;

                frm.item = lvEspecies.SelectedItems[0];
                frm.txtID.Text = frm.item.Text;
                frm.txtAlfa.Text = frm.item.SubItems[1].Text;
                frm.txtComercial.Text = frm.item.SubItems[2].Text;
                frm.txtCientífico.Text = frm.item.SubItems[3].Text;
                frm.txtPresentacion.Text = frm.item.SubItems[4].Text;
                frm.txtFAO.Text = frm.item.SubItems[5].Text;
                frm.txtOrigen.Text = frm.item.SubItems[6].Text;
                frm.txtPesca.Text = frm.item.SubItems[7].Text;
                frm.txtProd.Text = frm.item.SubItems[8].Text;
                frm.comboFecha1.Text = frm.item.SubItems[9].Text;
                frm.comboFormatoFecha1.Text = frm.item.SubItems[10].Text;
                frm.comboFecha2.Text = frm.item.SubItems[11].Text;
                frm.comboFormatoFecha2.Text = frm.item.SubItems[12].Text;
                frm.comboCaducidad.Text = frm.item.SubItems[13].Text;
                frm.comboFormatoCaducidad.Text = frm.item.SubItems[14].Text;
                frm.comboPeso.Text = frm.item.SubItems[15].Text;
                frm.txtPesoFijo.Text = frm.item.SubItems[16].Text;
                frm.comboDispensado.Text = frm.item.SubItems[17].Text;
                frm.txtCodigoBarras.Text = frm.item.SubItems[18].Text;
                frm.comboCodigoBarras.Text = frm.item.SubItems[19].Text;
                frm.comboPesoPrecio.Text = frm.item.SubItems[20].Text;
                frm.txtPrecio.Text = frm.item.SubItems[21].Text;
                frm.txtTara.Text = frm.item.SubItems[22].Text;
                frm.txtGlaseo.Text = frm.item.SubItems[23].Text;

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


        private String sustituye(String check)
        {
            //Sustituye SI => 0; NO => 1; OTRO => 2
            if (check == "SI" || check == "EAN13" || check == "FIJO")
            {
                check = "0";
            }
            else if (check == "NO" || check == "CODE128" || check == "VARIABLE")
            {
                check = "1";
            }
            else if (check == "MULTIRANGO" || check == "AUTOMATICA")
            {
                check = "2";
            }

            return check;
        }

        private bool noPuntoyComa(String check)
        {
            if (check.Contains(';'))
            {
                return true;
            }
            return false;
        }
    }
}
