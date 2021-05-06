using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_OrderList : System.Web.UI.Page
{
    Int32 OrderNumber;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderNumber = Convert.ToInt32(Session["OrderNumber"]);
        if (IsPostBack == false)
        {
            if (OrderNumber != -1)
            {
                DisplayOrders();
            }
        }
    }

    void DisplayOrders()
    {
        ClassLibrary.clsOrderCollection Orders = new ClassLibrary.clsOrderCollection();
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderNumber";
        lstOrderList.DataTextField = "OrderPrice";
        lstOrderList.DataBind();
   
    }
    

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderNumber"] = -1;
        Response.Redirect("OrderDataEntry.aspx");
    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderNumber;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderNumber = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderNumber"] = OrderNumber;
            Response.Redirect("OrderDataEntry.aspx");
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
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.RepostByAddress();

    }
}