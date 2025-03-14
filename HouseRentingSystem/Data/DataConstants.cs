namespace HouseRentingSystem.Data
{
    public class DataConstants
    {
        public class Category
        {
            public const int CategoryMaxName = 50;
        }
        public class House
        {
            public const int HouseTitleMaxLength= 50; 
            public const int HouseTitleMinLength= 10;

            public const int HouseAddressMaxLength = 150;
            public const int HouseAddressMinLength = 30;

            public const int HouseDescriptionMaxLength = 500;
            public const int HouseDescriptionMinLength = 50;

            public const int HousePricePerMonthMax = 2000;
            public const int HousePricePerMonthMin = 0;
        }
        public class Agent
        {
            public const int AgentMaxPhoneNumber = 15;
            public const int AgentMinPhoneNumber = 7;
        }
    }
}
