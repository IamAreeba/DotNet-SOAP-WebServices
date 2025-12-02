using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _01_WebService
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://DotNet-areeba.com/webservice")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public string PrintName(string firstName, string lastName)
        {
            return string.Format(" Hello {0} {1} ", firstName, lastName);
        }

        [WebMethod(Description = "Calculator Application and param int firstValue, int secondValue, string operation(eg: +,-,*,/)")]
        public string Calculator(int firstValue, int secondValue, string operation)
        {
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = (double)firstValue + (double)secondValue;
                    break; 
                case "-":
                    result = (double)firstValue - (double)secondValue;
                    break;
                case "*":
                    result = (double)firstValue * (double)secondValue;
                    break;
                case "/":
                    result = (double)firstValue / (double)secondValue;
                    break;
            }
            return result.ToString();
        }

        [WebMethod]
        public WebServiceResponse Division(int a, int b)
        {
            /* 
                int result = a / b;
                return result;
            */


            WebServiceResponse response = new WebServiceResponse();

            try
            {
                response.Result = Convert.ToString(a / b);
                response.ErrorMessage = string.Empty;
            }
            catch (Exception ex)
            {
                response.Result = string.Empty;
                response.ErrorMessage = ex.Message; 
            }

            return response;
        }


    }
}
