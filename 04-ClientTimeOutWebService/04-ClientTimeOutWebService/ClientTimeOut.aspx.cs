using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_ClientTimeOutWebService
{
    public partial class ClientTimeOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTimeOut_Click(object sender, EventArgs e)
        {
            try
            {
                TimeOutWebServiceRef.TimeOutWebServiceSoapClient client = new TimeOutWebServiceRef.TimeOutWebServiceSoapClient();
                lblResponse.Text = client.GreetUser();
            }
            catch (System.TimeoutException)
            {
                lblResponse.Text = "Response TimeOut Occured";
            }
            
        }
    }
}