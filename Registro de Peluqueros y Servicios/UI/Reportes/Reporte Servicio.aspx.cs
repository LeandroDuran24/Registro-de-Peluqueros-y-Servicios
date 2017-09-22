using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tarea_4.UI.Consultas;

namespace Tarea_4.UI.Reportes
{
    public partial class Reporte_Servicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportViewer1.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
            ReportViewer1.Reset();
            ReportViewer1.LocalReport.ReportPath = Server.MapPath(@"Servicio.rdlc");
            ReportViewer1.LocalReport.DataSources.Clear();

            ReportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSetServicio",
                Consulta_Peluqueros.lista));

            ReportViewer1.LocalReport.Refresh();
        }
    }
}