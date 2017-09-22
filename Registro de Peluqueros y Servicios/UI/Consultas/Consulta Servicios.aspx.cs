using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tarea_4.Entidades;

namespace Tarea_4.UI.Consultas
{
    public partial class Consulta_Servicios : System.Web.UI.Page
    {
        List<Servicios> lista { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Servicios servicio = new Servicios();
            /*GridView1.DataSource = BLL.ServicioBll.GetListTodo();
            GridView1.DataBind();*/
            lista = new List<Servicios>();
        }

        public void Seleccionar()
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                int id = Convert.ToInt32(TextBox1.Text);
                lista = BLL.ServicioBll.GetList(p => p.idServicio == id);
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
                    lista = BLL.ServicioBll.GetList(p => p.nombre == TextBox1.Text);
                    GridView1.DataSource = lista;
                    GridView1.DataBind();
                }


            }
            else if (DropDownList1.SelectedIndex == 2)
            {

                lista = BLL.ServicioBll.GetListTodo();
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