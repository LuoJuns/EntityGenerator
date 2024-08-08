namespace EntityGenerator
{
    public class PrefrenceArea
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
        /// SubTitle
        /// </summary>
        public string? SubTitle { get; set; }
        /// <summary>
        /// 展示图片
        /// </summary>
        public object? Pic { get; set; }
        /// <summary>
        /// Sort
        /// </summary>
        public int? Sort { get; set; }
        /// <summary>
        /// ShowStatus
        /// </summary>
        public int? ShowStatus { get; set; }
    }
}
