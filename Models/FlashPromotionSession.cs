namespace EntityGenerator
{
    public class FlashPromotionSession
    {
        /// <summary>
        /// 编号
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 场次名称
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 每日开始时间
        /// </summary>
        public object? StartTime { get; set; }
        /// <summary>
        /// 每日结束时间
        /// </summary>
        public object? EndTime { get; set; }
        /// <summary>
        /// 启用状态：0->不启用；1->启用
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
    }
}
