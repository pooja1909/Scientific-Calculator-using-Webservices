using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication3
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public double Sine(double c)
        {
            return (Math.Sin(c));
        }

        [WebMethod]
        public double Cos(double c)
        {
            return (Math.Cos(c));
        }
        [WebMethod]
        public double Tan(double c)
        {
            return (Math.Tan(c));
        }
        [WebMethod]
        public double Asine(double c)
        {
            return (Math.Asin(c) );
        }
        [WebMethod]
        public double Acos(double c)
        {
            return (Math.Acos(c));
        }

        [WebMethod]
        public double Atan(double c)
        {
            return (Math.Atan(c));
        }

        [WebMethod]
        public double Sqr(double c)
        {
            return (c*c);
        }
        [WebMethod]
        public double Sqrt(double c)
        {
            return (Math.Sqrt(c));
        }
        [WebMethod]
        public double Cube(double c)
        {
            return (c*c*c);
        }

        [WebMethod]
        public double Log(double c)
        {
            return (Math.Log10(c));
        }

        [WebMethod]
        public double Ln(double c)
        {
            return (Math.Log(c));
        }

        [WebMethod]
        public int Fact(int c)
        {
            if (c <= 1)
                return 1;
            return c * Fact(c - 1);
        }

        [WebMethod]
        public double reci(double c)
        {
            return (1/c);
        }

        [WebMethod]
        public int add(int a, int b)
        {
            return (a + b);
        }

        [WebMethod]
        public int mul(int c, int d)
        {
            return (c * d);
        }

        [WebMethod]
        public int div(int c, int d)
        {
            return (c / d); 
        }

        [WebMethod]
        public int sub(int c, int d)
        {
            return (c - d);
        }

        [WebMethod]
        public int mod(int c, int d)
        {
            return (c % d); 
        }

       
        [WebMethod]
        public int xn(int c, int d)
        {
            int x = c;
            for (int i = 1; i < d; i++)
            {
                x = x * c;
            }
            return (x);
        }



    }
}


