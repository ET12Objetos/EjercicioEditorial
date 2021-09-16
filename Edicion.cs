using System.Collections.Generic;

namespace EjercicioEditorial
{
    public class Edicion
    {
        public string titulo;

        public int nro;

        public int cantidadPaginas;

        public List<Autor> autores;

        public Edicion()
        {
            autores = new List<Autor>();
        }
    }
}