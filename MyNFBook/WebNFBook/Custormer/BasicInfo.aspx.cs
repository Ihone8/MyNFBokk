using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNFBook.Custormer
{
    public partial class BasicInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //获取用户登入的之后的信息
            Model.Customer customer = Session["customer"] as Model.Customer;
            (Master.FindControl("hyLogin") as HyperLink).Text = customer.CustomerName;
            if (customer == null)
                Response.Redirect("~/default.aspx");
        }

        protected void btnSaveUserInfor_Click(object sender, EventArgs e)
        {
            //获取用户登入的之后的信息
            Model.Customer customer1 = Session["customer"] as Model.Customer;
            Model.Customer customer = new Model.Customer();
            customer.CustomerName = txtName.Text;
            customer.Gender = dropGender.SelectedItem.Text;
            customer.Birthday = DateTime.Parse(txtBirthday.Text);
            customer.ID = customer1.ID;
            Response.Write(customer.ID+customer.CustomerName+customer.Gender+customer.Birthday);
            if(BLL.CustomerBLL.UpdateCustomerInfor(customer)>0)
            {
                lblMes.Text = "保存个人信息成功！";
            }
            else
            {
                lblMes.Text = "保存个人信息失败！";
            }
        }
    }
}