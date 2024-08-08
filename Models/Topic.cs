namespace EntityGenerator
{
    public class Topic
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// CategoryId
        /// </summary>
        public long? CategoryId { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// CreateTime
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// StartTime
        /// </summary>
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// EndTime
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// 参与人数
        /// </summary>
        public int? AttendCount { get; set; }
        /// <summary>
        /// 关注人数
        /// </summary>
        public int? AttentionCount { get; set; }
        /// <summary>
        /// ReadCount
        /// </summary>
        public int? ReadCount { get; set; }
        /// <summary>
        /// 奖品名称
        /// </summary>
        public string? AwardName { get; set; }
        /// <summary>
        /// 参与方式
        /// </summary>
        public string? AttendType { get; set; }
        /// <summary>
        /// 话题内容
        /// </summary>
        public string? Content { get; set; }
    }
}
