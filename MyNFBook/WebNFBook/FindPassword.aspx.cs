using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNFBook
{
    public partial class FindPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                panpl.Visible = false;
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            Model.Customer model = new Model.Customer();
            model.LoginName = txtUserID.Text.ToLower();
            if (BLL.CustomerBLL.SelectUserName(model) > 0)
            {
                Model.Customer customer = (from C in BLL.CustomerBLL.GetCustomerInfor() where C.LoginName == txtUserID.Text.ToLower() select C).First();
                lblMes.Text = null;
                txtUserID.Enabled = false;
                panpl.Visible = true;
                lblUserQuestion.Text = customer.Question;
            }
            else
                lblMes.Text = "该账号不存在！";
        }

        protected void btnFindPwd_Click(object sender, EventArgs e)
        {
            Model.Customer customer = (from C in BLL.CustomerBLL.GetCustomerInfor() where C.LoginName == txtUserID.Text.ToLower() select C).First();
            if (customer.Answer != txtAnswer.Text)
            {
                lblPwdMes.ForeColor = System.Drawing.Color.Red;
                lblPwdMes.Text = "回答问题答案有误，请重新回答！";

            }
            else
            {
                lblPwdMes.Text = "密码已经重置，";
            }
        }
    }
}