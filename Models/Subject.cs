namespace EntityGenerator
{
    public class Subject
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
        /// Title
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// 专题主图
        /// </summary>
        public string? Pic { get; set; }
        /// <summary>
        /// 关联产品数量
        /// </summary>
        public int? ProductCount { get; set; }
        /// <summary>
        /// RecommendStatus
        /// </summary>
        public int? RecommendStatus { get; set; }
        /// <summary>
        /// CreateTime
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// CollectCount
        /// </summary>
        public int? CollectCount { get; set; }
        /// <summary>
        /// ReadCount
        /// </summary>
        public int? ReadCount { get; set; }
        /// <summary>
        /// CommentCount
        /// </summary>
        public int? CommentCount { get; set; }
        /// <summary>
        /// 画册图片用逗号分割
        /// </summary>
        public string? AlbumPics { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// 显示状态：0->不显示；1->显示
        /// </summary>
        public int? ShowStatus { get; set; }
        /// <summary>
        /// Content
        /// </summary>
        public string? Content { get; set; }
        /// <summary>
        /// 转发数
        /// </summary>
        public int? ForwardCount { get; set; }
        /// <summary>
        /// 专题分类名称
        /// </summary>
        public string? CategoryName { get; set; }
    }
}
