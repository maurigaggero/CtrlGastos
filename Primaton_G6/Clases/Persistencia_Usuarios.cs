﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Primaton_G6.Clases
{
    public class Usuario
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public int Ingresos { get; set; }
        public int Img { get; set; }
    }

    public class Persistencia_Usuarios
    {
        #region PROPIEDADES PRIVADAS
        /// <summary>
        /// Path y nombre del archivo
        /// </summary>
        private const string NombreArchivo = @"usuarios.xml";

        Usuario u = new Usuario();

        /// <summary>
        /// Tabla en memoria con la lista de personas
        /// </summary>
        public DataTable TablaUsuarios = new DataTable("TablaUsuarios");

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
            TablaUsuarios.Columns.Add("Password");
            TablaUsuarios.Columns.Add("Ingresos");
            TablaUsuarios.Columns.Add("Img");
        }

        /// <summary>
        /// Rellena las columnas del último registro agregado con los valores del textbox correspondiente
        /// </summary>
        /// 
        public void LeeUsuarios()
        {
            //limpia la tabla para no repetir filas
            TablaUsuarios.Reset();

            // busca si el archivo ya existe para precargar sus datos
            if (File.Exists(NombreArchivo))
            {
                TablaUsuarios.ReadXml(NombreArchivo);
            }
        }

        public void AltaUsuarios(string dni, string nombre, string pass, int ingresos, int img)
        {
            {
                u.Id = dni;
                u.Nombre = nombre;
                u.Password = pass;
                u.Ingresos = ingresos;
                u.Img = img;
                
                int contador = 0;

                //recorre la tabla, si existe un usuario igual suma el contador
                for (int i = TablaUsuarios.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow fila = TablaUsuarios.Rows[i];
                    if (fila["Nombre"].ToString() == nombre)
                    {
                        MessageBox.Show("Ya existe un usuario con el mismo nombre. Elija otro", "Hubo un problema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        contador++;
                    }
                }
                for (int i = TablaUsuarios.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow fila = TablaUsuarios.Rows[i];
                    if (fila["Id"].ToString() == dni)
                    {
                        MessageBox.Show("Ya existe un usuario con este DNI.", "Hubo un problema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        contador++;
                    }
                }
                //sino agrega el usuario
                if (contador == 0)
                {
                    TablaUsuarios.Rows.Add();

                    TablaUsuarios.Rows[TablaUsuarios.Rows.Count - 1]["Id"] = u.Id;
                    TablaUsuarios.Rows[TablaUsuarios.Rows.Count - 1]["Nombre"] = u.Nombre;
                    TablaUsuarios.Rows[TablaUsuarios.Rows.Count - 1]["Password"] = u.Password;
                    TablaUsuarios.Rows[TablaUsuarios.Rows.Count - 1]["Ingresos"] = u.Ingresos;
                    TablaUsuarios.Rows[TablaUsuarios.Rows.Count - 1]["Img"] = u.Img;

                    TablaUsuarios.WriteXml(NombreArchivo, XmlWriteMode.WriteSchema);

                    MessageBox.Show("Usuario creado con éxito!");
                }
            }
        }

        public void EliminaUsuario(string nombre)
        {
            if (nombre != "")
            {
                // recorre la tabla, si el argumento es igual a un valor en la columna nombre lo borra
                for (int i = TablaUsuarios.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow fila = TablaUsuarios.Rows[i];
                    if (fila["Nombre"].ToString() == nombre)
                    {
                        fila.Delete();
                    }
                    TablaUsuarios.WriteXml(NombreArchivo, XmlWriteMode.WriteSchema);
                }
            }
        }


        public string DevuelveNombre(string nombre)
        {
            // recorre la tabla, 
            for (int i = TablaUsuarios.Rows.Count - 1; i >= 0; i--)
            {
                DataRow fila = TablaUsuarios.Rows[i];
                if (fila["Nombre"].ToString() == nombre)
                {
                    return fila["Nombre"].ToString();
                }
            }
            return "0";
        }

        public string DevuelvePass(string nombre)
        {
            // recorre la tabla, 
            for (int i = TablaUsuarios.Rows.Count - 1; i >= 0; i--)
            {
                DataRow fila = TablaUsuarios.Rows[i];
                if (fila["Nombre"].ToString() == nombre)
                {
                    return fila["Password"].ToString();
                }
            }
            return "0";
        }

        public string DevuelveIngresos(string nombre)
        {
            for (int i = TablaUsuarios.Rows.Count - 1; i >= 0; i--)
            {
                DataRow fila = TablaUsuarios.Rows[i];
                if (fila["Nombre"].ToString() == nombre)
                {
                    return fila["Ingresos"].ToString();
                }
            }
            return nombre;
        }

        public string DevuelveFoto(string nombre)
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

        public void ModificaIngreso(string name)
        {
            /////
        }
        #endregion
    }
}