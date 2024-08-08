namespace EntityGenerator
{
    public class OrderSetting
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 秒杀订单超时关闭时间(分)
        /// </summary>
        public int? FlashOrderOvertime { get; set; }
        /// <summary>
        /// 正常订单超时时间(分)
        /// </summary>
        public int? NormalOrderOvertime { get; set; }
        /// <summary>
        /// 发货后自动确认收货时间（天）
        /// </summary>
        public int? ConfirmOvertime { get; set; }
        /// <summary>
        /// 自动完成交易时间，不能申请售后（天）
        /// </summary>
        public int? FinishOvertime { get; set; }
        /// <summary>
        /// 订单完成后自动好评时间（天）
        /// </summary>
        public int? CommentOvertime { get; set; }
    }
}
