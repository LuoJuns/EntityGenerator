namespace EntityGenerator
{
    public class Brand
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
        /// 首字母
        /// </summary>
        public string? FirstLetter { get; set; }
        /// <summary>
        /// Sort
        /// </summary>
        public int? Sort { get; set; }
        /// <summary>
        /// 是否为品牌制造商：0->不是；1->是
        /// </summary>
        public int? FactoryStatus { get; set; }
        /// <summary>
        /// ShowStatus
        /// </summary>
        public int? ShowStatus { get; set; }
        /// <summary>
        /// 产品数量
        /// </summary>
        public int? ProductCount { get; set; }
        /// <summary>
        /// 产品评论数量
        /// </summary>
        public int? ProductCommentCount { get; set; }
        /// <summary>
        /// 品牌logo
        /// </summary>
        public string? Logo { get; set; }
        /// <summary>
        /// 专区大图
        /// </summary>
        public string? BigPic { get; set; }
        /// <summary>
        /// 品牌故事
        /// </summary>
        public string? BrandStory { get; set; }
    }
}
