using Capa_data.Conexion;
using Capa_data.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_negocio.Services
{
    public class Dvacante
    {

        public List<Vacante> GetAll ()
        {
            List<Vacante> vacantes = new List<Vacante>();

            using (SqlConnection conn = new SqlConnection(DB_Conection.conexion))
            {
                string query = "SELECT * FROM Vacante";
                
                conn.Open ();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Vacante vacante = new Vacante();

                            vacante.Id = reader.GetInt32(0);
                            vacante.Nombre = reader.GetString(1);
                            vacante.Salario = reader.GetDecimal(2);
                            vacante.Disponibilidad = reader.GetBoolean(3);

                            vacantes.Add(vacante);
                        }

                        conn.Close();
                        return vacantes;
                    }
                }
            }
        }

        public bool Add (Vacante vacante)
        {
            using (SqlConnection conn = new SqlConnection(DB_Conection.conexion))
            {
                string query = "INSERT INTO Vacante (Nombre, Salario, Estado)" +
                    "VALUES (@Nombre, @Salario, @Disponibilidad)";

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@Nombre", vacante.Nombre);
                        cmd.Parameters.AddWithValue("@Salario", vacante.Salario);
                        cmd.Parameters.AddWithValue("@Disponibilidad", vacante.Disponibilidad);
                        cmd.ExecuteNonQuery();

                        conn.Close();
                        return true;
                    } catch { return false; }
                }
            }
        }

        public bool Update(Vacante vacante)
        {
            using (SqlConnection conn = new SqlConnection(DB_Conection.conexion))
            {
                string query = "UPDATE Vacante SET Salario = @Salario, Estado = @Disponibilidad " +
                    "WHERE Id = @Id";

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@Id", vacante.Id);
                        cmd.Parameters.AddWithValue("@Salario", vacante.Salario);
                        cmd.Parameters.AddWithValue("@Disponibilidad", vacante.Disponibilidad);
                        cmd.ExecuteNonQuery();

                        conn.Close();
                        return true;
                    }
                    catch { return false; }
                }
            }
        }

        public bool Delete (int id)
        {
            using (SqlConnection conn = new SqlConnection(DB_Conection.conexion))
            {
                string query = "DELETE FROM Vacante WHERE Id = @Id";

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
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
