namespace EntityGenerator
{
    public class FlashPromotionLog
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// MemberId
        /// </summary>
        public int? MemberId { get; set; }
        /// <summary>
        /// ProductId
        /// </summary>
        public long? ProductId { get; set; }
        /// <summary>
        /// MemberPhone
        /// </summary>
        public string? MemberPhone { get; set; }
        /// <summary>
        /// ProductName
        /// </summary>
        public string? ProductName { get; set; }
        /// <summary>
        /// 会员订阅时间
        /// </summary>
        public DateTime? SubscribeTime { get; set; }
        /// <summary>
        /// SendTime
        /// </summary>
        public DateTime? SendTime { get; set; }
    }
}
