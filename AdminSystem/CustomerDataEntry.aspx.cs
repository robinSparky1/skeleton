using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 AccountNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        AccountNo = Convert.ToInt32(Session["addressNo"]);
        if (IsPostBack == false)
        {
            if (AccountNo != -1)
            {
                DisplayCustomers();
            }
        }
    }
    void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ThisCustomer.Find(AccountNo);
        txtAccountNo.Text = Customers.ThisCustomer.AccountNo.ToString();
        txtCustomerName.Text = Customers.ThisCustomer.CustomerName;
        txtCustomerEmail.Text = Customers.ThisCustomer.CustomerEmail;
        txtDateAdded.Text = Customers.ThisCustomer.DateAdded.ToString();
        txtDateOfBirth.Text = Customers.ThisCustomer.DateOfBirth.ToString();
        chkAccountVerified.Checked = Customers.ThisCustomer.AccountVerified;
        txtBallance.Text = Customers.ThisCustomer.Ballance.ToString();


    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        string CustomerName = txtCustomerName.Text;
        string CustomerEmail = txtCustomerEmail.Text;
        string DateOfBirth = txtDateOfBirth.Text;
        string DateAdded = txtDateAdded.Text;
        string Ballance = txtBallance.Text;
        string Error="";
        Error = ACustomer.Valid(CustomerName, CustomerEmail, DateAdded, DateOfBirth, Ballance);
        if (Error == "")
        {
            ACustomer.CustomerName = CustomerName;
            ACustomer.CustomerEmail = CustomerEmail;
            ACustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            ACustomer.DateAdded = Convert.ToDateTime(DateAdded);
            ACustomer.Ballance = Convert.ToInt32(Ballance);
            ACustomer.AccountVerified = chkAccountVerified.Checked;
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            if (AccountNo == -1)
            {
                CustomerList.ThisCustomer.Find(AccountNo);
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Update();
            }
            else
            {
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Add();
                
            }
            Response.Redirect("CustomerList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }
        
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