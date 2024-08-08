namespace EntityGenerator
{
    public class HomeRecommendSubject
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
        /// SubjectName
        /// </summary>
        public string? SubjectName { get; set; }
        /// <summary>
        /// RecommendStatus
        /// </summary>
        public int? RecommendStatus { get; set; }
        /// <summary>
        /// Sort
        /// </summary>
        public int? Sort { get; set; }
    }
}
