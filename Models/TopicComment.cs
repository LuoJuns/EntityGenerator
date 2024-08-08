namespace EntityGenerator
{
    public class TopicComment
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// MemberNickName
        /// </summary>
        public string? MemberNickName { get; set; }
        /// <summary>
        /// TopicId
        /// </summary>
        public long? TopicId { get; set; }
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
        /// ShowStatus
        /// </summary>
        public int? ShowStatus { get; set; }
    }
}
