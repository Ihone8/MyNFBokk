using System;

namespace Model
{
    /// <summary>
    /// 模型类：订单明细
    /// </summary>

    public class OrderDetail
    {
        /// <summary>
        /// 构造：创建订单明细对象
        /// </summary>
        public OrderDetail() { }

        /// <summary>
        /// 构造：根据跟定的数据创建订单明细对象
        /// </summary>
        /// <param name="id">编号</param>
        /// <param name="orderID">订单编号</param>
        /// <param name="bookID">图书编号</param>
        /// <param name="title">图书名称</param>
        /// <param name="count">购买数量</param>
        /// <param name="price">单价</param>
        /// <param name="state">状态</param>
        public OrderDetail(string id,string orderID,string bookID,string title,int count,decimal price,int state)
        {
            ID = id;
            OrderID = orderID;
            BookID = bookID;
            Title = title;
            Count = count;
            Price = price;
            State = state;
        }

        /// <summary>
        /// 属性：编号
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 属性：订单编号
        /// </summary>
        public string OrderID { get; set; }

        /// <summary>
        /// 属性：图书编号
        /// </summary>
        public string BookID { get; set; }

        /// <summary>
        /// 属性：图书名称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 属性：购买数量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 属性：单价
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 属性：状态
        /// </summary>
        public int State { get; set; }
    }
}
