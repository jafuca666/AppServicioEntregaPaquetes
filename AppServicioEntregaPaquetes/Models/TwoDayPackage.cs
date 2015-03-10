using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace AppServicioEntregaPaquetes.Models
{
    public class TwoDayPackage : Package
    {

        float cuota;

        public float Cuota
        {
            get { return cuota; }
            set { cuota = value; }
        }


        public override float calculateCost(/*float peso, float costoGramo*/)
        {


            throw new NotImplementedException();
        }



    }
}
