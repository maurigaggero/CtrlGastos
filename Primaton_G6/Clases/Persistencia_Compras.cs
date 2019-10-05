using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primaton_G6.Clases
{
    public class Persistencia_Compras
    {
        #region PROPIEDADES PRIVADAS
        /// <summary>
        /// Path y nombre del archivo
        /// </summary>
        private const string NombreArchivo = @"compras.xml";

        Compras g = new Compras();

        /// <summary>
        /// Tabla en memoria con la lista de personas
        /// </summary>
        public DataTable TablaCompras = new DataTable("TablaCompras");

        Clases.Persistencia_Usuarios user = new Clases.Persistencia_Usuarios();
        #endregion

        #region METODOS

        /// <summary>
        /// Diseña columnas del datatable, 
        /// verifica si el archivo existe previamente
        /// asigna tabla al DataGridView
        /// </summary>

        public void ConfigInicial()  // diseño de la TablaCompra
        {
            TablaCompras.Columns.Add("Cantidad");
            TablaCompras.Columns.Add("Producto");

        }

        public void NuevaCompra(string cantidad, string producto)
        {
            g.Cantidad = cantidad;
            g.Producto = producto;

            // agrega el gasto
            {
                TablaCompras.Rows.Add();


                TablaCompras.Rows[TablaCompras.Rows.Count - 1]["Cantidad"] = g.Cantidad;
                TablaCompras.Rows[TablaCompras.Rows.Count - 1]["Producto"] = g.Producto;

                TablaCompras.WriteXml(NombreArchivo);

                MessageBox.Show("Gasto cargado con éxito!");
            }
        }


        //public void EliminaGastosUsuario(string nombre)
        //{
        //    TablaGastos.ReadXmlSchema(NombreArchivo);
        //    for (int i = TablaGastos.Rows.Count - 1; i >= 0; i--)
        //    {
        //        DataRow fila = TablaGastos.Rows[i];
        //        if (fila["Usuario"].ToString() == nombre)
        //        {
        //            fila.Delete();
        //        }
        //        TablaGastos.WriteXml(NombreArchivo);
        //    }
        //}

        /// <summary>
        /// Rellena las columnas del último registro agregado con los valores del textbox correspondiente
        /// </summary>
        /// 

        public void LeeCompras()
        {
            // busca si el archivo ya existe para precargar sus datos
            if (System.IO.File.Exists(NombreArchivo))
            {
                TablaCompras.ReadXml(NombreArchivo);
            }
        }
        #endregion
    }
}
