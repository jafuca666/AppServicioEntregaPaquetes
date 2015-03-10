using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace AppServicioEntregaPaquetes.Models
{
    public class Bills
    {
        String id;
        DateTime fecha;
  Customers client;
 Package[] items;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
      
        public Customers Client
        {
            get { return client; }
            set { client = value; }
        }
       
        public Package[] Items
        {
            get { return items; }
            set { items = value; }
        }
        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public BillsRepositories BillsRepositories
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
  


    }
}
