namespace EntityGenerator
{
    public class CommentReplay
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// CommentId
        /// </summary>
        public long? CommentId { get; set; }
        /// <summary>
        /// MemberNickName
        /// </summary>
        public string? MemberNickName { get; set; }
        /// <summary>
        /// MemberIcon
        /// </summary>
        public string? MemberIcon { get; set; }
        /// <summary>
        /// Content
        /// </summary>
        public string? Content { get; set; }
        /// <summary>
        /// CreateTime
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 评论人员类型；0->会员；1->管理员
        /// </summary>
        public int? Type { get; set; }
    }
}
