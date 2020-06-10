using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial1ASP
{
    public partial class _Default : Page
    {
        List<Departamento> departamentos = new List<Departamento>();
        List<Medicion> mediciones = new List<Medicion>();
        List<Reporte> reportes = new List<Reporte>();

        protected void Page_Load(object sender, EventArgs e)
        {
            var archivo = Server.MapPath("~/Mediciones.txt");
            FileStream stream = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Medicion medida = new Medicion();

                medida.Codigo = reader.ReadLine();
                medida.Cantidad = Convert.ToInt32(reader.ReadLine());
                medida.Fecha = Convert.ToDateTime(reader.ReadLine());

                mediciones.Add(medida);
            }
            reader.Close();

            archivo = Server.MapPath("~/Departamentos.txt");

            stream = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            reader = new StreamReader(stream);

            while(reader.Peek() > -1)
            {
                Departamento deptemp = new Departamento();

                deptemp.Codigo = reader.ReadLine();
                deptemp.Nombre = reader.ReadLine();

                departamentos.Add(deptemp);
            }
            reader.Close();

            if (!IsPostBack)
            {
                ddlDepartamento.DataValueField = "Codigo";
                ddlDepartamento.DataTextField = "Nombre";
                ddlDepartamento.DataSource = departamentos;
                ddlDepartamento.DataBind();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            var archivo = Server.MapPath("~/Mediciones.txt");
            FileStream stream = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(ddlDepartamento.SelectedValue);
            writer.WriteLine(txtCantidad.Text);
            writer.WriteLine(DateTime.Now.Date);

            writer.Close();
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            foreach(var m in mediciones)
            {
                Departamento depto = departamentos.Find(d => d.Codigo == m.Codigo);

                Reporte repo = new Reporte();
                repo.Cantidad = m.Cantidad;
                repo.Nombre = depto.Nombre;

                reportes.Add(repo);
            }
            grvReporte.DataSource = null;
            grvReporte.DataSource = reportes;
            grvReporte.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            double promedio = mediciones.Average(m => m.Cantidad);

            lblPromedio.Text = promedio.ToString();
            lblPromedio.Visible = true;
        }
    }
}