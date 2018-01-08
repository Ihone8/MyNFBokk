using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNFBook.Custormer
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //获取用户登入的之后的信息
            Model.Customer customer = Session["customer"] as Model.Customer; 
            (Master.FindControl("hyLogin") as HyperLink).Text = customer.CustomerName;
            if (customer == null)
                Response.Redirect("~/default.aspx");
           
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //获取Session 用户存储的信息
            Model.Customer customer = Session["customer"] as Model.Customer;
            //取得该用户的ID
            Model.Customer person = (from B in BLL.CustomerBLL.GetCustomerInfor() where B.LoginName == customer.LoginName select B).First();
            if(txtOldPwd.Text!=person.Password)
            {
                Response.Write("<script>alert('密码输入有误！')</script>");
                return;
            }
            Model.Customer cu=new Model.Customer();
           cu.Password=txtNewPwd.Text;
           cu.ID=person.ID;
            if(BLL.CustomerBLL.UpdateCustomerPassword(cu)>0)
            {
                lblMes.Text = "密码修改成功！";
            }
        }
    }
}