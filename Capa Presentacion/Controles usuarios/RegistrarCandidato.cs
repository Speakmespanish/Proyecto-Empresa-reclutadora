using Capa_data.Models;
using Capa_negocio.Data;
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
    public partial class RegistrarCandidato : UserControl
    {
        private Dvacante _vacanteservice;
        private Dcandidato _candidatoservice;

        public RegistrarCandidato()
        {
            _candidatoservice = new Dcandidato();
            _vacanteservice = new Dvacante();
            InitializeComponent();
        }

        private void RegistrarCandidato_Load(object sender, EventArgs e)
        {
            List<Vacante> vacantes = new List<Vacante>();

            foreach (Vacante element in _vacanteservice.GetAll())
            {
                vacantes.Add(element);
            }

            foreach (Vacante element in vacantes)
            {
                comboBox1.Items.Add(element.Nombre);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            long cedula = Convert.ToInt64(txtCedula.Text);
            string nombre = txtNombreCandidato.Text;
            string email = txtEmail.Text;
            decimal aspiracion = Convert.ToDecimal(nudAspiracionSalarial.Value.ToString());
            int vacante = comboBox1.SelectedIndex;

            Candidato candidato = new Candidato
            {
                Cedula = cedula,
                Nombre = nombre,
                Email = email,
                Aspiracion_salarial = aspiracion,
                vacante = vacante.ToString()
            };

            bool result = _candidatoservice.Add(candidato);

            if (result)
            {
                MessageBox.Show("Se registro con exito al candidato!");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error, no se pudo registrar al candidato");
            }
        }
    }
}
