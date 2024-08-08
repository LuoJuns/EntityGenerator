namespace EntityGenerator
{
    public class Help
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
        /// Icon
        /// </summary>
        public string? Icon { get; set; }
        /// <summary>
        /// Title
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// ShowStatus
        /// </summary>
        public int? ShowStatus { get; set; }
        /// <summary>
        /// CreateTime
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// ReadCount
        /// </summary>
        public int? ReadCount { get; set; }
        /// <summary>
        /// Content
        /// </summary>
        public string? Content { get; set; }
    }
}
