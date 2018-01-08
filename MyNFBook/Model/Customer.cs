using System;

namespace Model
{
    /// <summary>
    /// 模型类：用户
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// 构造：创建用户对象
        /// </summary>
        public Customer() { }

        /// <summary>
        /// 构造：根据给定的数据创建用户对象
        /// </summary>
        /// <param name="id">用户编号</param>
        /// <param name="loginName">用户登录名</param>
        /// <param name="password">用户登录密码</param>
        /// <param name="customerName">用户姓名</param>
        /// <param name="state">用户状态</param>
        /// <param name="email">电子邮箱地址</param>
        /// <param name="question">密保问题</param>
        /// <param name="answer">密保答案</param>
        /// <param name="lastLogDate">最后一次登录时间</param>
        /// <param name="phone">联系电话</param>
        /// <param name="qqmsn">QQ或MSN</param>
        /// <param name="gender">性别</param>
        /// <param name="birthday">出生日期</param>
        /// <param name="age">年龄</param>
        public Customer(string id, string loginName, string password, string customerName, int state, string email, string question, string answer, DateTime lastLogDate, string phone, string qqmsn, string gender, DateTime birthday)
        {
            ID = id;
            LoginName = loginName;
            Password = password;
            CustomerName = customerName;
            State = state;
            Email = email;
            Question = question;
            Answer = answer;
            LastLogDate = lastLogDate;
            Phone = phone;
            QQMSN = qqmsn;
            Gender = gender;
            Birthday = birthday;
        }

        /// <summary>
        /// 属性：用户编号
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 属性：用户登录名
        /// </summary>
        public string LoginName { get; set; }

        /// <summary>
        /// 属性：用户登录密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 属性：用户姓名
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// 属性：用户状态
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// 属性：登录信息
        /// </summary>
        public string LoginInfo { get; set; }

        /// <summary>
        /// 属性：电子邮箱地址
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 属性：密保问题
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// 属性：密保答案
        /// </summary>
        public string Answer { get; set; }

        /// <summary>
        /// 属性：最后一次登录时间
        /// </summary>
        public DateTime LastLogDate { get; set; }

        /// <summary>
        /// 属性：联系电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 属性：QQ号码或MSN帐号
        /// </summary>
        public string QQMSN { get; set; }

        /// <summary>
        /// 属性：性别
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// 属性：出生日期
        /// </summary>
        public DateTime Birthday { get; set; }
    }
}
