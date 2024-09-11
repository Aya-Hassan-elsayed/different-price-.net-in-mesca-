namespace Zezoprice.Dtos
{
    public class CalculatePriceAfterDto
    {

        public int TypeId { get; set; }
        public int usageTypeId { get; set; }
        public int goverid { get; set; }
        public List<decimal> Area { get; set; }
    }
}
