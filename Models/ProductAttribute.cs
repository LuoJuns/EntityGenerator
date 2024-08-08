namespace EntityGenerator
{
    public class ProductAttribute
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// ProductAttributeCategoryId
        /// </summary>
        public long? ProductAttributeCategoryId { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 属性选择类型：0->唯一；1->单选；2->多选
        /// </summary>
        public int? SelectType { get; set; }
        /// <summary>
        /// 属性录入方式：0->手工录入；1->从列表中选取
        /// </summary>
        public int? InputType { get; set; }
        /// <summary>
        /// 可选值列表，以逗号隔开
        /// </summary>
        public string? InputList { get; set; }
        /// <summary>
        /// 排序字段：最高的可以单独上传图片
        /// </summary>
        public int? Sort { get; set; }
        /// <summary>
        /// 分类筛选样式：1->普通；1->颜色
        /// </summary>
        public int? FilterType { get; set; }
        /// <summary>
        /// 检索类型；0->不需要进行检索；1->关键字检索；2->范围检索
        /// </summary>
        public int? SearchType { get; set; }
        /// <summary>
        /// 相同属性产品是否关联；0->不关联；1->关联
        /// </summary>
        public int? RelatedStatus { get; set; }
        /// <summary>
        /// 是否支持手动新增；0->不支持；1->支持
        /// </summary>
        public int? HandAddStatus { get; set; }
        /// <summary>
        /// 属性的类型；0->规格；1->参数
        /// </summary>
        public int? Type { get; set; }
    }
}
