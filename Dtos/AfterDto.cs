namespace Zezoprice.Dtos
{
    public class AfterDto
    {

        public string RequestNumber { get; set; }
        public List<decimal> Area { get; set; }
        public string RequestType { get; set; }
        public string UsageType { get; set; }
        public decimal Price { get; set; }
       // public DateTime? Due_date { get; set; }
    }
}
