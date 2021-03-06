﻿using Registro_de_Peluqueros_y_Servicios.UI.Consultas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registro_de_Peluqueros_y_Servicios.UI.Reportes
{
    public partial class Reporte_Peluqueros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportViewer1.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
            ReportViewer1.Reset();
            ReportViewer1.LocalReport.ReportPath = Server.MapPath(@"Peluquero.rdlc");
            ReportViewer1.LocalReport.DataSources.Clear();

            ReportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSetPeluquero",
               Consulta_Peluqueros1.lista));

            ReportViewer1.LocalReport.Refresh();
        }
    }
}