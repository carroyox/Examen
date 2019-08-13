using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UI.GymAPI;

namespace UI
{
    public partial class Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
        protected void Reset_Click(object sender, EventArgs e)
        {
            TbNombre.Text = string.Empty;
            TbEdad.Text = string.Empty;
            TbGen.Text = string.Empty;
            TbDate.Controls.Clear();
            TbTalla.Text = string.Empty;
            TbTriceps.Text = string.Empty;
            TbBiceps.Text = string.Empty;
            TbPecho.Text = string.Empty;
            TbAxila.Text = string.Empty;
            TbSubescapular.Text = string.Empty;
            TbSuprailiaco.Text = string.Empty;
            TbAbdomen.Text = string.Empty;
            TbMuslo.Text = string.Empty;
            TbPantorrilla.Text = string.Empty;
        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            float Peso = (float)Convert.ToDouble(TbPeso.Text);
            float Talla = (float)Convert.ToDouble(TbTalla.Text);
            float Triceps = (float)Convert.ToDouble(TbTriceps.Text);
            float Biceps = (float)Convert.ToDouble(TbBiceps.Text);
            float Pecho = (float)Convert.ToDouble(TbPecho.Text);
            float Axila = (float)Convert.ToDouble(TbAxila.Text);
            float Subescapular = (float)Convert.ToDouble(TbSubescapular.Text);
            float Suprailiaco = (float)Convert.ToDouble(TbSuprailiaco.Text);
            float Abdomen = (float)Convert.ToDouble(TbAbdomen.Text);
            float Muslo = (float)Convert.ToDouble(TbMuslo.Text);
            float Pantorrilla = (float)Convert.ToDouble(TbPantorrilla.Text);
            ArrayOfFloat medidas = new ArrayOfFloat { Peso, Talla, Triceps, Biceps, Pecho, Axila, Subescapular, Suprailiaco, Abdomen, Muslo, Pantorrilla };          
             GymAPI.WebServiceSoapClient API = new GymAPI.WebServiceSoapClient();
            API.Save(TbNombre.Text, medidas, Convert.ToInt16(TbEdad.Text), TbGen.Text[0], Convert.ToDateTime(TbDate.Text));
            Response.Redirect("Data.aspx");
        }
    }
}