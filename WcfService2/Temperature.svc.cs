using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Temperature : ITemperature
    {
        public double Tem(Temp T, double val)
        {
            double res = 0;
            switch (T)
            {
                case Temp.centigrade:
                    res = val * 1.8 + 32;
                    break;
                case Temp.fahrenheit:
                    res = (val - 32) / 1.8;
                    break;
                default:
                    break;
            }
            return res;
        }
    }
}