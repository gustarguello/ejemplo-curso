using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            lwElemento.Items.Add(elem);
            string chocolate = cbChocolate.Checked == true ? "Le gusta el choco" : "No le gusta";
            string genero = rbtMasculino.Checked == true ? "Masculino" : "Femenino";
            lwElemento.Items.Add(fecha.ToString());
            lwElemento.Items.Add(genero);
            lwElemento.Items.Add(chocolate);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Naranja");
            cboColorFavorito.Items.Add("Negro");
            cboColorFavorito.Items.Add("Azul");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            //operador ternario
            string chocolate = cbChocolate.Checked == true ? "Le gusta el chocolate" : "No le gusta el chocolate";
            string tipo;
            if (rbtMasculino.Checked)
                tipo = "Masculino";
            else
                tipo = "Femenino";

            string colFavorito = cboColorFavorito.SelectedItem.ToString();
            
        }
    }
}
