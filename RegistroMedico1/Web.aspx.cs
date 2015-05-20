using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace RegistroMedic
{
    public partial class Web : System.Web.UI.Page
    {
        BLL.Pacientes pac = new BLL.Pacientes();
        protected void Page_Load(object sender, EventArgs e)

        {
            if (!IsPostBack)
            {
                
                int IdPaciente = 0;
                int.TryParse(Request.QueryString["IdPaciente"], out IdPaciente);

                if (pac.Buscar(IdPaciente))
                {
                    TextBoxNombre.Text = pac.Nombre;
                    TextBoxApellido.Text = pac.Apellido;
                    TextBoxDireccion.Text = pac.Direccion;
                    TextBoxTelefono.Text = pac.Telefono;
                    TextBoxCelular.Text = pac.Celular;
                    TextBoxCedula.Text = pac.Cedula;
                    TextBoxFechaNac.Text = pac.FechaNac.ToString();
                    TextBoxFechaIng.Text = pac.FechaIng.ToString();
                    DropDownListSexo.SelectedIndex = pac.Sexo;
                    TextBoxOcupacion.Text = pac.Ocupacion;


                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            
            pac.Nombre= TextBoxNombre.Text;
            pac.Apellido = TextBoxApellido.Text;
            pac.Direccion = TextBoxDireccion.Text;
            pac.Telefono = TextBoxTelefono.Text;
            pac.Celular = TextBoxCelular.Text;
            pac.Cedula = TextBoxCedula.Text;
            pac.FechaNac = Convert.ToDateTime(TextBoxFechaNac.Text);
            pac.FechaIng = Convert.ToDateTime(TextBoxFechaIng.Text);
            pac.Sexo = Convert.ToInt32(DropDownListSexo.SelectedValue.ToString());
            pac.Ocupacion = TextBoxOcupacion.Text;
         

            if (TextBoxIdPaciente.Text == string.Empty)
            {

                if (pac.Insertar())
                {
                    Response.Write("Guardo Exitosamente");

                }
                else
                {
                    Response.Write("No se Pudo Guardar");
                }
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            TextBoxNombre.Text = "";
            TextBoxApellido.Text = "";
            TextBoxDireccion.Text = "";
            TextBoxTelefono.Text = "";
            TextBoxCelular.Text = "";
            TextBoxCedula.Text = "";
            TextBoxOcupacion.Text = "";
        }

    }
}