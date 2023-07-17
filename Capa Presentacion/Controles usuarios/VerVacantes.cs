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
    public partial class VerVacantes : UserControl
    {
        private Dvacante _vacanteservice;
        public VerVacantes()
        {
            _vacanteservice = new Dvacante();
            InitializeComponent();
        }

        private void VerVacantes_Load(object sender, EventArgs e)
        {

            dataGridView1.Refresh();
            dataGridView1.DataSource = _vacanteservice.GetAll();
            
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            dataGridView1.DataSource = _vacanteservice.GetAll();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = 0;
            decimal salario = 0;
            bool disponibilidad = false;

            if (dataGridView1.CurrentRow != null)
            {

                string _id = dataGridView1.CurrentRow.Cells["Id"].Value?.ToString();
                string _salario = dataGridView1.CurrentRow.Cells["Salario"].Value?.ToString();
                DataGridViewCheckBoxCell cell = dataGridView1.CurrentRow.Cells["Disponibilidad"] as DataGridViewCheckBoxCell;
                bool _disponibilidad = Convert.ToBoolean(cell.Value);

                if (!string.IsNullOrEmpty(_id))
                {
                    id = Convert.ToInt32(_id);
                }

                if (!string.IsNullOrEmpty(_salario))
                {
                    salario = Convert.ToDecimal(_salario);
                }

                if (_disponibilidad)
                {
                    disponibilidad = true;
                }
                else { disponibilidad = false; }
                
            }

            Vacante vacante = new Vacante
            {
                Id = id,
                Salario = salario,
                Disponibilidad = disponibilidad
            };

            bool result = _vacanteservice.Update(vacante);

            if (result == true)
            {
                MessageBox.Show("Se ha actualizado con exitos la vacante!");
            }
            else
            {
                MessageBox.Show("Hubo un error al intentar actualizar la vacante" + id + disponibilidad + salario);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = 0;

            if (dataGridView1.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value?.ToString());

                bool result = _vacanteservice.Delete(id);

                if (result)
                {
                    MessageBox.Show("Se ha eliminado de forma exitosa la vacante!");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, no se pudo eliminar la vacante seleccionada");
                }
            }
        }
    }
}
