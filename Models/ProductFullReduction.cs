namespace EntityGenerator
{
    public class ProductFullReduction
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
        /// FullPrice
        /// </summary>
        public decimal? FullPrice { get; set; }
        /// <summary>
        /// ReducePrice
        /// </summary>
        public decimal? ReducePrice { get; set; }
    }
}
