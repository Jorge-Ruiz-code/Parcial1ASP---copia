using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial1ASP
{
    public class Medicion
    {
        string codigo;
        int cantidad;
        DateTime fecha;

        public string Codigo { get => codigo; set => codigo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}