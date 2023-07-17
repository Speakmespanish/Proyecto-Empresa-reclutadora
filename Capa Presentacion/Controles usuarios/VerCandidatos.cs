using Capa_data.Models;
using Capa_negocio.Data;
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
    public partial class VerCandidatos : UserControl
    {
        private Dcandidato _candidatoservice;

        public VerCandidatos()
        {
            _candidatoservice = new Dcandidato();
            InitializeComponent();
        }

        private void VerCandidatos_Load(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            dataGridView1.DataSource = _candidatoservice.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            dataGridView1.DataSource = _candidatoservice.GetAll();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            long cedula = 0;
            int salario = 0;

            if (dataGridView1.CurrentRow != null)
            {
                string _cedula = dataGridView1.CurrentRow.Cells[0].Value?.ToString();
                string _salario = dataGridView1.CurrentRow.Cells[3].Value?.ToString();
                cedula = Convert.ToInt64(_cedula);
                salario = Convert.ToInt32(_salario);

                Candidato candidato = new Candidato
                {
                    Cedula = cedula,
                    Aspiracion_salarial = salario 
                };

                bool result = _candidatoservice.Update(candidato);
                if (result)
                {
                    MessageBox.Show("Se ha actualizado con exitos el candidato!");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, no se pudo actualizar el candidato");
                }
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                long cedula = Convert.ToInt64
                    (dataGridView1.CurrentRow.Cells["Cedula"].Value?.ToString());

                bool result = _candidatoservice.Delete(cedula);

                if (result)
                {
                    MessageBox.Show("Se ha eliminado con exitos al candidato!");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, no se pudo eliminar el candidato");
                }
            }
        }
    }
}
