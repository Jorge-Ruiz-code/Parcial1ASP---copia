using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial1ASP
{
    public class Reporte
    {
        string nombre;
        int cantidad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}