namespace EntityGenerator
{
    public class ProductCategoryAttributeRelation
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// ProductCategoryId
        /// </summary>
        public long? ProductCategoryId { get; set; }
        /// <summary>
        /// ProductAttributeId
        /// </summary>
        public long? ProductAttributeId { get; set; }
    }
}
