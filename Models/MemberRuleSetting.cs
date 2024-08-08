namespace EntityGenerator
{
    public class MemberRuleSetting
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 连续签到天数
        /// </summary>
        public int? ContinueSignDay { get; set; }
        /// <summary>
        /// 连续签到赠送数量
        /// </summary>
        public int? ContinueSignPoint { get; set; }
        /// <summary>
        /// 每消费多少元获取1个点
        /// </summary>
        public decimal? ConsumePerPoint { get; set; }
        /// <summary>
        /// 最低获取点数的订单金额
        /// </summary>
        public decimal? LowOrderAmount { get; set; }
        /// <summary>
        /// 每笔订单最高获取点数
        /// </summary>
        public int? MaxPointPerOrder { get; set; }
        /// <summary>
        /// 类型：0->积分规则；1->成长值规则
        /// </summary>
        public int? Type { get; set; }
    }
}
