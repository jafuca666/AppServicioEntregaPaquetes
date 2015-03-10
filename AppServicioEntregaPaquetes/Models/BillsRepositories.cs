using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace AppServicioEntregaPaquetes.Models
{
    public class BillsRepositories
    {
        Bills[] bill;


        public Bills[] Bill
        {
            get { return bill; }
            set { bill = value; }
        }


    }
}
