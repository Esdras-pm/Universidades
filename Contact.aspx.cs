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
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("Universidades.json");
            StreamReader jsonStream = File.OpenText(archivo);

            string json = jsonStream.ReadToEnd(); 
            unis = JsonConvert.DeserializeObject<List<Universidades>>(json);
            int seleccionada = GridView1.SelectedIndex;
            GridView1.DataSource = unis;
            GridView1.DataBind();
        }

        protected void ButtonCargar_Click(object sender, EventArgs e)
        {
            int selec = GridView1.SelectedIndex;
            GridView2.DataSource = unis[selec].Estudiantes;
            GridView2.DataBind();
        }
    }
}