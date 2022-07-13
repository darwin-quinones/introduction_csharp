using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace form
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var d = Request.Params["data"];
           
        }

       [WebMethod]
       public static string Add(User objectUser)
        {
            string respuesta = "";
            User user = objectUser;
            string name = user.name;
            string id = user.id;
            return respuesta;

        }
    }
}