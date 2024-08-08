namespace EntityGenerator
{
    public class MemberProductCategoryRelation
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// MemberId
        /// </summary>
        public long? MemberId { get; set; }
        /// <summary>
        /// ProductCategoryId
        /// </summary>
        public long? ProductCategoryId { get; set; }
    }
}
