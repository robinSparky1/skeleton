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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        ACustomer.CustomerName = txtCustomerName.Text;
        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 AccountNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        AccountNo = Convert.ToInt32(txtAccountNo.Text);
        //find the record
        Found = ACustomer.Find(AccountNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerName.Text = ACustomer.CustomerName;
            txtCustomerEmail.Text = ACustomer.CustomerEmail;
            txtBallance.Text = ACustomer.Ballance.ToString();
            txtDateOfBirth.Text = ACustomer.DateOfBirth.ToString();
            txtDateAdded.Text = ACustomer.DateAdded.ToString();
            
        }
    }
}