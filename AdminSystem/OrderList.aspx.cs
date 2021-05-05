using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class AnOrder : System.Web.UI.Page
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
        clsOrderCollection OrdersPage = new clsOrderCollection();
        //lstOrderList.DataSource = Orders.OrderList;
        //lstOrderList.DataValueField = "OrderNumber";
        //lstOrderList.DataTextField = "OrderPrice";
        //lstOrderList.DataBind();
        Orders.ThisOrder.Find(OrderNumber);
        txtAddress.Text = OrdersPage.ThisOrder.OrderNumber.ToString();
        txtOrderNumber.Text = OrdersPage.ThisOrder.OrderNumber;
        txtItemCount.Text = OrdersPage.ThisOrder.ItemCount.ToString();
        txtDate.Text = OrdersPage.ThisOrder.Date.ToString();
        txtOrderPrice = OrdersPage.ThisOrder.OrderPrice.ToString();
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