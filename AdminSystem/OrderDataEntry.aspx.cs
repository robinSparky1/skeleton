using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsOrder anOrder = new clsOrder();

        string Address = txtAddress.Text;
        string ItemCount = txtItemCount.Text;
        string OrderPrice = txtOrderPrice.Text;
        string Date = txtDate.Text;

        string Error = "";
        Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);

        if (Error == "")
        {
            anOrder.Address = Address;
            anOrder.OrderPrice = Convert.ToDouble(OrderPrice);
            anOrder.ItemCount = Convert.ToInt32(ItemCount);
            anOrder.Date = Convert.ToDateTime(Date);
            anOrder.Payed = cbPayed.Checked;

            clsOrderCollection OrderList = new clsOrderCollection();
            OrderList.ThisOrder = anOrder;
            OrderList.Add();
            Response.Redirect("OrderList.aspx");
        }
        else {
            lblError.Text = Error;
        }
     
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder anOrder = new clsOrder();
        Int32 OrderNumber;
        Boolean Found = false;
        OrderNumber = Convert.ToInt32(txtOrderNumber.Text);
        Found = anOrder.Find(OrderNumber);

        if (Found)
        {
            txtOrderNumber.Text = anOrder.OrderNumber.ToString();
            txtItemCount.Text = anOrder.ItemCount.ToString();
            txtOrderPrice.Text = anOrder.OrderPrice.ToString();
            txtAddress.Text = anOrder.Address.ToString();
            txtDate.Text = anOrder.Date.ToString();
            cbPayed.Checked = anOrder.Payed;
            }
        }

    protected void txtItemCount_TextChanged(object sender, EventArgs e)
    {

    }



    protected void txtAddress_TextChanged(object sender, EventArgs e)
    {

    }
}

