using Zezoprice.Dtos;

namespace Zezoprice.Services
{
    public interface IServices
    {
        decimal GetPriceLevelBuild(decimal Area, DateTime? dateTime,CalculatePriceAfterDto dto);
        decimal GetPriceLevelMeterLand(decimal Area, DateTime? dateTime);
        public decimal GetPriceLevelAcreLand(decimal Area, DateTime? dateTime);
        public decimal GetPriceDelifery(int id, DateTime? dateTime);


        decimal CalculatePriceAfter(CalculatePriceAfterDto calculatePriceAfter, DateTime? dateTime);
        List<decimal> GetArea(TypesToGetAreaDto typesToGetArea);
    }
}
