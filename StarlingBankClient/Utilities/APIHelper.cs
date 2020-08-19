using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

// ReSharper disable UnusedMember.Global

namespace StarlingBank.Utilities
{
    public static class APIHelper
    {
        //DateTime format to use for parsing and converting dates
        // ReSharper disable once StringLiteralTypo
        public static string DateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

        /// <summary>
        /// JSON Serialization of a given object.
        /// </summary>
        /// <param name="obj">The object to serialize into JSON</param>
        /// <param name="converter">The converter to use for date time conversion</param>
        /// <returns>The serialized Json string representation of the given object</returns>
        public static string JsonSerialize(object obj, JsonConverter converter = null)
        {
            if (null == obj)
                return null;

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            settings.Converters.Add(converter ?? new IsoDateTimeConverter());

            return JsonConvert.SerializeObject(obj, Formatting.None, settings);
        }

        /// <summary>
        /// JSON Deserialization of the given json string.
        /// </summary>
        /// <param name="json">The json string to deserialize</param>
        /// <param name="converter">The converter to use for date time conversion</param>
        /// <typeparam name="T">The type of the object to deserialize into</typeparam>
        /// <returns>The deserialized object</returns>
        public static T JsonDeserialize<T>(string json, JsonConverter converter = null)
        {
            return string.IsNullOrWhiteSpace(json) ? default : JsonConvert.DeserializeObject<T>(json, converter ?? new IsoDateTimeConverter());
        }

        /// <summary>
        /// Replaces template parameters in the given url
        /// </summary>
        /// <param name="queryBuilder">The query url string to replace the template parameters</param>
        /// <param name="parameters">The parameters to replace in the url</param>
        public static void AppendUrlWithTemplateParameters
            (StringBuilder queryBuilder, IEnumerable<KeyValuePair<string, object>> parameters)
        {
            //perform parameter validation
            if (null == queryBuilder)
                throw new ArgumentNullException(nameof(queryBuilder));

            if (null == parameters)
                return;

            //iterate and replace parameters
            foreach (var pair in parameters)
            {
                string replaceValue;

                switch (pair.Value)
                {
                    //load element value as string
                    case null:
                        replaceValue = "";
                        break;
                    case ICollection value:
                        replaceValue = FlattenCollection(value, ArrayDeserialization.None, '/', false);
                        break;
                    case DateTime time:
                        replaceValue = time.ToString(DateTimeFormat);
                        break;
                    case DateTimeOffset offset:
                        replaceValue = offset.ToString(DateTimeFormat);
                        break;
                    default:
                        replaceValue = pair.Value.ToString();
                        break;
                }

                replaceValue = Uri.EscapeUriString(replaceValue);

                //find the template parameter and replace it with its value
                queryBuilder.Replace($"{{{pair.Key}}}", replaceValue);
            }
        }

        /// <summary>
        /// Appends the given set of parameters to the given query string
        /// </summary>
        /// <param name="queryBuilder">The query url string to append the parameters</param>
        /// <param name="parameters">The parameters to append</param>
        /// <param name="arrayDeserializationFormat">Array deserialization format</param>
        /// <param name="separator">The separator</param>
        public static void AppendUrlWithQueryParameters
            (StringBuilder queryBuilder, IEnumerable<KeyValuePair<string, object>> parameters, ArrayDeserialization arrayDeserializationFormat = ArrayDeserialization.UnIndexed, char separator = '&')
        {
            //perform parameter validation
            if (null == queryBuilder)
                throw new ArgumentNullException(nameof(queryBuilder));

            if (null == parameters)
                return;

            //does the query string already has parameters
            var hasParams = (IndexOf(queryBuilder, "?") > 0);

            //iterate and append parameters
            foreach (var pair in parameters)
            {
                //ignore null values
                if (pair.Value == null)
                    continue;

                //if already has parameters, use the &amp; to append new parameters
                queryBuilder.Append((hasParams) ? '&' : '?');

                //indicate that now the query has some params
                hasParams = true;

                string paramKeyValPair;

                switch (pair.Value)
                {
                    //load element value as string
                    case ICollection value:
                        paramKeyValPair = FlattenCollection(value, arrayDeserializationFormat, separator, true, pair.Key);
                        break;
                    case DateTime time:
                        paramKeyValPair = $"{Uri.EscapeDataString(pair.Key)}={time.ToString(DateTimeFormat)}";
                        break;
                    case DateTimeOffset offset:
                        paramKeyValPair = $"{Uri.EscapeDataString(pair.Key)}={offset.ToString(DateTimeFormat)}";
                        break;
                    default:
                        paramKeyValPair = $"{Uri.EscapeDataString(pair.Key)}={Uri.EscapeDataString(pair.Value.ToString())}";
                        break;
                }

                //append keyval pair for current parameter
                queryBuilder.Append(paramKeyValPair);
            }
        }

        /// <summary>
        /// StringBuilder extension method to implement IndexOf functionality.
        /// This does a StringComparison.Ordinal kind of comparison.
        /// </summary>
        /// <param name="stringBuilder">The string builder to find the index in</param>
        /// <param name="strCheck">The string to locate in the string builder</param>
        /// <returns>The index of string inside the string builder</returns>
        private static int IndexOf(StringBuilder stringBuilder, string strCheck)
        {
            if (stringBuilder == null)
                throw new ArgumentNullException(nameof(stringBuilder));

            if (strCheck == null)
                return 0;

            //iterate over the input
            for (var inputCounter = 0; inputCounter < stringBuilder.Length; inputCounter++)
            {
                int matchCounter;

                //attempt to locate a potential match
                for (matchCounter = 0;
                        (matchCounter < strCheck.Length)
                        && (inputCounter + matchCounter < stringBuilder.Length)
                        && (stringBuilder[inputCounter + matchCounter] == strCheck[matchCounter]);
                    matchCounter++)
                {
                }

                //verify the match
                if (matchCounter == strCheck.Length)
                    return inputCounter;
            }

            return -1;
        }

        /// <summary>
        /// Validates and processes the given query Url to clean empty slashes
        /// </summary>
        /// <param name="queryBuilder">The given query Url to process</param>
        /// <returns>Clean Url as string</returns>
        public static string CleanUrl(StringBuilder queryBuilder)
        {
            //convert to immutable string
            var url = queryBuilder.ToString();

            //ensure that the urls are absolute
            var match = Regex.Match(url, "^https?://[^/]+");
            if (!match.Success)
                throw new ArgumentException("Invalid Url format.");

            //remove redundant forward slashes
            var index = url.IndexOf('?');
            var protocol = match.Value;
            var query = url.Substring(protocol.Length, (index == -1 ? url.Length : index) - protocol.Length);
            query = Regex.Replace(query, "//+", "/");
            var parameters = index == -1 ? "" : url.Substring(index);

            //return process url
            return string.Concat(protocol, query, parameters);
        }

        /// <summary>
        /// Used for flattening a collection of objects into a string 
        /// </summary>
        /// <param name="array">Array of elements to flatten</param>
        /// <param name="fmt">Format string to use for array flattening</param>
        /// <param name="separator">Separator to use for string concat</param>
        /// <param name="urlEncode">Whether to Url encode</param>
        /// <param name="key">The key</param>
        /// <returns>Representative string made up of array elements</returns>
        private static string FlattenCollection(ICollection array, ArrayDeserialization fmt, char separator,
            bool urlEncode, string key = "")
        {
            var builder = new StringBuilder();

            string format;
            switch (fmt)
            {
                case ArrayDeserialization.UnIndexed:
                    format = $"{key}[]={{0}}{{1}}";
                    break;
                case ArrayDeserialization.Indexed:
                    format = $"{key}[{{2}}]={{0}}{{1}}";
                    break;
                case ArrayDeserialization.Plain:
                    format = $"{key}={{0}}{{1}}";
                    break;
                case ArrayDeserialization.Csv:
                case ArrayDeserialization.Psv:
                case ArrayDeserialization.Tsv:
                    builder.Append($"{key}=");
                    format = "{0}{1}";
                    break;
                default:
                    format = "{0}{1}";
                    break;
            }

            //append all elements in the array into a string
            var index = 0;
            foreach (var element in array)
                builder.AppendFormat(format, GetElementValue(element, urlEncode), separator, index++);
            //remove the last separator, if appended
            if ((builder.Length > 1) && (builder[builder.Length - 1] == separator))
                builder.Length -= 1;

            return builder.ToString();
        }

        private static string GetElementValue(object element, bool urlEncode)
        {
            string elemValue;

            switch (element)
            {
                //replace null values with empty string to maintain index order
                case null:
                    elemValue = string.Empty;
                    break;
                case DateTime time:
                    elemValue = time.ToString(DateTimeFormat);
                    break;
                case DateTimeOffset offset:
                    elemValue = offset.ToString(DateTimeFormat);
                    break;
                default:
                    elemValue = element.ToString();
                    break;
            }

            if (urlEncode)
                elemValue = Uri.EscapeDataString(elemValue);
            return elemValue;
        }

        public static List<KeyValuePair<string, object>> PrepareFormFieldsFromObject(
            string name, object value, List<KeyValuePair<string, object>> keys = null, PropertyInfo propInfo = null, ArrayDeserialization arrayDeserializationFormat = ArrayDeserialization.UnIndexed)
        {
            keys = keys ?? new List<KeyValuePair<string, object>>();

            if (value == null)
            {
                return keys;
            }

            if (value is Stream)
            {
                keys.Add(new KeyValuePair<string, object>(name,value));
                return keys;
            }

            if (value is JObject jObject)
            {
                var valueAccept = jObject;
                foreach (var property in valueAccept.Properties())
                {
                    var pKey = property.Name;
                    object pValue = property.Value;
                    var fullSubName = name + '[' + pKey + ']';
                    PrepareFormFieldsFromObject(fullSubName, pValue, keys, propInfo,arrayDeserializationFormat);
                }
            }
            else if (value is IList list)
            {
                var enumerator = list.GetEnumerator();

                var hasNested = false;
                while (enumerator.MoveNext())
                {
                    var subValue = enumerator.Current;
                    var ns = subValue.GetType().Namespace;
                    if (ns != null && (subValue != null && (subValue is JObject || subValue is IList || subValue is IDictionary || !(ns.StartsWith("System")))))
                    {
                        hasNested = true;
                        break;
                    }
                }

                var i = 0;
                enumerator.Reset();
                while (enumerator.MoveNext())
                {
                    var fullSubName = name + '[' + i + ']';
                    if (!hasNested && arrayDeserializationFormat == ArrayDeserialization.UnIndexed)
                        fullSubName = name + "[]";
                    else if (!hasNested && arrayDeserializationFormat == ArrayDeserialization.Plain)
                        fullSubName = name;
                    
                    var subValue = enumerator.Current;
                    if (subValue == null) continue;
                    PrepareFormFieldsFromObject(fullSubName, subValue, keys, propInfo,arrayDeserializationFormat);
                    i++;
                }
            }
            else if (value is JToken)
            {
                keys.Add(new KeyValuePair<string, object>(name, value.ToString()));
            }
            else if (value is Enum)
            {
                var thisAssembly = typeof(APIHelper).GetTypeInfo().Assembly;
                var enumTypeName = value.GetType().FullName;
                var enumHelperType = thisAssembly.GetType($"{enumTypeName}Helper");
                object enumValue = (int) value;

                if (enumHelperType != null)
                {
                    //this enum has an associated helper, use that to load the value
                    var enumHelperMethod = enumHelperType.GetRuntimeMethod("ToValue", new[] { value.GetType() });
                    if (enumHelperMethod != null)
                        enumValue = enumHelperMethod.Invoke(null, new[] {value});
                }

                keys.Add(new KeyValuePair<string, object>(name, enumValue));
            }
            else if (value is IDictionary obj)
            {
                foreach (var sName in obj.Keys)
                {
                    var subName = sName.ToString();
                    var subValue = obj[subName];
                    var fullSubName = string.IsNullOrWhiteSpace(name) ? subName : name + '[' + subName + ']';
                    PrepareFormFieldsFromObject(fullSubName, subValue, keys, propInfo,arrayDeserializationFormat);
                }
            }
            else
            {
                var ns = value.GetType().Namespace;
                if (ns != null && !(ns.StartsWith("System")))
                {
                    //Custom object Iterate through its properties

                    using (var enumerator = value.GetType().GetRuntimeProperties().GetEnumerator())
                    {
                        var t = new JsonPropertyAttribute().GetType();
                        while (enumerator.MoveNext())
                        {
                            var pInfo = enumerator.Current;

                            var jsonProperty = (JsonPropertyAttribute) pInfo.GetCustomAttributes(t, true).FirstOrDefault();
                            var subName = (jsonProperty != null) ? jsonProperty.PropertyName : pInfo.Name;
                            var fullSubName = string.IsNullOrWhiteSpace(name) ? subName : name + '[' + subName + ']';
                            var subValue = pInfo.GetValue(value, null);
                            PrepareFormFieldsFromObject(fullSubName, subValue, keys, pInfo,arrayDeserializationFormat);
                        }
                    }
                }
                else if (value is DateTime time)
                {
                    string convertedValue = null;
                    object[] pInfo = null;

                    if(propInfo!=null)
                        pInfo = propInfo.GetCustomAttributes(true);
                    if (pInfo != null)
                    {
                        foreach (var attr in pInfo)
                        {
                            if (attr is JsonConverterAttribute converterAttr)
                                convertedValue =
                                    JsonSerialize(time,
                                        (JsonConverter)
                                        Activator.CreateInstance(converterAttr.ConverterType,
                                            converterAttr.ConverterParameters)).Replace("\"", "");
                        }
                    }
                    keys.Add(new KeyValuePair<string, object>(name, (convertedValue) ?? time.ToString(DateTimeFormat))); 
                }
                else
                {
                    keys.Add(new KeyValuePair<string, object>(name,value));
                }
            }

            return keys;
        }

        /// <summary>
        /// Add/update entries with the new dictionary.
        /// </summary>
        /// <param name="dictionary"></param>
        /// <param name="dictionary2"></param>
        public static void Add(this Dictionary<string, object> dictionary, Dictionary<string, object> dictionary2)
        {
            foreach (var kvp in dictionary2)
            {
                dictionary[kvp.Key] = kvp.Value;
            }
        }

        /// <summary>
        /// Runs asynchronous tasks synchronously and throws the first caught exception
        /// </summary>
        /// <param name="t">The task to be run synchronously</param>
        public static void RunTaskSynchronously(Task t)
        {
            try
            {
                Task.WaitAll(t);
            }
            catch (AggregateException e)
            {
                if (e.InnerExceptions.Count > 0)
                    throw e.InnerExceptions[0];
                throw;
            }
        }

        public static Dictionary<string, string> GetRequestHeaders(bool includeOAuthToken = true, bool excludeAcceptHeader = false)
        {
            Dictionary<string, string> headers;
            if (excludeAcceptHeader)
            {
                headers = new Dictionary<string, string>
                {
                    {"user-agent", "Starling Bank C# Client"}
                };
            }
            else
            {
                headers = new Dictionary<string, string>
                {
                    {"user-agent", "Starling Bank C# Client"},
                    {"accept", "application/json"}
                };
            }
            if (includeOAuthToken)
            {
                headers.Add("Authorization", $"Bearer {Configuration.OAuthAccessToken}");
            }
            return headers;
        }

        public static Dictionary<string, string> GetContentRequestHeaders(bool includeOAuthToken = true, bool includeAcceptType = false)
        {
            Dictionary<string, string> headers;
            if (includeAcceptType)
            {
                headers = new Dictionary<string, string>
                {
                    { "user-agent", "Starling Bank C# Client"},
                    { "accept", "application/json" },
                    { "content-type", "application/json; charset=utf-8" }
                };
            }
            else
            {
                headers = new Dictionary<string, string>
                {
                    { "user-agent", "Starling Bank C# Client"},
                    { "content-type", "application/json; charset=utf-8" }
                };
            }
            if (includeOAuthToken)
            {
                headers.Add("Authorization", $"Bearer {Configuration.OAuthAccessToken}");
            }
            return headers;
        }
    }
}
