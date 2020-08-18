using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum FeedItemAttachmentTypeEnum
    {
        IMAGE, //TODO: Write general description for this method
        PDF, //TODO: Write general description for this method
        ENUM_IMAGE_PDF, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type FeedItemAttachmentTypeEnum
    /// </summary>
    public static class FeedItemAttachmentTypeEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "IMAGE", "PDF", "IMAGE, PDF" };

        /// <summary>
        /// Converts a FeedItemAttachmentTypeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The FeedItemAttachmentTypeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(FeedItemAttachmentTypeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case FeedItemAttachmentTypeEnum.IMAGE:
                case FeedItemAttachmentTypeEnum.PDF:
                case FeedItemAttachmentTypeEnum.ENUM_IMAGE_PDF:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of FeedItemAttachmentTypeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of FeedItemAttachmentTypeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<FeedItemAttachmentTypeEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into FeedItemAttachmentTypeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed FeedItemAttachmentTypeEnum value</returns>
        public static FeedItemAttachmentTypeEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type FeedItemAttachmentTypeEnum");

            return (FeedItemAttachmentTypeEnum) index;
        }
    }
} 