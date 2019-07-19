using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TempCovService        // A service for temperature conversion of Celcius to Fahrenheit, and vice versa
{
    
    public class Service1 : IService1
    {
        public int C2f(int c)           // Function to convert Celsius temperature to Fahrenheit temperature
        {
            return ((c*9)/5)+32;        // Conversion formula of Celcius to Fahrenheit
        }
        public int F2c(int f)           // Function to convert Fahrenheit temperature to Celsius temperature
        {
            return ((f-32)*5/9);        // Conversion formula of Fahrenheit to Celcius
        }
}
}
