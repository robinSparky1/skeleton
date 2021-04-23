using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayCustomers();
        }
    }
    void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "AccountNo";
        lstCustomerList.DataTextField = "CustomerName";
        lstCustomerList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["AccountNo"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 AccountNo;
        if (lstCustomerList.SelectedIndex != -1)
        {
            AccountNo = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["AccountNo"] = AccountNo;
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 AccountNo;
        if (lstCustomerList.SelectedIndex != -1)
        {
            AccountNo = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["AccountNo"] = AccountNo;
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "please select a record to delete from the list";
        }
    }
}