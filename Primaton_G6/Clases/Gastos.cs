﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primaton_G6.Clases
{
    class Gastos
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Ingresos { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int Prioridad { get; set; }
        public double Importe { get; set; }

    }
}