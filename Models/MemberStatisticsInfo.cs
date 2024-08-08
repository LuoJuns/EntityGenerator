namespace EntityGenerator
{
    public class MemberStatisticsInfo
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// MemberId
        /// </summary>
        public long? MemberId { get; set; }
        /// <summary>
        /// 累计消费金额
        /// </summary>
        public decimal? ConsumeAmount { get; set; }
        /// <summary>
        /// 订单数量
        /// </summary>
        public int? OrderCount { get; set; }
        /// <summary>
        /// 优惠券数量
        /// </summary>
        public int? CouponCount { get; set; }
        /// <summary>
        /// 评价数
        /// </summary>
        public int? CommentCount { get; set; }
        /// <summary>
        /// 退货数量
        /// </summary>
        public int? ReturnOrderCount { get; set; }
        /// <summary>
        /// 登录次数
        /// </summary>
        public int? LoginCount { get; set; }
        /// <summary>
        /// 关注数量
        /// </summary>
        public int? AttendCount { get; set; }
        /// <summary>
        /// 粉丝数量
        /// </summary>
        public int? FansCount { get; set; }
        /// <summary>
        /// CollectProductCount
        /// </summary>
        public int? CollectProductCount { get; set; }
        /// <summary>
        /// CollectSubjectCount
        /// </summary>
        public int? CollectSubjectCount { get; set; }
        /// <summary>
        /// CollectTopicCount
        /// </summary>
        public int? CollectTopicCount { get; set; }
        /// <summary>
        /// CollectCommentCount
        /// </summary>
        public int? CollectCommentCount { get; set; }
        /// <summary>
        /// InviteFriendCount
        /// </summary>
        public int? InviteFriendCount { get; set; }
        /// <summary>
        /// 最后一次下订单时间
        /// </summary>
        public DateTime? RecentOrderTime { get; set; }
    }
}
