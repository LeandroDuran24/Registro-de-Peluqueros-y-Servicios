using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tarea_4.Entidades;

namespace Tarea_4.UI.Registros
{
    public partial class Registro_Servicios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        Servicios Servicios = new Servicios();

        public void limpiar()
        {
            idTextbox.Text = "";
            NombreTextbox.Text = "";
            CostoTextBox1.Text = "";
        }

        public Servicios LLenar ()
        {
            Servicios.idServicio = Convert.ToInt32(idTextbox.Text);
            Servicios.nombre = NombreTextbox.Text;
            Servicios.costo = Convert.ToInt32(CostoTextBox1.Text);
            return Servicios;

        }

        protected void Nuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        protected void guardar_Click(object sender, EventArgs e)
        {
            
        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextbox.Text);
            Servicios = BLL.ServicioBll.Buscar(p => p.idServicio == id);

            if(Servicios!=null)
            {
                NombreTextbox.Text = Servicios.nombre;
                CostoTextBox1.Text = Convert.ToString(Servicios.costo);

            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No existe !');");
            }

        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextbox.Text);
            Servicios = BLL.ServicioBll.Buscar(p => p.idServicio == id);
            if (Servicios != null)
            {
                BLL.ServicioBll.Eliminar(Servicios);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No existe !');");
            }
        }

        protected void Guardar_Click1(object sender, EventArgs e)
        {
            Servicios = LLenar();
            if (Servicios.idServicio != 0)
            {
                BLL.ServicioBll.Modificar(Servicios);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Modificado !');</script>");

            }
            else
            {
                BLL.ServicioBll.Guardar(Servicios);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Guardado !');</script>");
                limpiar();
                NombreTextbox.Focus();
            }
        }
    }
}