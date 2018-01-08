using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace DAL
{
   public  class CustomerDAL
    {
       /// <summary>
       /// 添加新用户方法（）
       /// </summary>
       /// <param name="model">用户实体类</param>
       /// <returns>数据库受影响的行数，如果大于0则说明用户注册成功！，否则失败</returns>
       public static int AddNewCustomer(Model.Customer model)
       {
           string sql= " insert into Customer([ID],[LoginName],[Password],[CustomerName],[Email]) values(@ID,@LoginName,@Pwd,@CustomerName,@Email)";
           SqlParameter[] P ={
                                 new SqlParameter("@ID",model.ID),
                                 new SqlParameter("@LoginName",model.LoginName),
                                new SqlParameter("@Pwd",model.Password),
                                new SqlParameter("@CustomerName",model.CustomerName),
                                new SqlParameter("@Email",model.Email),
                             };
           return DbHepler.ExecuteNonQuery(sql,System.Data.CommandType.Text,P);
       }
       /// <summary>
       /// 查询该该用户注册的账号数据库是否存在方法（）
       /// </summary>
       /// <param name="model">用户实体类</param>
       /// <returns>数据库受影响的行数，如果大于0则说明该账号已经存在，否则不存在</returns>
       public static int SelectUserName(Model.Customer model)
       {
           string sql = "  select count(*) from Customer where LoginName=@LoginName";
           SqlParameter[] P ={
                                 new SqlParameter("@LoginName",model.LoginName),
                             };
           return (int)DbHepler.ExcuteReadCount(sql, P);
       }
       /// <summary>
       /// 用户登入方法（）
       /// </summary>
       /// <param name="model">用户实体类</param>
       /// <returns>数据库受影响的行数，如果大于0则说明登入成功！，否则失败</returns>
       public static int UserLogin(Model.Customer model)
       {
           string sql = "  select count(*) from Customer where LoginName=@LoginName and [Password]=@pwd";
           SqlParameter[] P ={
                                 new SqlParameter("@LoginName",model.LoginName),
                                 new SqlParameter("@pwd",model.Password),
                             };
           return (int)DbHepler.ExcuteReadCount(sql, P);
       }
       /// <summary>
       /// 读取用户信息方法（）
       /// </summary>
       /// <returns>读取到的用户信息数据集合</returns>
       public static List<Model.Customer> GetCustomerInfor()
       {
           List<Model.Customer> modelList = new List<Model.Customer>();
           string sql = "  select * from Customer";
           SqlDataReader dr = DbHepler.ExecuteReader(sql,System.Data.CommandType.Text);
           while (dr.Read())
           {
               modelList.Add(new Model.Customer()
               {
                   Answer = dr["Answer"].ToString(),
                   State = (int)dr["State"],
                   Question = dr["Question"].ToString(),
                   Birthday = (DateTime)dr["Birthday"],
                   CustomerName = dr["CustomerName"].ToString(),
                   Email = dr["Email"].ToString(),
                   Gender = dr["Gender"].ToString(),
                   ID = dr["ID"].ToString(),
                   LastLogDate = (DateTime)dr["LastLogDate"],
                   //LoginInfo = dr["LoginInfo"].ToString(),
                   LoginName = dr["LoginName"].ToString(),
                   Password = dr["Password"].ToString(),
                   Phone = dr["Phone"].ToString(),
                   QQMSN = dr["QQMSN"].ToString(),
               });
           }
           DbHepler.Close();
           return modelList;
       }
       /// <summary>
       /// 修改用户个人信息的方法（）
       /// </summary>
       /// <param name="customer">用户实体类</param>
       /// <returns>数据库受影响的行数，如果大于0则说明修改成功！，否则失败</returns>
       public static int UpdateCustomer(Model.Customer customer)
       {
           string sql = "  update Customer set CustomerName=@Name,Gender=@Gender,Birthday=@Birthday where ID=@ID";
           SqlParameter[] P ={
                                  new SqlParameter("@Name",customer.CustomerName),
                                  new SqlParameter("@Gender",customer.Gender),
                                  new SqlParameter("@Birthday",customer.Birthday),
                                  new SqlParameter("@ID",customer.ID),
           };
           return DbHepler.ExecuteNonQuery(sql,System.Data.CommandType.Text,P);
       }
       /// <summary>
       /// 修改用户的联系方式方法（）
       /// </summary>
       /// <param name="customer">用户实体类</param>
       /// <returns>数据库受影响的行数，如果大于0则说明修改成功！，否则失败</returns>
       public static int UpdateCustomerContactWay(Model.Customer customer)
       {
           string sql = "  update Customer set Phone=@Phone,QQMSN=@QQMSN,Email=@Email where ID=@ID";
           SqlParameter[] P ={
                                 new SqlParameter("@Phone",customer.Phone),
                                 new SqlParameter("@QQMSN",customer.QQMSN),
                                 new SqlParameter("@Email",customer.Email),
                                 new SqlParameter("@ID",customer.ID),
                             };
           return DbHepler.ExecuteNonQuery(sql, System.Data.CommandType.Text, P);
       }
       /// <summary>
       /// 修改用户密码密保方法（）
       /// </summary>
       /// <param name="customer">用户实体类</param>
       /// <returns>数据库受影响的行数，如果大于0则说明修改成功！，否则失败</returns>
       public static int UpdateCustomerPasswordQuestion(Model.Customer customer)
       {
           string sql = "  update Customer set Question=@Qusetion,Answer=@Answer where ID=@ID";
           SqlParameter[] P ={
                                 new SqlParameter("@Qusetion",customer.Question),
                                 new SqlParameter("@Answer",customer.Answer),
                                 new SqlParameter("@ID",customer.ID),
                             };
           return DbHepler.ExecuteNonQuery(sql, System.Data.CommandType.Text, P);
       }
       /// <summary>
       /// 修改用户密码的方法（）
       /// </summary>
       /// <param name="customer">用户实体类</param>
       /// <returns>数据库受影响的行数，如果大于0则说明修改成功！，否则失败</returns>
       public static int UpdateCustomerPassword(Model.Customer customer)
       {
           string sql = " update Customer set Password=@Password where ID=@ID";
           SqlParameter[] P ={
                                 new SqlParameter("@Password",customer.Password),
                                 new SqlParameter("@ID",customer.ID),
                             };
           return DbHepler.ExecuteNonQuery(sql, System.Data.CommandType.Text, P);
       }
    }
}
