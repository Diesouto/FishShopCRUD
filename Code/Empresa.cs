using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Especies
{
    public class Empresa
    {
        public int ID { get; set; }
        public String Nombre1 { get; set; }
        public String Nombre2 { get; set; }
        public String Direccion1 { get; set; }
        public String Direccion2 { get; set; }
        public String NIF { get; set; }
        public String RegSanitario { get; set; }
        public String Pais { get; set; }
        public String Provincia { get; set; }
        public Image Logo { get; set; }

        public Empresa()
        {

        }

        public Empresa(int ID, String Nombre1, String Nombre2, String Direccion1, String Direccion2, String NIF, String RegSanitario, String Pais, String Provincia)
        {
            this.ID = ID;
            this.Nombre1 = Nombre1;
            this.Nombre2 = Nombre2;
            this.Direccion1 = Direccion1;
            this.Direccion2 = Direccion2;
            this.NIF = NIF;
            this.RegSanitario = RegSanitario;
            this.Pais = Pais;
            this.Provincia = Provincia;
        }

    }
}
