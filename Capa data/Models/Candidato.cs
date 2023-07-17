using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_data.Models
{
    public class Candidato
    {
        public long Cedula { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public decimal Aspiracion_salarial { get; set; }

        public int vacanteid { get; set; }
        public IEnumerable<Vacante> vacante { get; set; }

        public Candidato (long cedula, string nombre, string email, decimal aspiracion_salarial)
        {
            Cedula = cedula;
            Nombre = nombre;
            Email = email;
            Aspiracion_salarial = aspiracion_salarial;
        }
    }
}
