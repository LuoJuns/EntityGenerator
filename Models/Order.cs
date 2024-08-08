namespace EntityGenerator
{
    public class Order
    {
        /// <summary>
        /// 订单id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// MemberId
        /// </summary>
        public long MemberId { get; set; }
        /// <summary>
        /// CouponId
        /// </summary>
        public long? CouponId { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        public string? OrderSn { get; set; }
        /// <summary>
        /// 提交时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 用户帐号
        /// </summary>
        public string? MemberUsername { get; set; }
        /// <summary>
        /// 订单总金额
        /// </summary>
        public decimal? TotalAmount { get; set; }
        /// <summary>
        /// 应付金额（实际支付金额）
        /// </summary>
        public decimal? PayAmount { get; set; }
        /// <summary>
        /// 运费金额
        /// </summary>
        public decimal? FreightAmount { get; set; }
        /// <summary>
        /// 促销优化金额（促销价、满减、阶梯价）
        /// </summary>
        public decimal? PromotionAmount { get; set; }
        /// <summary>
        /// 积分抵扣金额
        /// </summary>
        public decimal? IntegrationAmount { get; set; }
        /// <summary>
        /// 优惠券抵扣金额
        /// </summary>
        public decimal? CouponAmount { get; set; }
        /// <summary>
        /// 管理员后台调整订单使用的折扣金额
        /// </summary>
        public decimal? DiscountAmount { get; set; }
        /// <summary>
        /// 支付方式：0->未支付；1->支付宝；2->微信
        /// </summary>
        public int? PayType { get; set; }
        /// <summary>
        /// 订单来源：0->PC订单；1->app订单
        /// </summary>
        public int? SourceType { get; set; }
        /// <summary>
        /// 订单状态：0->待付款；1->待发货；2->已发货；3->已完成；4->已关闭；5->无效订单
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// 订单类型：0->正常订单；1->秒杀订单
        /// </summary>
        public int? OrderType { get; set; }
        /// <summary>
        /// 物流公司(配送方式)
        /// </summary>
        public string? DeliveryCompany { get; set; }
        /// <summary>
        /// 物流单号
        /// </summary>
        public string? DeliverySn { get; set; }
        /// <summary>
        /// 自动确认时间（天）
        /// </summary>
        public int? AutoConfirmDay { get; set; }
        /// <summary>
        /// 可以获得的积分
        /// </summary>
        public int? Integration { get; set; }
        /// <summary>
        /// 可以活动的成长值
        /// </summary>
        public int? Growth { get; set; }
        /// <summary>
        /// 活动信息
        /// </summary>
        public string? PromotionInfo { get; set; }
        /// <summary>
        /// 发票类型：0->不开发票；1->电子发票；2->纸质发票
        /// </summary>
        public int? BillType { get; set; }
        /// <summary>
        /// 发票抬头
        /// </summary>
        public string? BillHeader { get; set; }
        /// <summary>
        /// 发票内容
        /// </summary>
        public string? BillContent { get; set; }
        /// <summary>
        /// 收票人电话
        /// </summary>
        public string? BillReceiverPhone { get; set; }
        /// <summary>
        /// 收票人邮箱
        /// </summary>
        public string? BillReceiverEmail { get; set; }
        /// <summary>
        /// 收货人姓名
        /// </summary>
        public string ReceiverName { get; set; }
        /// <summary>
        /// 收货人电话
        /// </summary>
        public string ReceiverPhone { get; set; }
        /// <summary>
        /// 收货人邮编
        /// </summary>
        public string? ReceiverPostCode { get; set; }
        /// <summary>
        /// 省份/直辖市
        /// </summary>
        public string? ReceiverProvince { get; set; }
        /// <summary>
        /// 城市
        /// </summary>
        public string? ReceiverCity { get; set; }
        /// <summary>
        /// 区
        /// </summary>
        public string? ReceiverRegion { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        public string? ReceiverDetailAddress { get; set; }
        /// <summary>
        /// 订单备注
        /// </summary>
        public string? Note { get; set; }
        /// <summary>
        /// 确认收货状态：0->未确认；1->已确认
        /// </summary>
        public int? ConfirmStatus { get; set; }
        /// <summary>
        /// 删除状态：0->未删除；1->已删除
        /// </summary>
        public int DeleteStatus { get; set; }
        /// <summary>
        /// 下单时使用的积分
        /// </summary>
        public int? UseIntegration { get; set; }
        /// <summary>
        /// 支付时间
        /// </summary>
        public DateTime? PaymentTime { get; set; }
        /// <summary>
        /// 发货时间
        /// </summary>
        public DateTime? DeliveryTime { get; set; }
        /// <summary>
        /// 确认收货时间
        /// </summary>
        public DateTime? ReceiveTime { get; set; }
        /// <summary>
        /// 评价时间
        /// </summary>
        public DateTime? CommentTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? ModifyTime { get; set; }
    }
}
