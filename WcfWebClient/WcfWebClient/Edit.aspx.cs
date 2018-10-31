using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WcfWebClient.CrudService;
using ContactClassLibrary;

namespace WcfWebClient
{
    public partial class Edit : System.Web.UI.Page
    {
        Service1Client Client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["cID"]);

            Contact contact = Client.Details(id);
            TxtFrstname.Text = contact.firstName.ToString();
            txtLastname.Text = contact.lastName.ToString();
            DpGender.SelectedValue = contact.gender.ToString();
            txtPnumber.Text = contact.phoneNumber.ToString();
            txtEmail.Text = contact.emailAddress.ToString();
            txtCity.Text = contact.city.ToString();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["cID"]);
            Contact contact = new Contact()
            {
                firstName = TxtFrstname.Text.ToString(),
                lastName = txtLastname.Text.ToString(),
                gender = DpGender.SelectedValue.ToString(),
                emailAddress = txtEmail.Text.ToString(),
                phoneNumber = txtPnumber.Text.ToString(),
                city = txtCity.Text.ToString()
            };
            Client.edit(id,contact);

            Response.Redirect("Default.aspx");
        }
    }
}