namespace Zezoprice.Dtos
{
    public class DataResponse
    {
        public decimal TotalPriceAfter { get; set; }
        public decimal TotalPriceBefore { get; set; }
        public decimal TotalPriceDifference { get; set; }
        public int TotalCount { get; set; }
        public List<DataDto> Data { get; set; }
    }
}
