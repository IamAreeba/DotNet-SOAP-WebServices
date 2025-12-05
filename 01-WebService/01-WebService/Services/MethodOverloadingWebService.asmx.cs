using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _01_WebService.Services
{
    /// <summary>
    /// Summary description for MethodOverloadingWebService
    /// </summary>
    [WebService(Namespace = "http://DotNet-areeba.com/methodoverloadingwebservice")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)] 
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService] 
    public class MethodOverloadingWebService : System.Web.Services.WebService
    {

        [WebMethod(MessageName = "GetFullNameTwoParams")]
        public string GetFullName(string firstName, string lastName)
        {
            return "Hello " + firstName + " " + lastName + " " ;
        }


        [WebMethod(MessageName = "GetFullNameThreeParams")]
        public string GetFullName(string firstName, string middleName, string lastName)
        {
            return "Hello  " + firstName + " " + middleName + " " + lastName;
        }

    }
}
