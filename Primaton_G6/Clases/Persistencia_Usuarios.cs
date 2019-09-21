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
    public class Persistencia_Usuarios
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
            TablaUsuarios.Columns.Add("Img");
        }

        /// <summary>
        /// Rellena las columnas del último registro agregado con los valores del textbox correspondiente
        /// </summary>
        /// 

        public void LeeUsuarios()
        {
            // busca si el archivo ya existe para precargar sus datos
            if (System.IO.File.Exists(NombreArchivo))
            {
                TablaUsuarios.ReadXml(NombreArchivo);
            }
        }

        public void AltaUsuarios(string nombre, int ingresos, int img)
        {
            {
                Usuario u = new Usuario();

                u.Nombre = nombre;
                u.Ingresos = ingresos;
                u.Img = img;

                Random random = new Random();

                int contador = 0;

                //recorre la tabla, si existe un usuario suma el contador
                for (int i = TablaUsuarios.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow fila = TablaUsuarios.Rows[i];
                    if (fila["Nombre"].ToString() == nombre)
                    {
                        MessageBox.Show("Ya existe un usuario con el mismo nombre. Elija otro", "Hubo un problema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        contador++;
                    }
                }
                //sino agrega el usuario
                if (contador == 0)
                {
                    u.Id = random.Next(1000, 9999);

                    TablaUsuarios.Rows.Add();

                    TablaUsuarios.Rows[TablaUsuarios.Rows.Count - 1]["Id"] = u.Id;
                    TablaUsuarios.Rows[TablaUsuarios.Rows.Count - 1]["Nombre"] = nombre;
                    TablaUsuarios.Rows[TablaUsuarios.Rows.Count - 1]["Ingresos"] = ingresos;
                    TablaUsuarios.Rows[TablaUsuarios.Rows.Count - 1]["Img"] = img;

                    TablaUsuarios.WriteXml(NombreArchivo);

                    MessageBox.Show("Usuario creado con éxito! Vuelva a cargar el programa para actualizar");
                }
            }
        }

        public void EliminaUsuario(string name)
        {
            // recorre la tabla, si el argumento es igual a un valor en la columna nombre lo borra
            for (int i = TablaUsuarios.Rows.Count - 1; i >= 0; i--)
            {
                DataRow fila = TablaUsuarios.Rows[i];
                if (fila["Nombre"].ToString() == name)
                    fila.Delete();
            }
            TablaUsuarios.WriteXml(NombreArchivo);

        }

        public string DevuelveIngresos(string nombre)
        {
            try
            {
                for (int i = TablaUsuarios.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow fila = TablaUsuarios.Rows[i];
                    if (fila["Nombre"].ToString() == nombre)
                    {
                        return fila["Ingresos"].ToString();
                    }
                }
                return "0";
            }
            catch (System.Data.RowNotInTableException)
            {
                MessageBox.Show("Usuario eliminado");
                return null;
            }
            
        }

        public string DevuelveFoto(string nombre)
        {
            try
            {
                for (int i = TablaUsuarios.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow fila = TablaUsuarios.Rows[i];
                    if (fila["Nombre"].ToString() == nombre)
                    {
                        return fila["Img"].ToString();
                    }
                }
                return "0";
            }
            catch (System.Data.RowNotInTableException)
            {
                return null;
            }
        }

        public void ModificaIngreso(string name)
        {

        }
        #endregion
    }

    //public void EliminaUsuario(int id)
    //{
    //    TablaUsuarios.Rows.RemoveAt(id);

    //    TablaUsuarios.WriteXml(NombreArchivo);
    //}
}