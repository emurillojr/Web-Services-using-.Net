using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccessingWebService
{
    public partial class AccessWebService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //create an object of Web Reference
            Phone.CDyne.PhoneVerify myPhone = new Phone.CDyne.PhoneVerify();
            Phone.CDyne.PhoneReturn myReturn = new Phone.CDyne.PhoneReturn();

            myReturn = myPhone.CheckPhoneNumber(TextBox1.Text, "0");
            Label3.Text = myReturn.TelecomCity + ", " + myReturn.TelecomState + " " + myReturn.TelecomZip;
        }
    }
}