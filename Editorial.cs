using System;
using System.Collections.Generic;

namespace EjercicioEditorial
{
    public class Editorial
    {
        public string nombre;

        public List<Edicion> ediciones;

        public Editorial()
        {
            ediciones = new List<Edicion>();
        }

        public void informarAutores()
        {
            foreach (Edicion edicion in ediciones)
            {
                //Nombre1 Apellido1, 
                //Nombre2 Apellido2,
                //Nombre3 Apellido3,
                foreach (Autor autor in edicion.autores)
                {
                    Console.WriteLine($"{Char.ToUpper(autor.nombre[0]) + autor.nombre.Substring(1, autor.nombre.Length - 1)} {Char.ToUpper(autor.apellido[0]) + autor.apellido.Substring(1, autor.apellido.Length - 1)}, ");
                }
            }
        }

        public void informarEdiciones()
        {
            foreach (Edicion edicion in ediciones)
            {
                Console.WriteLine($"Titulo: {edicion.titulo}");
                Console.WriteLine($"Paginas: {edicion.cantidadPaginas}");
                Console.WriteLine($"Numero: {edicion.nro}");
                string autoresEdicion = "Autores: ";
                foreach (Autor autor in edicion.autores)
                {
                    autoresEdicion += $"{autor.nombre} {autor.apellido}, ";
                }
                autoresEdicion.Substring(0, autoresEdicion.Length - 2);
                Console.WriteLine(autoresEdicion);
            }
        }
    }
}