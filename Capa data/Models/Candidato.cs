using Capa_data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Capa_data.Models
{
    public class Candidato: IObserver
    {
        public long Cedula { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public decimal Aspiracion_salarial { get; set; }

        public string vacante { get; set; }

        public Candidato () { }

        public Candidato (long cedula, string nombre, string email, decimal aspiracion_salarial)
        {
            Cedula = cedula;
            Nombre = nombre;
            Email = email;
            Aspiracion_salarial = aspiracion_salarial;
        }

        public Candidato (long cedula, string nombre, string email, decimal aspiracion_salarial, string vacante)
        {
            Cedula = cedula;
            Nombre = nombre;
            Email = email;
            Aspiracion_salarial = aspiracion_salarial;
            vacante = vacante;
        }

        public void Update()
        {
            string remitente = "andysonvargas180@gmail.com";
            string destinatario = "andysonvargas180@gmail.com";
            string asunto = "Vacante disponible";
            string cuerpo = "Hay una nueva vacante para el puesto al que postulaste";
            string contra = "aeotyebvydnlwynn";

            SmtpClient cliente = new SmtpClient("smtp.gmail.com");
            cliente.EnableSsl = true;
            cliente.UseDefaultCredentials = false;
            cliente.Host = "smtp.gmail.com";
            cliente.Port = 587;
            cliente.Credentials = new NetworkCredential(remitente, contra);

            MailMessage message = new MailMessage(remitente, destinatario, asunto, cuerpo);

            try
            {
                cliente.Send(message);
                cliente.Dispose();
            }
            catch (Exception ex)
            {
                cliente.Dispose();
                throw new ArgumentException("Ha ocurrido un error, no se pudo enviar el email");
            }
        }
    }
}
