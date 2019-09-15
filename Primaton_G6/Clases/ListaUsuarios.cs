using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Primaton_G6.Clases
{
    public class ListaUsuarios
    {
        #region PROPIEDADES PRIVADAS
        /// <summary>
        /// Path y nombre del archivo
        /// </summary>
        private const string NombreArchivo = @"usuarios.xml";

        /// <summary>
        /// Tabla en memoria con la lista de personas
        /// </summary>
        public System.Data.DataTable TablaUsuarios = new DataTable("TablaUsuarios");
        #endregion

        #region METODOS

        /// <summary>
        /// Diseña columnas del datatable, 
        /// verifica si el archivo existe previamente
        /// asigna tabla al DataGridView
        /// </summary>
        public void ConfigInicial()  // diseño de la TablaPersona
        {
            TablaUsuarios.Columns.Add("Id");
            TablaUsuarios.Columns.Add("Nombre");
            TablaUsuarios.Columns.Add("Ingresos");
        }

        /// <summary>
        /// Rellena las columnas del último registro agregado con los valores del textbox correspondiente
        /// </summary>
        /// 

        //public (string nombre, int ingresos) GetUsuario(int id)
        //{
        //    Usuario usuario = new Usuario();

        //    if (id == usuario.Id)
        //    {

        //    }
        //    return (usuario.Nombre, usuario.Ingresos);
        //}

        public void LeeUsuarios()
        {
            // busca si el archivo ya existe para precargar sus datos
            if (System.IO.File.Exists(NombreArchivo))
            {
                TablaUsuarios.ReadXml(NombreArchivo);
            }
        }

        public void AltaUsuarios(string nombre, int ingresos)
        {
            {
                Usuario u = new Usuario();

                u.Nombre = nombre;
                u.Ingresos = ingresos;

                Random random = new Random();

                u.Id = random.Next(1000, 9999);


                TablaUsuarios.Rows[TablaUsuarios.Rows.Count - 1]["Id"] = u.Id;
                TablaUsuarios.Rows[TablaUsuarios.Rows.Count - 1]["Nombre"] = nombre;
                TablaUsuarios.Rows[TablaUsuarios.Rows.Count - 1]["Ingresos"] = ingresos;

                TablaUsuarios.WriteXml(NombreArchivo);
            }
        }

        public void DevuelveFila(string nombre)
        {
            for (int i = TablaUsuarios.Rows.Count - 1; i >= 0; i--)
            {
                DataRow fila = TablaUsuarios.Rows[i];
                if (fila["Nombre"].ToString() == nombre)
                {

                }
            }
        }

        public void EliminaUsuario(string name)
        {
            for (int i = TablaUsuarios.Rows.Count - 1; i >= 0; i--)
            {
                DataRow fila = TablaUsuarios.Rows[i];
                if (fila["Nombre"].ToString() == name)
                    fila.Delete();
            }

            TablaUsuarios.WriteXml(NombreArchivo);
        }
        #endregion
    }

    //public void EliminaUsuario(int id)
    //{
    //    TablaUsuarios.Rows.RemoveAt(id);

    //    TablaUsuarios.WriteXml(NombreArchivo);
    //}
}