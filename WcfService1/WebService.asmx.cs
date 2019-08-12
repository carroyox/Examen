using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WcfService1;
using BL;
using DAL;

namespace WcfService1
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<string[]> dataGrid_Data()
        {
            Reference BL = new Reference();

            return BL.datos();
        }

        [WebMethod]
        public void Save(string nombre, float[] medidas, int edad, char genero, DateTime fecha) {
            Reference BL = new Reference();
            BL.Save(nombre, medidas, edad, genero, fecha);

        }
    }
}
