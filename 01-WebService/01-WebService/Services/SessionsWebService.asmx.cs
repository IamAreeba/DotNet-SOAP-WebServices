using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _01_WebService.Services
{
    /// <summary>
    /// Summary description for SessionsWebService
    /// </summary>
    [WebService(Namespace = "http://DotNet-areeba.com/sessionswebservice")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SessionsWebService : System.Web.Services.WebService
    {

        [WebMethod(EnableSession = true)]
        public string PrintName(string name)
        {
            List<string> ltnames;

            if (Session["name"] == null)
            {
                ltnames = new List<string>();
            }
            else
            {
                ltnames = (List<string>)Session["name"];
            }

            ltnames.Add(name);
            Session["name"] = ltnames;

            return string.Format("Hello:  {0}", name);
        }

        [WebMethod(EnableSession = true)]
        public List<string> GetNames()
        {
            try
            {
                if (Session["name"] != null && Session["name"] != "")
                {
                    return (List<string>)Session["name"];
                }
                else
                {
                    return new List<string> { "No records to display" };
                }
            }
            catch (Exception ex)
            {
                // Return the error message to client
                return new List<string> { "Error: " + ex.Message };
            }
        }

        [WebMethod(EnableSession = true)]
        public string GetCount()
        {
            int? count = (int?)Session["Count"];
            if (Session["Count"] == null)
            {
                count = 0;
            }
            else
            {
                count++;
            }
            Session["Count"] = count;
            return count.ToString();
        }
    }
}
