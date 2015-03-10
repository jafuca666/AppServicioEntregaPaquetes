using AppServicioEntregaPaquetes.Models;
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
        int n = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(View1);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Customers client = new Customers(TextBox6.Text, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text);
            MultiView1.SetActiveView(View2);
            Label8.Text = client.Nombres + " " +  client.Apellidos;


        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TextBox7.Visible = true;
            if (RadioButton1.Checked)
            {
                Label9.Text = "Cargo adicional : ";
                n = 1;
                RadioButton2.Checked = false;
            }
            else
            {
                Label9.Text = "Cuota fija : ";
                n = 2;
                RadioButton1.Checked = false;
            }
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            TextBox7.Visible = true;
            if (RadioButton2.Checked)
            {
                Label9.Text = "Cuota fija : ";
                n = 2;
                RadioButton1.Checked = false;
            }
            else
            {
                Label9.Text = "Cargo adicional : ";
                n = 1;
                RadioButton2.Checked = false;
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (n == 1)
            {

            }
            else
            {

            }
        }

        protected void TextBox7_TextChanged(object sender, EventArgs e)
        {
            Button2.Enabled = true;
        }
    }
}