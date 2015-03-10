using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace AppServicioEntregaPaquetes.Models
{
    public class Customers
    {

        String identificacion, nombres, apellidos, direccion, email, telefonos;



           public Customers()
        {
            identificacion ="";
            nombres="";
            direccion = "";
            email = "";
            telefonos = "";
            apellidos = "";
            
                    }

           public Customers(string identificacion,string nombres,string apellidos, string direccion,   string email, string telefonos)
        {

            this.identificacion = identificacion;
            this.nombres = nombres;
            this.direccion = direccion;
            this.email = email;
            this.telefonos = telefonos;
            this.apellidos = apellidos;
        }

        public String Identificacion
{
  get { return identificacion; }
  set { identificacion = value; }
}


        public String Telefonos
        {
            get { return telefonos; }
            set { telefonos = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public String Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public Bills Bills
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
