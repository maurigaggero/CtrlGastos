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
        Usuario usuario = new Usuario();

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

        #region CONSTRUCTORES
        private void BtGrabar_Click(object sender, EventArgs e)
        {
            TablaUsuarios.WriteXml(NombreArchivo);
        }
        #endregion

        #region METODOS

        /// <summary>
        /// Diseña columnas del datatable, 
        /// verifica si el archivo existe previamente
        /// asigna tabla al DataGridView
        /// </summary>
        public void ConfiguracionInicial()
        {
            // diseño de la TablaPersona
            TablaUsuarios.Columns.Add("Id");
            TablaUsuarios.Columns.Add("Nombre");
            TablaUsuarios.Columns.Add("Ingresos");
            

            // busca si el archivo ya existe para precargar sus datos
            if (System.IO.File.Exists(NombreArchivo))
            {
                TablaUsuarios.ReadXml(NombreArchivo);
            }

            //// asigna TablaPersona a dgvPersonas
            //dgvPersonas.DataSource = TablaPersona;
            //// elimina la posibilidad de ingresar datos en el datagridview
            //dgvPersonas.AllowUserToAddRows = false;
            //// elimina el encabezado de las filas
            //dgvPersonas.RowHeadersVisible = false;
        }

        // Llena con string vacio los texbox
        //private void LimpiarCampos()
        //{
        //    txtNombre.Text = "";
        //    txtDomicilio.Text = "";
        //    txtEdad.Text = "";
        //    txtDNI.Text = "";
        //}

        /// <summary>
        /// Rellena las columnas del último registro agregado con los valores del textbox correspondiente
        /// </summary>
        /// 
        public string GetUsuario(int id)
        {
            usuario.Id = id;

            return usuario.Nombre;
        }

        public void EliminaUsuario()
        {

        }
        public void AltaUsuario(string nombre, int ingresos)
        {

            // Agrega registro nuevo a la tabla
            TablaUsuarios.Rows.Add();

            ingresos = usuario.Ingresos;
            nombre = usuario.Nombre;

            TablaUsuarios.Rows[TablaUsuarios.Rows.Count - 1]["Id"] = "id";
            TablaUsuarios.Rows[TablaUsuarios.Rows.Count - 1]["Nombre"] = nombre;
            TablaUsuarios.Rows[TablaUsuarios.Rows.Count - 1]["Ingresos"] = ingresos;
        }
        #endregion
    }
}





//        Usuario[] listaUsuarios = new Usuario[10];

//        public void AgregaObjeto(Usuario usuario)
//        {
//            listaUsuarios[1] = usuario;
//        }

//        public int ContarRegistros()
//        {
//            int conteo = 0;
//            for (int i = 0; i < listaUsuarios.Length; i++)
//            {
//                if (listaUsuarios[i] == null)
//                {
//                    conteo = i;
//                    i = listaUsuarios.Length;
//                }
//            }
//            return conteo;
//        }

//    }
//}

//        public string[] devuelvelista()
//        {
//            string[] lista = usuario;

//            return usuario;

//        }

//        public void muestrausuario()
//        {
//            file.delete(ruta);

//            streamwriter escribir = new streamwriter(ruta, true);

//            string mrespuesta = "usuario,ingresos" + "\r\n";

//            mrespuesta = mrespuesta + usuario[0] + "," + ingresos[0] + "\r\n";
//            mrespuesta = mrespuesta + usuario[1] + "," + ingresos[1] + "\r\n";
//            mrespuesta = mrespuesta + usuario[2] + "," + ingresos[2] + "\r\n";
//            mrespuesta = mrespuesta + usuario[3] + "," + ingresos[3] + "\r\n";

//            //for (int k = 0; k < usuario.length; k++)
//            //{
//            //   mrespuesta = mrespuesta + usuario[k] + "," + ingresos[k] + "\r\n";
//            //}

//            escribir.writeline(mrespuesta);
//            escribir.close();

//            if (!file.exists(ruta))
//            {
//                file.create(ruta).dispose();
//            }
//        }
//    }
//}