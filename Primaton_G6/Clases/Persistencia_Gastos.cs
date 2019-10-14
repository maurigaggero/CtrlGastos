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
    

    public class Gastos
    {
        public string Id { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Prioridad { get; set; }
        public string Rubro { get; set; }
        public string Descripcion { get; set; }
        public double Importe { get; set; }
    }

    public class Persistencia_Gastos
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

        Clases.Persistencia_Usuarios user = new Clases.Persistencia_Usuarios();
        #endregion

        #region METODOS

        /// <summary>
        /// Diseña columnas del datatable, 
        /// verifica si el archivo existe previamente
        /// asigna tabla al DataGridView
        /// </summary>

        public void ConfigInicial()  // diseño de la TablaPersona
        {
            //agregue el if para que si este creada no tire error
            if (TablaGastos.Columns.Count != 7)
            {
                TablaGastos.Columns.Add("Id");
                TablaGastos.Columns.Add("Usuario");
                TablaGastos.Columns.Add("Fecha");
                TablaGastos.Columns.Add("Rubro");
                TablaGastos.Columns.Add("Prioridad");
                TablaGastos.Columns.Add("Descripcion");
                TablaGastos.Columns.Add("Importe");
            }
        }

        public void NuevoGasto(string usuario, string rubro, string prioridad, DateTime fecha, string descripcion, double importe)
        {
            int contador = DevuelveId(usuario) + 1;

            g.Id = Convert.ToString(contador);

            g.Usuario = usuario;
            g.Fecha = fecha;
            g.Prioridad = prioridad;
            g.Rubro = rubro;
            g.Descripcion = descripcion;
            g.Importe = importe;

            // agrega el gasto
            {
                TablaGastos.Rows.Add();

                TablaGastos.Rows[TablaGastos.Rows.Count - 1]["Id"] = g.Id;
                TablaGastos.Rows[TablaGastos.Rows.Count - 1]["Usuario"] = g.Usuario;
                TablaGastos.Rows[TablaGastos.Rows.Count - 1]["Fecha"] = g.Fecha;
                TablaGastos.Rows[TablaGastos.Rows.Count - 1]["Rubro"] = g.Rubro;
                TablaGastos.Rows[TablaGastos.Rows.Count - 1]["Prioridad"] = g.Prioridad;
                TablaGastos.Rows[TablaGastos.Rows.Count - 1]["Descripcion"] = g.Descripcion;
                TablaGastos.Rows[TablaGastos.Rows.Count - 1]["Importe"] = g.Importe;

                TablaGastos.WriteXml(NombreArchivo, XmlWriteMode.WriteSchema);

            }
        }

        public double SumaIngresos(string nombre)
        {
            double suma = 0;
            foreach (DataRow fila in TablaGastos.Rows)
            {
                if (fila["Usuario"].ToString() == nombre && (Convert.ToDateTime(fila["Fecha"]).Date.Month) == (DateTime.Today.Month))
                    suma += Convert.ToDouble(fila["Importe"]);
            }
            return suma;
        }

        public int DevuelveId(string nombre)
        {
            for (int i = TablaGastos.Rows.Count - 1; i >= 0; i--)
            {
                DataRow fila = TablaGastos.Rows[i];
                if (fila["Usuario"].ToString() == nombre)
                    return Convert.ToInt32(fila["Id"]);
            }
            return 0;
        }

        public float ContadorPrioritarios(string nombre)
        {
            float cant = TablaGastos.AsEnumerable().Count(x => x.Field<string>("Prioridad") == "A" && x.Field<string>("Usuario") == nombre);
            float usuario = TablaGastos.AsEnumerable().Count(x => x.Field<string>("Usuario") == nombre);
            float total = cant / usuario;
            if (usuario > 0)
            {
                return total * 100;
            }
            else
            {
                return 0;
            }
        }

        public float ContadorNoPrioritarios(string nombre)
        {
            float cant = TablaGastos.AsEnumerable().Count(x =>
            x.Field<string>("Prioridad") == "" && x.Field<string>("Usuario") == nombre);
            float usuario = TablaGastos.AsEnumerable().Count(x => x.Field<string>("Usuario") == nombre);
            float total = cant / usuario;
            if (usuario > 0)
            {
                return total * 100;
            }
            else
            {
                return 0;
            }
        }

        public void EliminaGastosUsuario(string nombre)
        {
            for (int i = TablaGastos.Rows.Count - 1; i >= 0; i--)
            {
                DataRow fila = TablaGastos.Rows[i];
                if (fila["Usuario"].ToString() == nombre)
                {
                    fila.Delete();
                }
                TablaGastos.WriteXml(NombreArchivo, XmlWriteMode.WriteSchema);
            }
        }


        decimal[] rubro = new decimal[14];
        string[] titulo = new string[14];
        public void Porcentaje(string nombre)
        {
            rubro[0] = 0;
            rubro[1] = 0;
            rubro[2] = 0;
            rubro[3] = 0;
            rubro[4] = 0;
            rubro[5] = 0;
            rubro[6] = 0;
            rubro[7] = 0;
            rubro[8] = 0;
            rubro[9] = 0;
            rubro[10] = 0;
            rubro[11] = 0;
            rubro[12] = 0;
            rubro[13] = 0;


            titulo[0] = "Salud";
            titulo[1] = "Servicios";
            titulo[2] = "Impuestos";
            titulo[3] = "Alquiler";
            titulo[4] = "Hipoteca";
            titulo[5] = "Educacion";
            titulo[6] = "Supermercado";
            titulo[7] = "Mantenimiento casa";
            titulo[8] = "Mantenimiento auto";
            titulo[9] = "Transporte";
            titulo[10] = "Viajes";
            titulo[11] = "Salidas/Esparcimiento";
            titulo[12] = "Tarjeta de credito";
            titulo[13] = "Otro";


            for (int i = TablaGastos.Rows.Count - 1; i >= 0; i--)
            {
                DataRow fila = TablaGastos.Rows[i];

                if (nombre == fila["Usuario"].ToString() && (Convert.ToDateTime(fila["Fecha"]).Date.Month) == (DateTime.Today.Month))
                {
                    if (fila["Rubro"].ToString() == "Salud")
                    {
                        rubro[0] += Convert.ToDecimal(Convert.ToString(fila["Importe"]));
                    }

                    if (fila["Rubro"].ToString() == "Servicios")
                    {
                        rubro[1] += Convert.ToDecimal(Convert.ToString(fila["Importe"]));
                    }

                    if (fila["Rubro"].ToString() == "Impuestos")
                    {
                        rubro[2] += Convert.ToDecimal(Convert.ToString(fila["Importe"]));
                    }

                    if (fila["Rubro"].ToString() == "Alquiler")
                    {
                        rubro[3] += Convert.ToDecimal(Convert.ToString(fila["Importe"]));
                    }

                    if (fila["Rubro"].ToString() == "Hipoteca")
                    {
                        rubro[4] += Convert.ToDecimal(Convert.ToString(fila["Importe"]));
                    }

                    if (fila["Rubro"].ToString() == "Educacion")
                    {
                        rubro[5] += Convert.ToDecimal(Convert.ToString(fila["Importe"]));
                    }

                    if (fila["Rubro"].ToString() == "Supermercado")
                    {
                        rubro[6] += Convert.ToDecimal(Convert.ToString(fila["Importe"]));
                    }

                    if (fila["Rubro"].ToString() == "Mantenimiento casa")
                    {
                        rubro[7] += Convert.ToDecimal(Convert.ToString(fila["Importe"]));
                    }

                    if (fila["Rubro"].ToString() == "Mantenimiento auto")
                    {
                        rubro[8] += Convert.ToDecimal(Convert.ToString(fila["Importe"]));
                    }

                    if (fila["Rubro"].ToString() == "Transporte")
                    {
                        rubro[9] += Convert.ToDecimal(Convert.ToString(fila["Importe"]));
                    }

                    if (fila["Rubro"].ToString() == "Viajes")
                    {
                        rubro[10] += Convert.ToDecimal(Convert.ToString(fila["Importe"]));
                    }

                    if (fila["Rubro"].ToString() == "Salidas/Esparcimiento")
                    {
                        rubro[11] += Convert.ToDecimal(Convert.ToString(fila["Importe"]));
                    }

                    if (fila["Rubro"].ToString() == "Tarjeta de crédito")
                    {
                        rubro[12] += Convert.ToDecimal(Convert.ToString(fila["Importe"]));
                    }

                    if (fila["Rubro"].ToString() == "Otro")
                    {
                        rubro[13] += Convert.ToDecimal(Convert.ToString(fila["Importe"]));
                    }
                }
            }
        }

        public string CalculaPorcentajes(decimal ingresos)
        {
            string impr = "";
            decimal memoria = 0;
            for (int i = 0; i < rubro.Length; i++)
            {
                {
                    memoria = rubro[i] / ingresos * 100;

                    if (rubro[i] > 0)
                    {
                        impr += titulo[i] + " = " + Convert.ToString(Convert.ToString(Math.Round(memoria))) + "%" + "\r\n";
                    }
                }
            }
            return impr;
        }

        /// <summary>
        /// Rellena las columnas del último registro agregado con los valores del textbox correspondiente
        /// </summary>
        /// 

        public void LeeGastos()
        {
            TablaGastos.Reset();

            // busca si el archivo ya existe para precargar sus datos
            if (System.IO.File.Exists(NombreArchivo))
            {
                TablaGastos.ReadXml(NombreArchivo);
            }
        }
        #endregion
    }
}