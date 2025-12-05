using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _01_WebService.Services
{
    /// <summary>
    /// Summary description for TimeOutWebService
    /// </summary>
    [WebService(Namespace = "http://DotNet-areeba.com/timeoutwebservice")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TimeOutWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string GreetUser()
        {
            System.Threading.Thread.Sleep(30000);  // 30 sec
            return "Hello User";
        }
    }
}
