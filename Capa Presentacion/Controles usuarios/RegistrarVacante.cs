using Capa_data.Models;
using Capa_negocio.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.Controles_usuarios
{
    public partial class RegistrarVacante : UserControl
    {
        private VacanteService _vacanteservice;
        public RegistrarVacante()
        {
            _vacanteservice = new VacanteService();
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreVacante.Text;
            decimal salario = nudSalarioVacante.Value;
            bool disponibilidad;
            if (cbxDisponibilidad.Text == "Disponible")
            {
                disponibilidad = true;
            }
            else
            {
                disponibilidad = false;
            }

            Vacante vacante = new Vacante
            {
                Nombre = nombre,
                Salario = salario,
                Disponibilidad = disponibilidad
            };
            bool result = _vacanteservice.Add(vacante);

            if (result == true)
            {
                MessageBox.Show("Se registro la vacante con exitos!");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error, no se pudo registrar la vacante");
            }
        }
    }
}
