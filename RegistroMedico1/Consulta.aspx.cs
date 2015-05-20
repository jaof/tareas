using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistroMedic
{
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VistaGridView.DataSource = BLL.Pacientes.Lista("*", "Pacientes");
            VistaGridView.DataBind();

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            
                if (TipoDropDownList.Text == "Fecha Ingreso")
                {

                    VistaGridView.DataSource = BLL.Pacientes.ListarF(TextBoxDesde.Text, TextBoxHasta.Text,"FechaIng");
                    VistaGridView.DataBind();
                } else 
                    if (TipoDropDownList.Text == "Fecha Nacimiento") {
                        VistaGridView.DataSource = BLL.Pacientes.ListarF(TextBoxDesde.Text, TextBoxHasta.Text,"FechaNac");
                        VistaGridView.DataBind();
                
                }
                else
                {

                    VistaGridView.DataSource = BLL.Pacientes.Lista("*", "Pacientes Where Nombre like'" + TextBoxFiltro.Text + "%'");
                    VistaGridView.DataBind();
                }
            
           
        }
        public string Tipo()
        {
            string tipo = "";
            if (TipoDropDownList.SelectedIndex == 0)
            {

                tipo = "Nombre";

            }
            else
                if (TipoDropDownList.SelectedIndex == 1)
                {
                    tipo = "Apellido";

                }
                else
                    if (TipoDropDownList.SelectedIndex == 2)
                    {
                        tipo = "Cedula";
                    }
                    else
                        if (TipoDropDownList.SelectedIndex == 3)
                        {
                            tipo = "FechaNac";
                        }
                        else
                            if (TipoDropDownList.SelectedIndex == 4)
                            {
                                tipo = "FechaIng";
                            }
            return tipo;
        }

    }
}