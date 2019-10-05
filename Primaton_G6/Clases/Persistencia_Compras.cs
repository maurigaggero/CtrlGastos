using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primaton_G6.Clases
{
    public class Compras
    {
        public string Cantidad { get; set; }
        public string Producto { get; set; }
    }

    public class Persistencia_Compras
    {
        #region PROPIEDADES PRIVADAS
        /// <summary>
        /// Path y nombre del archivo
        /// </summary>
        private const string NombreArchivo = @"compras.xml";

        Compras c = new Compras();

        /// <summary>
        /// Tabla en memoria con la lista de personas
        /// </summary>
        public DataTable TablaCompras = new DataTable("TablaCompras");

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
            c.Cantidad = cantidad;
            c.Producto = producto;

            // agrega a lista
            {
                TablaCompras.Rows.Add();

                TablaCompras.Rows[TablaCompras.Rows.Count - 1]["Cantidad"] = c.Cantidad;
                TablaCompras.Rows[TablaCompras.Rows.Count - 1]["Producto"] = c.Producto;

                TablaCompras.WriteXml(NombreArchivo);

                MessageBox.Show("Producto agregado a la lista");
            }
        }

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
