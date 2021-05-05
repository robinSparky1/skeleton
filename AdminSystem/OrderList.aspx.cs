using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 OrderNumber;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderNumber = Convert.ToInt32(Session["OrderNumber"]);
        if (IsPostBack == false) {
            if (OrderNumber != -1) {
                DisplayOrders();
            }
        }
    }

    void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection();
        //lstOrderList.DataSource = Orders.OrderList;
        //lstOrderList.DataValueField = "OrderNumber";
        //lstOrderList.DataTextField = "OrderPrice";
        //lstOrderList.DataBind();
        Orders.ThisOrder.Find(OrderNumber);
    }

    protected void lstOrderList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderNumber"] = -1;
        Response.Redirect("AnOrder.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderNumber;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderNumber = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderNumber"] = OrderNumber;
            Response.Redirect("AnOrder.aspx");
        }
        else {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderNumber;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderNumber = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderNumber"] = OrderNumber;
            Response.Redirect("DeleteOrder.aspx");
        }
        else {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}