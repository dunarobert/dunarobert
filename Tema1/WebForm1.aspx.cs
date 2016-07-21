using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tema1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                List<string> list = new List<string>() { "Bucuresti", "Paris", "Londra", "Berlin" };
                DropDownList1.DataSource = list;
                DropDownList1.DataBind();
            }
         }
    }
}