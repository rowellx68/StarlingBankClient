using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum BusinessCategoryEnum
    {
        NOT_PROVIDED, //TODO: Write general description for this method
        ARTS_CRAFTS_AND_COLLECTIBLES, //TODO: Write general description for this method
        BABY, //TODO: Write general description for this method
        BEAUTY_AND_FRAGRANCES, //TODO: Write general description for this method
        BOOKS_AND_MAGAZINES, //TODO: Write general description for this method
        BUSINESS_TO_BUSINESS, //TODO: Write general description for this method
        CLOTHING_ACCESSORIES_AND_SHOES, //TODO: Write general description for this method
        COMPUTERS_ACCESSORIES_AND_SERVICES, //TODO: Write general description for this method
        EDUCATION, //TODO: Write general description for this method
        ELECTRONICS_AND_TELECOM, //TODO: Write general description for this method
        ENTERTAINMENT_AND_MEDIA, //TODO: Write general description for this method
        FINANCIAL_SERVICES_AND_PRODUCTS, //TODO: Write general description for this method
        FOOD_RETAIL_AND_SERVICE, //TODO: Write general description for this method
        GIFTS_AND_FLOWERS, //TODO: Write general description for this method
        HEALTH_AND_PERSONAL_CARE, //TODO: Write general description for this method
        HOME_AND_GARDEN, //TODO: Write general description for this method
        NONPROFIT, //TODO: Write general description for this method
        PETS_AND_ANIMALS, //TODO: Write general description for this method
        RELIGION_AND_SPIRITUALITY_FOR_PROFIT, //TODO: Write general description for this method
        RETAIL_NOT_ELSEWHERE_CLASSIFIED, //TODO: Write general description for this method
        SERVICES_OTHER, //TODO: Write general description for this method
        SPORTS_AND_OUTDOORS, //TODO: Write general description for this method
        TOYS_AND_HOBBIES, //TODO: Write general description for this method
        TRAVEL, //TODO: Write general description for this method
        VEHICLE_SERVICE_AND_ACCESSORIES, //TODO: Write general description for this method
        PROFESSIONAL_SERVICES, //TODO: Write general description for this method
        RETAIL_BARS_AND_RESTAURANTS, //TODO: Write general description for this method
        ENTERTAINMENT_AND_TRAVEL, //TODO: Write general description for this method
        HEALTH_AND_SOCIAL_CARE, //TODO: Write general description for this method
        TRANSPORT_AND_VEHICLES, //TODO: Write general description for this method
        CONSTRUCTION_TRADES_AND_CLEANING, //TODO: Write general description for this method
        PROPERTY, //TODO: Write general description for this method
        EXERCISE_AND_FITNESS, //TODO: Write general description for this method
        EDUCATION_AND_SKILLS, //TODO: Write general description for this method
        NON_PROFIT1, //TODO: Write general description for this method
        MANUFACTURING_RND_AND_AGRICULTURE, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type BusinessCategoryEnum
    /// </summary>
    public static class BusinessCategoryEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "NOT_PROVIDED", "ARTS_CRAFTS_AND_COLLECTIBLES", "BABY", "BEAUTY_AND_FRAGRANCES", "BOOKS_AND_MAGAZINES", "BUSINESS_TO_BUSINESS", "CLOTHING_ACCESSORIES_AND_SHOES", "COMPUTERS_ACCESSORIES_AND_SERVICES", "EDUCATION", "ELECTRONICS_AND_TELECOM", "ENTERTAINMENT_AND_MEDIA", "FINANCIAL_SERVICES_AND_PRODUCTS", "FOOD_RETAIL_AND_SERVICE", "GIFTS_AND_FLOWERS", "HEALTH_AND_PERSONAL_CARE", "HOME_AND_GARDEN", "NONPROFIT", "PETS_AND_ANIMALS", "RELIGION_AND_SPIRITUALITY_FOR_PROFIT", "RETAIL_NOT_ELSEWHERE_CLASSIFIED", "SERVICES_OTHER", "SPORTS_AND_OUTDOORS", "TOYS_AND_HOBBIES", "TRAVEL", "VEHICLE_SERVICE_AND_ACCESSORIES", "PROFESSIONAL_SERVICES", "RETAIL_BARS_AND_RESTAURANTS", "ENTERTAINMENT_AND_TRAVEL", "HEALTH_AND_SOCIAL_CARE", "TRANSPORT_AND_VEHICLES", "CONSTRUCTION_TRADES_AND_CLEANING", "PROPERTY", "EXERCISE_AND_FITNESS", "EDUCATION_AND_SKILLS", "NON_PROFIT", "MANUFACTURING_RND_AND_AGRICULTURE" };

        /// <summary>
        /// Converts a BusinessCategoryEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The BusinessCategoryEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(BusinessCategoryEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case BusinessCategoryEnum.NOT_PROVIDED:
                case BusinessCategoryEnum.ARTS_CRAFTS_AND_COLLECTIBLES:
                case BusinessCategoryEnum.BABY:
                case BusinessCategoryEnum.BEAUTY_AND_FRAGRANCES:
                case BusinessCategoryEnum.BOOKS_AND_MAGAZINES:
                case BusinessCategoryEnum.BUSINESS_TO_BUSINESS:
                case BusinessCategoryEnum.CLOTHING_ACCESSORIES_AND_SHOES:
                case BusinessCategoryEnum.COMPUTERS_ACCESSORIES_AND_SERVICES:
                case BusinessCategoryEnum.EDUCATION:
                case BusinessCategoryEnum.ELECTRONICS_AND_TELECOM:
                case BusinessCategoryEnum.ENTERTAINMENT_AND_MEDIA:
                case BusinessCategoryEnum.FINANCIAL_SERVICES_AND_PRODUCTS:
                case BusinessCategoryEnum.FOOD_RETAIL_AND_SERVICE:
                case BusinessCategoryEnum.GIFTS_AND_FLOWERS:
                case BusinessCategoryEnum.HEALTH_AND_PERSONAL_CARE:
                case BusinessCategoryEnum.HOME_AND_GARDEN:
                case BusinessCategoryEnum.NONPROFIT:
                case BusinessCategoryEnum.PETS_AND_ANIMALS:
                case BusinessCategoryEnum.RELIGION_AND_SPIRITUALITY_FOR_PROFIT:
                case BusinessCategoryEnum.RETAIL_NOT_ELSEWHERE_CLASSIFIED:
                case BusinessCategoryEnum.SERVICES_OTHER:
                case BusinessCategoryEnum.SPORTS_AND_OUTDOORS:
                case BusinessCategoryEnum.TOYS_AND_HOBBIES:
                case BusinessCategoryEnum.TRAVEL:
                case BusinessCategoryEnum.VEHICLE_SERVICE_AND_ACCESSORIES:
                case BusinessCategoryEnum.PROFESSIONAL_SERVICES:
                case BusinessCategoryEnum.RETAIL_BARS_AND_RESTAURANTS:
                case BusinessCategoryEnum.ENTERTAINMENT_AND_TRAVEL:
                case BusinessCategoryEnum.HEALTH_AND_SOCIAL_CARE:
                case BusinessCategoryEnum.TRANSPORT_AND_VEHICLES:
                case BusinessCategoryEnum.CONSTRUCTION_TRADES_AND_CLEANING:
                case BusinessCategoryEnum.PROPERTY:
                case BusinessCategoryEnum.EXERCISE_AND_FITNESS:
                case BusinessCategoryEnum.EDUCATION_AND_SKILLS:
                case BusinessCategoryEnum.NON_PROFIT1:
                case BusinessCategoryEnum.MANUFACTURING_RND_AND_AGRICULTURE:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of BusinessCategoryEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of BusinessCategoryEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<BusinessCategoryEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into BusinessCategoryEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed BusinessCategoryEnum value</returns>
        public static BusinessCategoryEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type BusinessCategoryEnum");

            return (BusinessCategoryEnum) index;
        }
    }
} 