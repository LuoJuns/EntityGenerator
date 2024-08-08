namespace EntityGenerator
{
    public class ProductAttributeValue
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
        /// ProductAttributeId
        /// </summary>
        public long? ProductAttributeId { get; set; }
        /// <summary>
        /// 手动添加规格或参数的值，参数单值，规格有多个时以逗号隔开
        /// </summary>
        public string? Value { get; set; }
    }
}
