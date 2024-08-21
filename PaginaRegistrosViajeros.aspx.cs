using ExameFinalDeProgramacion_AnthonnyBlanco.CapaAccesoDatos;
using ExameFinalDeProgramacion_AnthonnyBlanco.Modulo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExameFinalDeProgramacion_AnthonnyBlanco.Vistas
{
    public partial class PaginaRegistrosViajeros : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los controles de texto y convertirlos según sea necesario
                Viajeros.Cedula = Convert.ToInt32(txtCedula.Text);
                Viajeros.nombre = txtNombre.Text;
                Viajeros.apellido1 = txtApellido1.Text;
                Viajeros.apellido2 = txtApellido2.Text;
                Viajeros.ubicacion = txtUbicacion.Text;
                Viajeros.edad = Convert.ToInt32(txtEdad.Text);

                // Llamar al método IngresarDatos para insertar los datos en la base de datos
                RepositorioViajeros.IngresarViajeros(Viajeros.Cedula, Viajeros.nombre, Viajeros.apellido1, Viajeros.apellido2, Viajeros.ubicacion, Viajeros.edad);

                // Mostrar mensaje de éxito o realizar otras acciones después de insertar los datos
                // Por ejemplo:
                Response.Write("<script>alert('Datos ingresados correctamente.');</script>");
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante el proceso
                Response.Write($"<script>alert('Error: {ex.Message}');</script>");
            }
        }
    }
}