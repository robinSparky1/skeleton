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
        string orderText = Convert.ToString(anOrder.OrderNumber);
        orderText= txtOrderNumber.Text;
        Session["anOrder"] = anOrder;
        Response.Redirect("OrderViewer.aspx");
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
            txtAddress.Text = anOrder.AddressNumber.ToString();
            txtDate.Text = anOrder.Date.ToString();
            cbPayed.Checked = anOrder.Payed;
            }
        }
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}
