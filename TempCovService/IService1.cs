using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TempCovService    // A service for temperature conversion of Celcius to Fahrenheit, and vice versa
{
    
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int C2f(int c); // convert Celsius temperature to Fahrenheit temperature
        [OperationContract]
        int F2c(int f); // convert Fahrenheit temperature to Celsius temperature
    }


}
