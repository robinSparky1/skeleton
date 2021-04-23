using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 AccountNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        AccountNo = Convert.ToInt32(Session["AccountNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.ThisCustomer.Find(AccountNo);
        CustomerBook.Delete();
        Response.Redirect("CustomerList.aspx");
    }
}