using Capa_data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_data.Models
{
    public class Vacante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Salario { get; set; }
        public bool Disponibilidad { get; set; }

        public List<Candidato> O_candidatos = new List<Candidato>();

        public Vacante (int id, string nombre, decimal salario, bool disponibilidad)
        {
            Id = id;
            Nombre = nombre;
            Salario = salario;
            Disponibilidad = disponibilidad;
        }

        public Vacante (string nombre, decimal salario, bool disponibilidad)
        {
            Nombre = nombre;
            Salario = salario;
            Disponibilidad = disponibilidad;
        }

        public Vacante ()
        {

        }

        public void Suscribir(Candidato observer)
        {
            O_candidatos.Add(observer);
        }

        public void Desuscribir(Candidato observer)
        {
            O_candidatos.Remove(observer);
        }

        public void Notificar()
        {
            foreach (Candidato element in O_candidatos)
            {

                element.Update(element);
            }
        }
    }
}
