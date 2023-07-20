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
    public class Candidato: IObserver<Candidato>
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

        public void Update(Candidato observador)
        {
            string remitente = "Colocar email del remitente";
            string destinatario = observador.Email;
            string asunto = "Vacante disponible";
            string cuerpo = $"Hola {observador.Nombre}, hay una vacante disponible que te podria interesar!";
            string contra = "Colocar contrasena del remitente";

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

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Candidato value)
        {
            throw new NotImplementedException();
        }
    }
}
