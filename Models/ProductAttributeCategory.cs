namespace EntityGenerator
{
    public class ProductAttributeCategory
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 属性数量
        /// </summary>
        public int? AttributeCount { get; set; }
        /// <summary>
        /// 参数数量
        /// </summary>
        public int? ParamCount { get; set; }
    }
}
