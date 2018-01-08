using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerBLL
    {
        /// <summary>
        /// 添加新用户方法（）
        /// </summary>
        /// <param name="model">用户实体类</param>
        /// <returns>是否添加成功信息</returns>
        public static string AddNewCustomer(Model.Customer model)
        {
                if(DAL.CustomerDAL.AddNewCustomer(model)>0)
                {
                    return "注册成功！";
                }
            else
                    return "注册失败！";
        }
          /// <summary>
       /// 查询该该用户注册的账号数据库是否存在方法（）
       /// </summary>
       /// <param name="model">用户实体类</param>
       /// <returns>数据库受影响的行数，如果大于0则说明该账号已经存在，否则不存在</returns>
        public static int SelectUserName(Model.Customer model)
        {
            return DAL.CustomerDAL.SelectUserName(model);
        }
         /// <summary>
       /// 用户登入方法（）
       /// </summary>
       /// <param name="model">用户实体类</param>
       /// <returns>数据库受影响的行数，如果大于0则说明登入成功！，否则失败</returns>
        public static int UserLogin(Model.Customer model)
        {
            return DAL.CustomerDAL.UserLogin(model);
        }
         /// <summary>
       /// 读取用户信息方法（）
       /// </summary>
       /// <returns>读取到的用户信息数据集合</returns>
        public static List<Model.Customer> GetCustomerInfor()
        {
            return DAL.CustomerDAL.GetCustomerInfor();
        }
         /// <summary>
       /// 修改用户个人信息的方法（）
       /// </summary>
       /// <param name="customer">用户实体类</param>
       /// <returns>数据库受影响的行数，如果大于0则说明修改成功！，否则失败</returns>
        public static int UpdateCustomerInfor(Model.Customer customer)
        {
            return DAL.CustomerDAL.UpdateCustomer(customer);
        }
         /// <summary>
       /// 修改用户的联系方式方法（）
       /// </summary>
       /// <param name="customer">用户实体类</param>
       /// <returns>数据库受影响的行数，如果大于0则说明修改成功！，否则失败</returns>
        public static int UpdateCustomerContactWay(Model.Customer customer)
        {
            return DAL.CustomerDAL.UpdateCustomerContactWay(customer);
        }
         /// <summary>
       /// 修改用户密码密保方法（）
       /// </summary>
       /// <param name="customer">用户实体类</param>
       /// <returns>数据库受影响的行数，如果大于0则说明修改成功！，否则失败</returns>
        public static int UpdateCustomerPasswordQuestion(Model.Customer customer)
        {
            return DAL.CustomerDAL.UpdateCustomerPasswordQuestion(customer);
        }
          /// <summary>
       /// 修改用户密码的方法（）
       /// </summary>
       /// <param name="customer">用户实体类</param>
       /// <returns>数据库受影响的行数，如果大于0则说明修改成功！，否则失败</returns>
        public static int UpdateCustomerPassword(Model.Customer customer)
        {
            return DAL.CustomerDAL.UpdateCustomerPassword(customer);
        }
    }
}
