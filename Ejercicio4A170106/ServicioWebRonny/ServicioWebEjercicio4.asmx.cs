using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServicioWebRonny
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public decimal AreaCuadrado(decimal n1)
        {
            Calcular c = new Calcular();
            c.numero1 = n1;
            return c.AreaCuadrado();
        }

        [WebMethod]
        public decimal AreaTriangulo(decimal n1, decimal n2)
        {
            Calcular c = new Calcular();
            c.numero1 = n1;
            c.numero2 = n2;
            return c.AreaTriangulo();
        }

        [WebMethod]
        public decimal AreaCirculo(decimal n1)
        {
            Calcular c = new Calcular();
            c.numero1 = n1;
            return c.AreaCirculo();
        }

    }
}
