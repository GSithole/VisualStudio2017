using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContactClassLibrary;
using WcfWebClient.CrudService;

namespace WcfWebClient
{
    public partial class AddContact : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact()
            {
                firstName = TxtFrstname.Text.ToString(),
                lastName = txtLastname.Text.ToString(),
                gender = DpGender.SelectedValue.ToString(),
                emailAddress = txtEmail.Text.ToString(),
                phoneNumber = txtPnumber.Text.ToString(),
                city=txtCity.Text.ToString()
            };
            client.createContact(contact);
            Response.Redirect("Default.aspx");

        }
    }
}