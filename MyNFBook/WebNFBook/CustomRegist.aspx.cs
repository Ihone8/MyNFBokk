using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNFBook
{
    public partial class CustomRegist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegist_Click(object sender, EventArgs e)
        {
            Model.Customer model = new Model.Customer();
            model.ID = Guid.NewGuid().ToString();
            model.LoginName = txtUserName.Text.ToLower();
            model.Password = txtPassword.Text.Trim();
            model.CustomerName = txtUserName.Text.Trim();
            model.Email = txtEmail.Text.Trim();
            //判断用户输入的账号是否存在
            if (BLL.CustomerBLL.SelectUserName(model) > 0)
            {
                lblMes.Text = "该账号已经存在！,请填写其他账号名称";
                return;
            } 
            Session["User"] = model;
            //如果没有就添加该用户信息          
            lblMes.Text = BLL.CustomerBLL.AddNewCustomer(model) + "你可以<a href='Custormer/BasicInfo.aspx'>完善个人资料</a>";
        }
    }
}