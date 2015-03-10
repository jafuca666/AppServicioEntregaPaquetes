using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppServicioEntregaPaquetes
{
    public partial class Vista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            MultiView1.SetActiveView(View2);
            Label8.Text = TextBox1.Text;


        }
    }
}