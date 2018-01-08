using System;

namespace Model
{
    /// <summary>
    /// 模型类：地址
    /// </summary>

    public class AddressInfo
    {
        /// <summary>
        /// 构造：创建地址信息对象
        /// </summary>
        public AddressInfo() { }

        /// <summary>
        /// 构造：根据指定的数据创建地址信息对象
        /// </summary>
        /// <param name="id">编号</param>
        /// <param name="customerID">客户编号</param>
        /// <param name="address">地址</param>
        /// <param name="addressee">收件人</param>
        /// <param name="phone">收件人电话</param>
        /// <param name="isFirstAddress">是否是默认地址</param>
        /// <param name="state">状态</param>
        public AddressInfo(string id,string customerID,string address,string addressee,string phone,int isFirstAddress,int state)
        {
            ID = id;
            CustomerID = customerID;
            Address = address;
            Addressee = addressee;
            Phone = phone;
            IsFirstAddress = isFirstAddress;
            State = state;
        }

        /// <summary>
        /// 属性：编号
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 属性：客户编号
        /// </summary>
        public string CustomerID { get; set; }

        /// <summary>
        /// 属性：地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 属性：收件人
        /// </summary>
        public string Addressee { get; set; }

        /// <summary>
        /// 属性：电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 属性：是否是首选地址
        /// </summary>
        public int IsFirstAddress { get; set; }

        /// <summary>
        /// 属性：状态
        /// </summary>
        public int State { get; set; }
    }
}
