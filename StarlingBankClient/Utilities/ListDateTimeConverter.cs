using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

// ReSharper disable UnusedMember.Global

namespace StarlingBank.Utilities
{
    class ListDateTimeConverter : JsonConverter
    {
        public ListDateTimeConverter()
        {
            Converter = new IsoDateTimeConverter();
        }
        public ListDateTimeConverter(Type converter)
        {
            this.Converter = (JsonConverter)Activator.CreateInstance(converter);
        }
        public ListDateTimeConverter(Type converter,string format)
        {
            this.Converter = (JsonConverter)Activator.CreateInstance(converter,format);
        }
        public JsonConverter Converter { get; set; }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Converters.Clear();
            serializer.Converters.Add(Converter);
            serializer.Serialize(writer,value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            serializer.Converters.Clear();
            serializer.Converters.Add(Converter);
            return serializer.Deserialize(reader, objectType);
        }

        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof(List<DateTime>)||objectType == typeof(DateTime) || objectType == typeof(List<DateTimeOffset>)||objectType == typeof(DateTimeOffset))
                return true;
            return false;
        }
    }
}