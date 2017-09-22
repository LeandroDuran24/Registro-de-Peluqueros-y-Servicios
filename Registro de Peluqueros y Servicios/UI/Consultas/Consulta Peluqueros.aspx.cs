using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tarea_4.Entidades;

namespace Tarea_4.UI.Consultas
{
    public partial class Consulta_Peluqueros : System.Web.UI.Page
    {
        public static List<Peluqueros> lista { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Peluqueros peluquero = new Peluqueros();
           /* GridView1.DataSource = BLL.PeluqueroBll.GetListTodo();
            GridView1.DataBind();*/
            lista = new List<Peluqueros>();
        }

        public void Seleccionar()
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                int id = Convert.ToInt32(TextBox1.Text);
                lista = BLL.PeluqueroBll.GetList(p => p.idPeluquero == id);
                GridView1.DataSource = lista;
                GridView1.DataBind();
            }
            else if (DropDownList1.SelectedIndex == 1)
            {
                if (TextBox1.Text == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar el Nombre');</script>");
                }
                else
                {
                    lista = BLL.PeluqueroBll.GetList(p => p.nombre == TextBox1.Text);
                    GridView1.DataSource = lista;
                    GridView1.DataBind();
                }


            }
            else if (DropDownList1.SelectedIndex == 2)
            {
                DateTime desde = Convert.ToDateTime(desdeFecha.Text);
                DateTime hasta = Convert.ToDateTime(desdeFecha.Text);

                if (desdeFecha.Text != "" && hastaFecha.Text != "")
                {
                    if (desde <= hasta)
                    {
                        lista = BLL.PeluqueroBll.GetList(p => p.fecha >= desde && p.fecha <= hasta);
                        GridView1.DataSource = lista;
                        GridView1.DataBind();
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('La Primera Fecha debe ser Menor a la Segunda Fecha');</script>");
                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar el Intervalo de Fecha');</script>");
                }



            }
            else if (DropDownList1.SelectedIndex == 3)
            {

                lista = BLL.PeluqueroBll.GetListTodo();
                GridView1.DataSource = lista;
                GridView1.DataBind();

            }
            GridView1.DataSource = lista;
            GridView1.DataBind();
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }
    }
}