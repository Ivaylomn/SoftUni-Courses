using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Infrastructure.Data
{
    public static class DataConstants
    {
        public static class Category
        {
            public const int NameMaxLenght = 50;
        }

        public static class Agent
        {
            public const int PhoneNumberMaxLenght = 15;
            public const int PhoneNumberMinLenght = 7;
        }

        public static class House
        {
            public const int TitleMaxLenght = 50;
            public const int TitleMinLenght = 10;

            public const int AdressMaxLenght = 150;
            public const int AdressMinLenght = 30;

            public const int DescriptionMaxLenght = 500;
            public const int DescriptionMinLenght = 50;

            public const int ImageUrlMaxLenght = 500;

            public const string PricePerMonhtMaxLenght = "2000.0";
            public const string PricePerMonhtMinLenght = "0.0";
        }
    }
}
