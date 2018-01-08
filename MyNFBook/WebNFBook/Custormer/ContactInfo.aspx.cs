using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNFBook.Custormer
{
    public partial class ContactInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //获取用户登入的之后的信息
            Model.Customer customer = Session["customer"] as Model.Customer;
            (Master.FindControl("hyLogin") as HyperLink).Text = customer.CustomerName;
            if (customer == null)
                Response.Redirect("~/default.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //获取Session 用户存储的信息
            Model.Customer customer = Session["customer"] as Model.Customer;
            //取得该用户的ID
            Model.Customer person = (from B in BLL.CustomerBLL.GetCustomerInfor() where B.LoginName == customer.LoginName select B).First();
            Model.Customer cu = new Model.Customer();
            cu.Phone = txtPhone.Text;
            cu.QQMSN = txtQQMSN.Text;
            cu.Email = txtEmail.Text;
            cu.ID = person.ID;
            if (BLL.CustomerBLL.UpdateCustomerContactWay(cu) > 0)
            {
                lblMes.Text = "保存个人信息成功！";
            }
            else
                lblMes.Text = "保存个人信息失败！，请联系管理员";
        }
    }
}