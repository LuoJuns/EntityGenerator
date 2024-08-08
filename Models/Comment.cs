namespace EntityGenerator
{
    public class Comment
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// ProductId
        /// </summary>
        public long? ProductId { get; set; }
        /// <summary>
        /// MemberNickName
        /// </summary>
        public string? MemberNickName { get; set; }
        /// <summary>
        /// ProductName
        /// </summary>
        public string? ProductName { get; set; }
        /// <summary>
        /// 评价星数：0->5
        /// </summary>
        public int? Star { get; set; }
        /// <summary>
        /// 评价的ip
        /// </summary>
        public string? MemberIp { get; set; }
        /// <summary>
        /// CreateTime
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// ShowStatus
        /// </summary>
        public int? ShowStatus { get; set; }
        /// <summary>
        /// 购买时的商品属性
        /// </summary>
        public string? ProductAttribute { get; set; }
        /// <summary>
        /// CollectCouont
        /// </summary>
        public int? CollectCouont { get; set; }
        /// <summary>
        /// ReadCount
        /// </summary>
        public int? ReadCount { get; set; }
        /// <summary>
        /// Content
        /// </summary>
        public string? Content { get; set; }
        /// <summary>
        /// 上传图片地址，以逗号隔开
        /// </summary>
        public string? Pics { get; set; }
        /// <summary>
        /// 评论用户头像
        /// </summary>
        public string? MemberIcon { get; set; }
        /// <summary>
        /// ReplayCount
        /// </summary>
        public int? ReplayCount { get; set; }
    }
}
