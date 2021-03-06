﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
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
        clsOrderCollection OrdersPage = new clsOrderCollection();
        //lstOrderList.DataSource = Orders.OrderList;
        //lstOrderList.DataValueField = "OrderNumber";
        //lstOrderList.DataTextField = "OrderPrice";
        //lstOrderList.DataBind();
        OrdersPage.ThisOrder.Find(OrderNumber);
        txtAddress.Text = OrdersPage.ThisOrder.Address;
        txtOrderNumber.Text = OrdersPage.ThisOrder.OrderNumber.ToString();
        txtItemCount.Text = OrdersPage.ThisOrder.ItemCount.ToString();
        txtDate.Text = OrdersPage.ThisOrder.Date.ToString();
        txtOrderPrice.Text = OrdersPage.ThisOrder.OrderPrice.ToString();
        cbPayed.Checked = OrdersPage.ThisOrder.Payed;
    }


    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsOrder anOrder = new clsOrder();

        string OrderNumber = txtOrderNumber.Text;
        string Address = txtAddress.Text;
        string ItemCount = txtItemCount.Text;
        string OrderPrice = txtOrderPrice.Text;
        string Date = txtDate.Text;

        string Error = "";
        Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);

        if (Error == "")
        {
            anOrder.OrderNumber = Convert.ToInt32(OrderNumber);
            anOrder.Address = Address;
            anOrder.OrderPrice = Convert.ToDouble(OrderPrice);
            anOrder.ItemCount = Convert.ToInt32(ItemCount);
            anOrder.Date = Convert.ToDateTime(Date);
            anOrder.Payed = cbPayed.Checked;

            clsOrderCollection OrderList = new clsOrderCollection();

            if (Convert.ToInt32(OrderNumber) == -1)
            {
                OrderList.ThisOrder = anOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(Convert.ToInt32(OrderNumber));
                OrderList.ThisOrder = anOrder;
                OrderList.Update();
            }

            Response.Redirect("OrderList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

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

