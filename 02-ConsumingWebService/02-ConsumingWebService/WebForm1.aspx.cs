using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02_ConsumingWebService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_click(object sender, EventArgs e)
        {
            ServiceReference.CalculatorWebServiceSoapClient client = new ServiceReference.CalculatorWebServiceSoapClient();
            string result = client.Calculator(
                        Convert.ToInt32(txtFirstValue.Text),
                        Convert.ToInt32(txtSecondValue.Text),
                        txtOperation.Text
                    );
            if (result != "")
            {
                lblResult.Text = "Result: <b style = 'color:Green'>" + result.ToString() + "<b/>";
            }
        }

        protected void btnDivision_click(object sender, EventArgs e)
        {
            ServiceReference.CalculatorWebServiceSoapClient client = new ServiceReference.CalculatorWebServiceSoapClient();
            int result = client.Division(Convert.ToInt32(txtFirstValue.Text), Convert.ToInt32(txtSecondValue.Text));

            if (result != 0)
            {
                lblResult.Text = "Result: <b style = 'color:Green'>" + result.ToString() + "<b/>";
            }
        }

    }


}
