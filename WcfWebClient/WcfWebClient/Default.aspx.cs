using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WcfWebClient;
using System.ServiceModel;
using WcfWebClient.CrudService;

namespace WcfWebClient
{
    public partial class Default : System.Web.UI.Page
    {
        Service1Client client;
        protected void Page_Load(object sender, EventArgs e)
        {
            client = new Service1Client();
            //GridView1.DataSource = client.getContacts();
            //GridView1.DataBind();
            BindGridList();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGridList();
        }
        protected void BindGridList()
        {
            GridView1.DataSource = client.getContacts();
            GridView1.DataBind();
        }
    }
}