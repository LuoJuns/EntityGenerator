namespace EntityGenerator
{
    public class MemberTag
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 自动打标签完成订单数量
        /// </summary>
        public int? FinishOrderCount { get; set; }
        /// <summary>
        /// 自动打标签完成订单金额
        /// </summary>
        public decimal? FinishOrderAmount { get; set; }
    }
}
