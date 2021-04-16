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
    public partial class Contact : Page
    {
        static List<Universidades> unis = new List<Universidades>();
        static List<Estudiante> est = new List<Estudiante>();
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("Universidades.json");
            StreamReader jsonStream = File.OpenText(archivo);

            string json = jsonStream.ReadToEnd(); jsonStream.Close();
            unis = JsonConvert.DeserializeObject<List<Universidades>>(json);
            GridView1.DataSource = unis;
            GridView1.DataBind();
        }
        private void GuardarJson()
        {
            string json = JsonConvert.SerializeObject(unis);
            string archivo = Server.MapPath("Universidades.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selec = GridView1.SelectedIndex;
            GridView2.DataSource = unis[selec].Estudiantes;
            GridView2.DataBind();
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selec = GridView1.SelectedIndex;
            int selec2 = GridView2.SelectedIndex;
            estmod_txt.Text = unis[selec].Estudiantes[selec2].Nombre.ToString();
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            int selec = GridView1.SelectedIndex;
            int selec2 = GridView2.SelectedIndex;
            unis[selec].Estudiantes.RemoveAt(selec2);
            GridView2.DataSource = unis[selec].Estudiantes;
            GridView2.DataBind();
            GuardarJson();
        }

        protected void ButtonModificar_Click(object sender, EventArgs e)
        {
            int selec = GridView1.SelectedIndex;
            int selec2 = GridView2.SelectedIndex;
            unis[selec].Estudiantes.RemoveAt(selec2);
            Estudiante estudiante = new Estudiante();
            est = unis[selec].Estudiantes;
            estudiante.Nombre = estmod_txt.Text;

            est.Add(estudiante);
            estmod_txt.Text = "";
            Universidades universidad = new Universidades();
            universidad.Universidad = unis[selec].Universidad;
            universidad.Estudiantes = est.ToList();

            unis.Add(universidad);

            GuardarJson();
            GridView2.DataSource = unis[selec].Estudiantes;
            GridView2.DataBind();
            est.Clear();
        }
    }
}