using ExameFinalDeProgramacion_AnthonnyBlanco.Modulo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ExameFinalDeProgramacion_AnthonnyBlanco.CapaAccesoDatos
{
    public class RepositorioViajeros
    {
        public static void IngresarViajeros(int cedula, string nombre, string apellido1, string apellido2, string ubicacion, int edad)
        {
            // Consulta SQL para insertar datos en la tabla votantes
            string query = "INSERT INTO RegistroViajeros (cedula, nombre, apellido1, apellido2, ubicacion, edad) " +
                           "VALUES (@cedula, @nombre, @apellido1, @apellido2, @ubicacion, @edad)";

            // Obtener la cadena de conexión desde la configuración
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            // Crear una nueva conexión y comando dentro de un bloque using para asegurar que se liberen los recursos correctamente
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                conexion.Open();

                // Crear el comando SQL con la consulta y la conexión
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    // Agregar parámetros al comando para evitar la inyección SQL y asegurar la correcta asignación de tipos de datos
                    comando.Parameters.AddWithValue("@cedula", Viajeros.Cedula);
                    comando.Parameters.AddWithValue("@nombre", Viajeros.nombre);
                    comando.Parameters.AddWithValue("@apellido1", Viajeros.apellido1);
                    comando.Parameters.AddWithValue("@apellido2", Viajeros.apellido2);
                    comando.Parameters.AddWithValue("@ubicacion", Viajeros.ubicacion);
                    comando.Parameters.AddWithValue("@edad", Viajeros.edad);

                    // Ejecutar el comando SQL para insertar los datos
                    int filasAfectadas = comando.ExecuteNonQuery();

                    // Verificar si se insertaron filas correctamente
                    if (filasAfectadas > 0)
                    {
                        // Éxito: los datos se insertaron correctamente
                        Console.WriteLine("Datos insertados correctamente en la base de datos.");
                    }
                    else
                    {
                        // Manejar el caso en que no se insertaron filas (esto debería ser poco probable si no hay errores)
                        Console.WriteLine("No se pudo insertar los datos en la base de datos.");
                    }
                }
            }
        }

        public static void EntradaViajeros(int cedula, string paisProcede, string fechaEntrada, string visa)
        {
            // Consulta SQL para insertar datos en la tabla EntradaViajeros
            string query = "INSERT INTO EntradaViajeros (CEDULA, PAISPROCEDE, FECHADEENTRADA, VISA) " +
                           "VALUES (@cedula, @paisProcede, @fechaEntrada, @visa)";

            // Obtener la cadena de conexión desde la configuración
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            // Crear una nueva conexión y comando dentro de un bloque using para asegurar que se liberen los recursos correctamente
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                conexion.Open();

                // Crear el comando SQL con la consulta y la conexión
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    // Agregar parámetros al comando para evitar la inyección SQL y asegurar la correcta asignación de tipos de datos
                    comando.Parameters.AddWithValue("@cedula", EntradaViajeros.Cedula);
                    comando.Parameters.AddWithValue("@paisProcede", EntradaViajeros.paisProcede);
                    comando.Parameters.AddWithValue("@fechaEntrada", EntradaViajeros.fechaEntrada);
                    comando.Parameters.AddWithValue("@visa", EntradaViajeros.visa);
        
        // Ejecutar el comando SQL para insertar los datos
        int filasAfectadas = comando.ExecuteNonQuery();

                    // Verificar si se insertaron filas correctamente
                    if (filasAfectadas > 0)
                    {
                        // Éxito: los datos se insertaron correctamente
                        Console.WriteLine("Datos insertados correctamente en la base de datos.");
                    }
                    else
                    {
                        // Manejar el caso en que no se insertaron filas (esto debería ser poco probable si no hay errores)
                        Console.WriteLine("No se pudo insertar los datos en la base de datos.");
                    }
                }
            }
        }

    }
}