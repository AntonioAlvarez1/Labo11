using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Newtonsoft.Json;

namespace Labo11
{
    public partial class Eliminar : System.Web.UI.Page
    {
        static List<Universidad> Universidadtemp = new List<Universidad>();
        static string carne;
        protected void Page_Load(object sender, EventArgs e)
        {

            string archivo = Server.MapPath("Universidades.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            Universidadtemp = JsonConvert.DeserializeObject<List<Universidad>>(json);

        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            carne = TextBoxCarne.Text;
            bool encontrado = false;
            foreach (var u in Universidadtemp)
            {
                Alumno alumnoEditar = u.Alumnos.Find(c => c.Carne == carne);
                if (alumnoEditar != null)
                {
                    TextBoxNombre.Text = alumnoEditar.Nombre;
                    TextBoxApellido.Text = alumnoEditar.Apellido;
                    encontrado = true;
                }
                if (!encontrado)
                {
                    Response.Write("<script>alert('No se encontro')</script>");
                    carne = "";
                    TextBoxCarne.Text = "";
                    TextBoxNombre.Text = "";
                    TextBoxApellido.Text = "";
                }

            }


        }
        private void GuardarJason()
        {
            string json = JsonConvert.SerializeObject(Universidadtemp);
            string archivo = Server.MapPath("Universidades.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            foreach (var u in Universidadtemp)
            {
                Alumno alumnoborrar = u.Alumnos.Find(c=>c.Carne==carne);
                if (alumnoborrar !=null)
                {
                    u.Alumnos.Remove(alumnoborrar);
                    
                }
            }
            GuardarJason();
        }
    }
}