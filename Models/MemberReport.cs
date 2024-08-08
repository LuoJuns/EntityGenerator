namespace EntityGenerator
{
    public class MemberReport
    {
        /// <summary>
        /// Id
        /// </summary>
        public long? Id { get; set; }
        /// <summary>
        /// 举报类型：0->商品评价；1->话题内容；2->用户评论
        /// </summary>
        public int? ReportType { get; set; }
        /// <summary>
        /// 举报人
        /// </summary>
        public string? ReportMemberName { get; set; }
        /// <summary>
        /// CreateTime
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// ReportObject
        /// </summary>
        public string? ReportObject { get; set; }
        /// <summary>
        /// 举报状态：0->未处理；1->已处理
        /// </summary>
        public int? ReportStatus { get; set; }
        /// <summary>
        /// 处理结果：0->无效；1->有效；2->恶意
        /// </summary>
        public int? HandleStatus { get; set; }
        /// <summary>
        /// Note
        /// </summary>
        public string? Note { get; set; }
    }
}
