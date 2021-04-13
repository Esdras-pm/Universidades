using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Universidades
{
    public partial class _Default : Page
    {
        static List<Universidades> unis = new List<Universidades>();
        static List<Estudiante> est = new List<Estudiante>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string archivo = Server.MapPath("Universidades.json");
                StreamReader jsonStream = File.OpenText(archivo);

                string json = jsonStream.ReadToEnd(); jsonStream.Close();
                unis = JsonConvert.DeserializeObject<List<Universidades>>(json);

            }
        }
        private void GuardarJson()
        {
            string json = JsonConvert.SerializeObject(unis);
            string archivo = Server.MapPath("Universidades.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void universidad_btn(object sender, EventArgs e)
        {
            
        }

        protected void AlumnoButton_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Nombre = estudiante_txt.Text;

            est.Add(estudiante);
            estudiante_txt.Text = "";
        }

        protected void UnisButton_Click(object sender, EventArgs e)
        {
            Universidades universidad = new Universidades();
            universidad.Universidad = uni_txt.Text;
            universidad.Estudiantes = est.ToList();

            unis.Add(universidad);

            GuardarJson();

            est.Clear();
        }
    }
}