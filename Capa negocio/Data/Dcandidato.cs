using Capa_data.Conexion;
using Capa_data.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_negocio.Data
{
    public class Dcandidato
    {
        public List<Candidato> GetAll ()
        {
            List<Candidato> candidatos = new List<Candidato>();
            using (SqlConnection conn = new SqlConnection(DB_Conection.conexion))
            {
                string query = "SELECT Candidato.Cedula, Candidato.Nombre, Candidato.Email, Candidato.AspiracionSalarial, Vacante.Nombre AS Aplicacion" +
                    " FROM Candidato INNER JOIN Vacante on Candidato.VacanteAplicar = Vacante.Id";

                conn.Open ();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader ())
                    {
                        while (reader.Read ())
                        {
                            Candidato candidato = new Candidato();

                            candidato.Cedula = reader.GetInt64(0);
                            candidato.Nombre = reader.GetString(1);
                            candidato.Email = reader.GetString(2);
                            candidato.Aspiracion_salarial = reader.GetDecimal(3);
                            candidato.vacante = reader.GetString(4);
                            
                            candidatos.Add(candidato);
                        }

                        conn.Close();
                        return candidatos;
                    }
                }
            }
        }

        public bool Add (Candidato candidato)
        {
            using (SqlConnection conn = new SqlConnection(DB_Conection.conexion))
            {
                string query = "INSERT INTO Candidato (Cedula, Nombre, Email, AspiracionSalarial, VacanteAplicar)" +
                    " VALUES (@Cedula, @Nombre, @Email, @AspiracionSalarial, @VacanteAplicar)";

                conn.Open ();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@Cedula", candidato.Cedula);
                        cmd.Parameters.AddWithValue("@Nombre", candidato.Nombre);
                        cmd.Parameters.AddWithValue("@Email", candidato.Email);
                        cmd.Parameters.AddWithValue("@AspiracionSalarial", candidato.Aspiracion_salarial);
                        cmd.Parameters.AddWithValue("@VacanteAplicar", candidato.vacante);
                        cmd.ExecuteNonQuery();

                        conn.Close();
                        return true;
                    } catch { return false; }
                }
            }
        }

        public bool Update (Candidato candidato)
        {
            using (SqlConnection conn = new SqlConnection(DB_Conection.conexion))
            {
                string query = "UPDATE Candidato SET AspiracionSalarial = @AspSalarial" +
                    " WHERE Cedula = @Cedula";

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@Cedula", candidato.Cedula);
                        cmd.Parameters.AddWithValue("@AspSalarial", candidato.Aspiracion_salarial);
                        cmd.ExecuteNonQuery();

                        conn.Close();
                        return true;
                    }
                    catch { return false;  }
                }
            }
        }

        public bool Delete (long cedula)
        {
            using (SqlConnection conn = new SqlConnection(DB_Conection.conexion))
            {
                string query = "DELETE Candidato WHERE Cedula = @Cedula";

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@Cedula", cedula);
                        cmd.ExecuteNonQuery();

                        conn.Close();
                        return true;
                    }
                    catch { return false; }
                }
            }
        }
    }
}
