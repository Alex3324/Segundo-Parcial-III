using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial2
{
    public class canciones
    {
        string nombrecancion;
        string artista;
        string tiempoduracion;

        public string Nombrecancion { get => nombrecancion; set => nombrecancion = value; }
        public string Artista { get => artista; set => artista = value; }
        public string Tiempoduracion { get => tiempoduracion; set => tiempoduracion = value; }

    }

    public class archivoalbum {
        string titulo;
        string artistaalbum;
        List<canciones> Canciones = new List<canciones>();
        DateTime fachapublicacion;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Artistaalbum { get => artistaalbum; set => artistaalbum = value; }
        public List<canciones> Canciones1 { get => Canciones; set => Canciones = value; }
        public DateTime Fachapublicacion { get => fachapublicacion; set => fachapublicacion = value; }
        public archivoalbum()
        {
            Canciones1 = new List<canciones>();
        }
    }
    
}