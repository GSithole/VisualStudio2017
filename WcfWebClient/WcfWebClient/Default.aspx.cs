using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WcfWebClient;
using System.ServiceModel;
using WcfWebClient.CrudService;
using System.Web.UI.HtmlControls;
using ContactClassLibrary;

namespace WcfWebClient
{
    public partial class Default : System.Web.UI.Page
    {
        Service1Client client;
        protected void page_init(object sender, EventArgs e)
        { }
        protected void Page_Load(object sender, EventArgs e)
        {
            //CrudService
            client = new Service1Client();
            //GridView1.DataSource = client.getContacts();
            //GridView1.DataBind();
            BindGridList();

            List<ContactClassLibrary.Contact> contactList = client.getContacts().ToList();

            HtmlTableRow row = new HtmlTableRow();
            HtmlTableCell cell = new HtmlTableCell();

            foreach (var item in contactList)
            {
                
                row = new HtmlTableRow();

                cell = new HtmlTableCell();
                cell.InnerText = item.ID.ToString() ;
                row.Cells.Add(cell);

                cell = new HtmlTableCell();
                cell.InnerText = item.firstName.ToString();
                row.Cells.Add(cell);

                cell = new HtmlTableCell();
                cell.InnerText = item.lastName.ToString();
                row.Cells.Add(cell);

                cell = new HtmlTableCell();
                cell.InnerText = item.gender.ToString();
                row.Cells.Add(cell);

                cell = new HtmlTableCell();
                cell.InnerText = item.phoneNumber.ToString();
                row.Cells.Add(cell);

                cell = new HtmlTableCell();
                cell.InnerText = item.emailAddress.ToString();
                row.Cells.Add(cell);

                cell = new HtmlTableCell();
                cell.InnerText = item.city.ToString();
                row.Cells.Add(cell);

                System.Web.UI.WebControls.HyperLink link = new HyperLink();
                link.NavigateUrl = "~/Edit.aspx?cID=" + item.ID.ToString();
                link.Text = "Edit";
                link.ID = item.ID.ToString();
                 cell = new HtmlTableCell();
                //cell.InnerText = "'</td><td>' + '<a href="EditContact.html?id='" + item.ID;
                //HtmlString linkTest = new HtmlString("<a href= " + "~/Edit.aspx" + "? cID = " + item.ID.ToString() + ">Click Here</a>");
                //row.Controls.Add(link);
                //tableContent.Controls.Add(link);
                cell.Controls.Add(link);
                row.Controls.Add(cell);


                tableContent.Rows.Add(row);
                
            }
        }

        
        protected void BindGridList()
        {
            GridView1.DataSource = client.getContacts();
            GridView1.DataBind();
        }
    }
}