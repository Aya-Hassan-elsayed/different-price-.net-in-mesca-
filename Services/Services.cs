using Zezoprice.Dtos;

namespace Zezoprice.Services
{
    public class Services : IServices
    {
        DateTime spcificDate= new DateTime(2022,8,11);


        public decimal GetPriceLevelBuild(decimal Area, DateTime? dateTime,CalculatePriceAfterDto dto)
        {   
          
            if (Area > 0 && Area <= 100)
                return 675;

            if (Area > 100 && Area <= 200)
            {
                if (dateTime.HasValue && dateTime.Value.Year >= 2022)
                {
                    if ( dateTime.Value >= spcificDate && dto.usageTypeId == 2 || dto.usageTypeId == 3)
                        return 2025;

                    else if (dateTime.Value.Year >= 2023)
                    {
                        return 2025;
                    }

                    else
                    {
                        return 1000;
                    }
                       
                }
            }

            if (Area > 200 && Area <= 300)
            {
                if ( dateTime.HasValue && dateTime.Value.Year >= 2022)
                {


                    if (dateTime.Value >= spcificDate && dto.usageTypeId == 2 || dto.usageTypeId == 3)
                        return 3375;

                    else if (dateTime.Value.Year > 2022 && !(dto.usageTypeId == 2 || dto.usageTypeId == 3))
                    {
                        return 3375;
                    }

                    else
                    {
                        return 1500;
                    }

                }

                
            }

            if (Area > 300 && Area <= 400)
                return 4725;

            if (Area > 400)
                return Area * (decimal)11.81;

            return Area;
        }




        public decimal GetPriceLevelMeterLand(decimal Area, DateTime? dateTime)
        {
            if (Area > 0 && Area <= 100)

                return 1350;

            if (Area > 100 && Area <= 200)
                return 2700;


            if (Area > 200 && Area <= 300)
                return 4050;

            if (Area > 300 && Area <= 400)
                return 5400;


            if (Area > 400)
                return Area * (decimal)13.5;

            return Area;
        }

        public decimal GetPriceLevelAcreLand(decimal Area, DateTime? dateTime)
        {
            if (Area > 0 && Area <= 5)

                return 6750;

            if (Area > 5 && Area <= 10)

                return 13500;

            if (Area > 10 && Area <= 20)

                return 27000;


            if (Area > 20)
                return Area * (decimal)1350;


            return Area;
        }

        public decimal GetPriceDelifery(int id, DateTime? dateTime)
        {
            if (dateTime.HasValue && dateTime.Value > spcificDate)
            {
                if (id == 1 || id== 21 || id== 14 )
                    return 100;

                if (id == 2 || id == 3 || id == 4 || id == 11 || id == 12 ||
                    id == 13  || id == 15 ||
                    id == 16 || id == 17 || id == 18 ||
                    id == 19  || id == 22 || id == 23)
                    
                    return 200;

                if (id == 24 || id == 25 || id == 26 || id == 27 || id == 28
                    || id == 29 || id == 31 || id == 32 || id == 33
                    || id == 34 || id == 35)

                    return 300;

            
                return 0;
            }

         
            return 0;
        }

        public decimal CalculatePriceAfter(CalculatePriceAfterDto calculatePriceAfter, DateTime? dateTime)
        {
            decimal Level = 0;
            int multible = 1;
            DateTime finalpricedate = new DateTime(2022, 1, 1);

            if (dateTime.HasValue) // Check if dateTime has a value
            {
                if (calculatePriceAfter.TypeId != 1 && calculatePriceAfter.TypeId != 2 && calculatePriceAfter.TypeId != 24 && calculatePriceAfter.TypeId != 5)
                {
                    Level = GetPriceLevelBuild(calculatePriceAfter.Area[0], dateTime,calculatePriceAfter);

                    if (calculatePriceAfter.usageTypeId != 1 && calculatePriceAfter.usageTypeId != 8
                        && calculatePriceAfter.usageTypeId != 9 && calculatePriceAfter.usageTypeId != 11 && calculatePriceAfter.usageTypeId != 10)
                    {
                        if (dateTime.Value >= spcificDate)
                        {
                            multible = 2;
                        }
                        else
                        {
                            multible = 1;
                        }
                    }
                    else if (calculatePriceAfter.usageTypeId == 1)
                    {
                        multible = 1;
                    }
                }
                else if (calculatePriceAfter.TypeId == 1)
                {
                    Level = GetPriceLevelMeterLand(calculatePriceAfter.Area[0], dateTime);
                    multible = 1;
                }
                else if (calculatePriceAfter.TypeId == 2)
                {
                    Level = GetPriceLevelAcreLand(calculatePriceAfter.Area[0], dateTime);
                    multible = 1;
                }

                decimal deliveryPrice = GetPriceDelifery(calculatePriceAfter.goverid, dateTime);

                // Calculate final price
                var finalprice = Level * multible + deliveryPrice - 25;

                // Apply additional conditions based on the year
                if (dateTime.Value.Year > 2022)
                {
                    if (finalprice > 1000000)
                    {
                        return 1000000;
                    }
                }
                else if (dateTime.Value.Year <=2022 && finalprice > 450000)
                {
                    return 450000;
                }

                return finalprice;

            }
            else
            {
                // Handle the case where dateTime is null
                // You might throw an exception, provide a default value, or handle it differently based on your requirements.
                throw new ArgumentException("DateTime must have a value.");
            }
        }


        public List<decimal> GetArea(TypesToGetAreaDto typesToGetArea)
        {
            List<decimal> data = new List<decimal>();
            if (typesToGetArea.Type == 0 || typesToGetArea.Type == 10
                
                || typesToGetArea.Type == 18
                || typesToGetArea.Type == 19 ||
                typesToGetArea.Type == 4)
            {
                data.Add(typesToGetArea.areaApartent);
                return data;
            }

            if (typesToGetArea.Type == 1 ||
                typesToGetArea.Type == 2)
            {
                if(typesToGetArea.area_gardens != 0 )
                    data.Add(typesToGetArea.area_gardens);

                else
                      data.Add(typesToGetArea.totalAreaBulding);

                return data;
            }
            if (typesToGetArea.Type == 15 || typesToGetArea.Type == 3)
            {
                data.Add(typesToGetArea.areaBulding);
                return data;
            }

           
            if (typesToGetArea.Type == 13)
            {
                if (typesToGetArea.areaApartent != 0 )

                    data.Add(typesToGetArea.areaApartent);
                else
                    data.Add(typesToGetArea.areaBulding);
            }
            return data;
        }
    }
}
