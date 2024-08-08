namespace EntityGenerator
{
    public class CouponHistory
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// CouponId
        /// </summary>
        public long? CouponId { get; set; }
        /// <summary>
        /// MemberId
        /// </summary>
        public long? MemberId { get; set; }
        /// <summary>
        /// CouponCode
        /// </summary>
        public string? CouponCode { get; set; }
        /// <summary>
        /// 领取人昵称
        /// </summary>
        public string? MemberNickname { get; set; }
        /// <summary>
        /// 获取类型：0->后台赠送；1->主动获取
        /// </summary>
        public int? GetType { get; set; }
        /// <summary>
        /// CreateTime
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 使用状态：0->未使用；1->已使用；2->已过期
        /// </summary>
        public int? UseStatus { get; set; }
        /// <summary>
        /// 使用时间
        /// </summary>
        public DateTime? UseTime { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        public long? OrderId { get; set; }
        /// <summary>
        /// 订单号码
        /// </summary>
        public string? OrderSn { get; set; }
    }
}
