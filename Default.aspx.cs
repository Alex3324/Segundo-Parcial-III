using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial2
{
    public partial class _Default : Page
    {
        static int x = 0;
        static List<canciones> Canciones = new List<canciones>();
        static List<archivoalbum> albums = new List<archivoalbum>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (x == 0)
            {
                Calendar1.Visible = false;
                TextBox1.Visible = false;
                TextBox2.Visible = false;
                TextBox3.Visible = false;
                TextBox4.Visible = false;
                TextBox5.Visible = false;
                Button1.Visible = false;
                Button2.Visible = false;
                GridView1.Visible = false;
                Button4.Visible = false;
                Button5.Visible = false;
                TextBox7.Visible = false;
                string archivo = Server.MapPath("AlbumJson.json");
                StreamReader jsonStream = File.OpenText(archivo);
                string json = jsonStream.ReadToEnd();
                jsonStream.Close();
                albums = JsonConvert.DeserializeObject<List<archivoalbum>>(json);
                x++;
            }
        }

        void GuardarJson()
        {
            string json = JsonConvert.SerializeObject(albums);
            string archivo = Server.MapPath("AlbumJson.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            canciones cancion = new canciones();
            cancion.Nombrecancion = TextBox1.Text;
            cancion.Artista = TextBox2.Text;
            cancion.Tiempoduracion = TextBox3.Text;
            Canciones.Add(cancion);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //  int indice = GridView1.SelectedIndex;

            archivoalbum a = new archivoalbum();
            a.Titulo = TextBox4.Text;
            a.Artistaalbum = TextBox5.Text;
            a.Canciones1 = Canciones.ToList();
            a.Fachapublicacion = Calendar1.SelectedDate.Date;
            albums.Add(a);
            GuardarJson();
            Canciones.Clear();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            archivoalbum uni = albums.Find(u => u.Titulo == TextBox6.Text);
            if (uni != null)
            {
                GridView1.Visible = true;
                Button4.Visible = true;
                Button5.Visible = true;
                TextBox7.Visible = true;

                int i = 0;
                int band = 0;
                while (i < albums.Count)
                {
                    if (String.Equals(albums[i].Titulo, TextBox6.Text))
                    {
                        band = i;
                    }
                    i++;
                }
                Label2.Text = albums[band].Titulo;
                TextBox8.Text = albums[band].Artistaalbum;
                GridView1.DataSource = albums[band].Canciones1;
                GridView1.DataBind();
            }
            else
            {
                Calendar1.Visible = true;
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                Button1.Visible = true;
                Button2.Visible = true;
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            TextBox7.Visible = true;
            TextBox9.Visible = true;
            TextBox10.Visible = true;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int elegido = GridView1.SelectedIndex;

            int u = 0;
            int bands = 0;
            while (u < albums.Count)
            {
                if (String.Equals(albums[u].Titulo, TextBox6.Text))
                {
                    bands = u;
                }
                u++;
            }
            Label2.Text = albums[elegido].Titulo;
            TextBox8.Text = albums[elegido].Artistaalbum;
            canciones can = new canciones();
            can.Nombrecancion = TextBox7.Text;
            can.Artista = TextBox9.Text;
            can.Tiempoduracion = TextBox10.Text;
            Canciones.Add(can);
            albums[bands].Canciones1 = Canciones.ToList();
            GuardarJson();
            Canciones.Clear();
            Label1.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            TextBox7.Visible = false;
            TextBox9.Visible = false;
            TextBox10.Visible = false;

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            archivoalbum uni = albums.Find(g => g.Artistaalbum == TextBox11.Text);
            int u = 0;
            int bands = 0;
            while (u < albums.Count)
            {
                if (String.Equals(albums[u].Titulo, TextBox6.Text))
                {
                    bands = u;
                }
                u++;
            }
            if (uni != null)
            {
                GridView2.DataSource = albums[bands].Canciones1;
                GridView2.DataBind();
            }
        }
    }
}