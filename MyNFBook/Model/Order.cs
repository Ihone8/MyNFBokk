using System;

namespace Model
{
    /// <summary>
    /// 模型类：订单
    /// </summary>

    public class Order
    {
        /// <summary>
        /// 构造：创建订单对象
        /// </summary>
        public Order() { }

        /// <summary>
        /// 构造：根据指定的参数创建订单对象
        /// </summary>
        /// <param name="id">订单编号</param>
        /// <param name="orderNo">订单流水号</param>
        /// <param name="orderDate">订购日期</param>
        /// <param name="totalPrice">总价</param>
        /// <param name="orderAddress">收货地址</param>
        /// <param name="addressee">收货人</param>
        /// <param name="phone">收货人电话</param>
        /// <param name="customerID">订购人编号</param>
        /// <param name="customerName">订购人名称</param>
        /// <param name="state">状态</param>
        public Order(string id,string orderNo,DateTime orderDate,decimal totalPrice,string orderAddress,string addressee,string phone,string customerID,string customerName,int state) 
        {
            ID = id;
            OrderNo = orderNo;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
            OrderAddress = orderAddress;
            Addressee = addressee;
            OrderPhone = phone;
            CustomerID = customerID;
            State = state;
        }

        /// <summary>
        /// 属性：订单编号
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 属性：订单流水号
        /// </summary>
        public string OrderNo { get; set; }

        /// <summary>
        /// 属性：订购日期
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// 属性：总价
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// 属性：收货地址
        /// </summary>
        public string OrderAddress { get; set; }

        /// <summary>
        /// 属性：收货人
        /// </summary>
        public string Addressee { get; set; }

        /// <summary>
        /// 属性：收货人电话
        /// </summary>
        public string OrderPhone { get; set; }

        /// <summary>
        /// 属性：订购人编号
        /// </summary>
        public string CustomerID { get; set; }

        /// <summary>
        /// 属性：订购人名称
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// 属性：状态
        /// </summary>
        public int State { get; set; }
    }
}
