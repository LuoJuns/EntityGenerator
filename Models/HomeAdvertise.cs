namespace EntityGenerator
{
    public class HomeAdvertise
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
        /// 轮播位置：0->PC首页轮播；1->app首页轮播
        /// </summary>
        public int? Type { get; set; }
        /// <summary>
        /// Pic
        /// </summary>
        public string? Pic { get; set; }
        /// <summary>
        /// StartTime
        /// </summary>
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// EndTime
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// 上下线状态：0->下线；1->上线
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// 点击数
        /// </summary>
        public int? ClickCount { get; set; }
        /// <summary>
        /// 下单数
        /// </summary>
        public int? OrderCount { get; set; }
        /// <summary>
        /// 链接地址
        /// </summary>
        public string? Url { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string? Note { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int? Sort { get; set; }
    }
}
