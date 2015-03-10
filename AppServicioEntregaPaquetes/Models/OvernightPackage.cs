using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace AppServicioEntregaPaquetes.Models
{
    public class OvernightPackage : Package
    {

        public override float calculateCost()
        {
            throw new NotImplementedException();
        }

    }
}
