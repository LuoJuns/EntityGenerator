namespace EntityGenerator
{
    public class OrderOperateHistory
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 订单id
        /// </summary>
        public long? OrderId { get; set; }
        /// <summary>
        /// 操作人：用户；系统；后台管理员
        /// </summary>
        public string? OperateMan { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 订单状态：0->待付款；1->待发货；2->已发货；3->已完成；4->已关闭；5->无效订单
        /// </summary>
        public int? OrderStatus { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string? Note { get; set; }
    }
}
