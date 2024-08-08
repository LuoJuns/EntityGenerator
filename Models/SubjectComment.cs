namespace EntityGenerator
{
    public class SubjectComment
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// SubjectId
        /// </summary>
        public long? SubjectId { get; set; }
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
        /// ShowStatus
        /// </summary>
        public int? ShowStatus { get; set; }
    }
}
