using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using StarlingBankClient.Utilities;

namespace StarlingBankClient.Models
{
    public class RecurrenceRule : BaseModel 
    {
        // These fields hold the values for the public properties.
        private DateTime startDate;
        private Frequency1Enum frequency;
        private int? interval;
        private int? count;
        private DateTime? untilDate;
        private WeekStartEnum? weekStart;
        private List<DayEnum> days;
        private int? monthDay;
        private int? monthWeek;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("startDate")]
        public DateTime StartDate 
        { 
            get => startDate;
            set 
            {
                startDate = value;
                OnPropertyChanged("StartDate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("frequency", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Frequency1Enum Frequency 
        { 
            get => frequency;
            set 
            {
                frequency = value;
                OnPropertyChanged("Frequency");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("interval")]
        public int? Interval 
        { 
            get => interval;
            set 
            {
                interval = value;
                OnPropertyChanged("Interval");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("count")]
        public int? Count 
        { 
            get => count;
            set 
            {
                count = value;
                OnPropertyChanged("Count");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("untilDate")]
        public DateTime? UntilDate 
        { 
            get => untilDate;
            set 
            {
                untilDate = value;
                OnPropertyChanged("UntilDate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("weekStart", ItemConverterType = typeof(StringValuedEnumConverter))]
        public WeekStartEnum? WeekStart 
        { 
            get => weekStart;
            set 
            {
                weekStart = value;
                OnPropertyChanged("WeekStart");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("days", ItemConverterType = typeof(StringValuedEnumConverter))]
        public List<DayEnum> Days 
        { 
            get => days;
            set 
            {
                days = value;
                OnPropertyChanged("Days");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("monthDay")]
        public int? MonthDay 
        { 
            get => monthDay;
            set 
            {
                monthDay = value;
                OnPropertyChanged("MonthDay");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("monthWeek")]
        public int? MonthWeek 
        { 
            get => monthWeek;
            set 
            {
                monthWeek = value;
                OnPropertyChanged("MonthWeek");
            }
        }
    }
} 