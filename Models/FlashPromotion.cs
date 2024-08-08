namespace EntityGenerator
{
    public class FlashPromotion
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 秒杀时间段名称
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// 开始日期
        /// </summary>
        public object? StartDate { get; set; }
        /// <summary>
        /// 结束日期
        /// </summary>
        public object? EndDate { get; set; }
        /// <summary>
        /// 上下线状态
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
    }
}
