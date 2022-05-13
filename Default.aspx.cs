using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Labo11
{
    public partial class _Default : Page
    {
        static List<Nota> NotasTemp = new List<Nota>();
        static List<Alumno> AlumnoTemp = new List<Alumno>();
        static List<Universidad> universida = new List<Universidad>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void GuardarJason()
        {
            string json = JsonConvert.SerializeObject(universida);
            string archivo = Server.MapPath("Universidades.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void IngresarNotas_Click(object sender, EventArgs e)
        {
            Nota nota = new Nota();
            nota.Curso = TextBoxCurso.Text;
            nota.Punteo = Convert.ToInt16(TextBoxPunteo.Text);
            NotasTemp.Add(nota);
            GridView1.DataSource = NotasTemp;
            GridView1.DataBind();
        }

        protected void ButtonIngresoAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = TextBoxNombre.Text;
            alumno.Apellido = TextBoxApellido.Text;
            alumno.Carne = TextBoxCarne.Text;
            alumno.Notas = NotasTemp.ToArray().ToList();
            AlumnoTemp.Add(alumno);
            NotasTemp.Clear();

        }

        protected void ButtonGuardaU_Click(object sender, EventArgs e)
        {
            Universidad universidad = new Universidad();
            universidad.Nombre = DropDownList1.SelectedValue;
            universidad.Alumnos = AlumnoTemp.ToArray().ToList();
            universida.Add(universidad);
            AlumnoTemp.Clear();
            GuardarJason();
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            }
    }
}