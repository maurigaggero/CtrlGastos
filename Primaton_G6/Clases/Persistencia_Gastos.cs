using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Primaton_G6.Clases
{
    class Persistencia_Gastos
    {
        #region PROPIEDADES PRIVADAS
        /// <summary>
        /// Path y nombre del archivo
        /// </summary>
        private const string NombreArchivo = @"gastos.xml";

        Gastos g = new Gastos();

        /// <summary>
        /// Tabla en memoria con la lista de personas
        /// </summary>
        public DataTable TablaGastos = new DataTable("TablaGastos");
        #endregion

        #region METODOS

        /// <summary>
        /// Diseña columnas del datatable, 
        /// verifica si el archivo existe previamente
        /// asigna tabla al DataGridView
        /// </summary>

        public void ConfigInicial()  // diseño de la TablaPersona
        {
            TablaGastos.Columns.Add("Id");
            TablaGastos.Columns.Add("Usuario");
            TablaGastos.Columns.Add("Fecha");
            TablaGastos.Columns.Add("Rubro");
            TablaGastos.Columns.Add("Prioridad");
            TablaGastos.Columns.Add("Descripcion");
            TablaGastos.Columns.Add("Importe");
        }

        

        public void NuevoGasto(string usuario, string rubro, DateTime fecha, string descripcion, double importe)
        {
            g.Id = "0000";
            g.Usuario = usuario;
            g.Fecha = fecha;
            //g.Prioridad;
            g.Rubro = rubro;
            g.Descripcion = descripcion;
            g.Importe = importe;

            // agrega el gasto
            {

                TablaGastos.Rows.Add();
                TablaGastos.Rows[TablaGastos.Rows.Count - 1]["Usuario"] = g.Usuario;
                TablaGastos.Rows[TablaGastos.Rows.Count - 1]["Id"] = g.Id;
                
                TablaGastos.Rows[TablaGastos.Rows.Count - 1]["Fecha"] = g.Fecha;
                TablaGastos.Rows[TablaGastos.Rows.Count - 1]["Rubro"] = g.Rubro;
                //TablaGastos.Rows[TablaGastos.Rows.Count - 1]["Prioridad"] = ;
                TablaGastos.Rows[TablaGastos.Rows.Count - 1]["Descripcion"] = g.Descripcion;
                TablaGastos.Rows[TablaGastos.Rows.Count - 1]["Importe"] = g.Importe;

                TablaGastos.WriteXml(NombreArchivo);

                MessageBox.Show("Gasto cargado con éxito!");
            }
        }

        /// <summary>
        /// Rellena las columnas del último registro agregado con los valores del textbox correspondiente
        /// </summary>
        /// 

        public void LeeGastos()
        {
            // busca si el archivo ya existe para precargar sus datos
            if (System.IO.File.Exists(NombreArchivo))
            {
                TablaGastos.ReadXml(NombreArchivo);
            }
        }

        #endregion
    }
}