using Primaton_G6.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primaton_G6.Clases
{
    public class Usuario
    {
        private int Id { get; set; }

        private string Nombre { get; set; }

        private string Apellido { get; set; }

        private int Ingresos { get; set; }

        public string GetUsuario(string Nombre)
        {
            Usuario usuario = new Usuario();

            return Nombre;
        }

        public void AltaUsuarios(string nombre, string apellido, int ingresos)
        {
            Usuario usuario = new Usuario();
            usuario.Ingresos = ingresos;
            usuario.Apellido = apellido;
            usuario.Nombre = nombre;

            Listas nuevaLista = new Listas();
            nuevaLista.AgregaObjeto(usuario);
            
        }
        public void EliminaUsuario()
        {

        }

        public Usuario[] GetUsuarios()
        {
            return null;
        }
    }
}
