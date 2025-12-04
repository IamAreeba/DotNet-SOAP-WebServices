using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03_ClientSessionWebService
{
    public partial class ClientSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetNames_Click(object sender, EventArgs e)
        {
            SessionsWebServiceRef.SessionsWebServiceSoapClient client = new SessionsWebServiceRef.SessionsWebServiceSoapClient();
            client.PrintName(txtName.Text.Trim());
            Console.WriteLine(txtName.Text);

            gvGetNames.DataSource = client.GetNames();
            gvGetNames.DataBind();

        }

        protected void btnGetCount_Click(object sender, EventArgs e)
        {
            SessionsWebServiceRef.SessionsWebServiceSoapClient client = new SessionsWebServiceRef.SessionsWebServiceSoapClient();
            string count = client.GetCount();

            lblGetCount.Text = count.ToString();

        }

    }
}