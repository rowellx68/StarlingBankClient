using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum AttachmentTypeEnum
    {
        ENUM_IMAGE_PDF, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type AttachmentTypeEnum
    /// </summary>
    public static class AttachmentTypeEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "image, pdf" };

        /// <summary>
        /// Converts a AttachmentTypeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The AttachmentTypeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(AttachmentTypeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case AttachmentTypeEnum.ENUM_IMAGE_PDF:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of AttachmentTypeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of AttachmentTypeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<AttachmentTypeEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into AttachmentTypeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed AttachmentTypeEnum value</returns>
        public static AttachmentTypeEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type AttachmentTypeEnum");

            return (AttachmentTypeEnum) index;
        }
    }
} 