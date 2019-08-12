using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class Data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                // GymAPI.WebServiceSoapClient API = new GymAPI.WebServiceSoapClient();


                WcfService1.WebService API = new WcfService1.WebService();

                List<String[]> datos = API.dataGrid_Data();


                DGPersonas.DataSource = datos.Select(arr => new
                {
                    Fecha_Medicion = arr[14],
                    Nombre = arr[0],
                    Genero = arr[1],
                    Edad = arr[2],
                    Peso = arr[3],
                    Talla = arr[4],
                    Triceps = arr[5],
                    Biceps = arr[6],
                    Pecho = arr[7],
                    Axila = arr[8],
                    Subescapular = arr[9],
                    Suprailíaco = arr[10],
                    Abdomen = arr[11],
                    Muslo = arr[12],
                    Pantorrilla = arr[13],
                    YUHASZ = arr[15],
                    JacksonPollock = arr[16]

                }).ToArray();
                DGPersonas.DataBind();
            }
        }
    }
}