using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodoListas
{
    public partial class Form1 : Form
    {
        private List<string> elementos = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            string nuevoElemento = txtElemento.Text.Trim();

            if (!string.IsNullOrWhiteSpace(nuevoElemento) && Regex.IsMatch(nuevoElemento, @"^[a-zA-Z\s]+$"))
            {
                if (!elementos.Contains(nuevoElemento))
                {
                    elementos.Add(nuevoElemento);
                    ActualizarLista();
                    txtElemento.Clear();
                }
                else
                {
                    MessageBox.Show("El elemento ya existe en la lista.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresa un elemento válido (solo letras y espacios).");
            }
        }


        // Método para eliminar elementos seleccionados 
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            if (lstElementos.SelectedItem != null)

            {

                elementos.Remove(lstElementos.SelectedItem.ToString());

                ActualizarLista();

            }
            else

            {

                MessageBox.Show("Selecciona un elemento para eliminar.");

            }
        }

        // Método para actualizar ListBox 

        private void ActualizarLista()

        {

            lstElementos.DataSource = null;

            lstElementos.DataSource = elementos;

        }

    }
}
