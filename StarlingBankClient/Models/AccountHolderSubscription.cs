using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class AccountHolderSubscription : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? accountHolderUid;
        private Guid? billingAccountUid;
        private BillingAccountCurrencyEnum? billingAccountCurrency;
        private int? billingDay;
        private List<ProductSubscription> productSubscriptions;
        private BillingSummary billingSummary;

        /// <summary>
        /// Unique identifier for account holder
        /// </summary>
        [JsonProperty("accountHolderUid")]
        public Guid? AccountHolderUid 
        { 
            get => accountHolderUid;
            set 
            {
                accountHolderUid = value;
                OnPropertyChanged("AccountHolderUid");
            }
        }

        /// <summary>
        /// Unique identifier for billing account
        /// </summary>
        [JsonProperty("billingAccountUid")]
        public Guid? BillingAccountUid 
        { 
            get => billingAccountUid;
            set 
            {
                billingAccountUid = value;
                OnPropertyChanged("BillingAccountUid");
            }
        }

        /// <summary>
        /// Currency code
        /// </summary>
        [JsonProperty("billingAccountCurrency", ItemConverterType = typeof(StringValuedEnumConverter))]
        public BillingAccountCurrencyEnum? BillingAccountCurrency 
        { 
            get => billingAccountCurrency;
            set 
            {
                billingAccountCurrency = value;
                OnPropertyChanged("BillingAccountCurrency");
            }
        }

        /// <summary>
        /// Billing day
        /// </summary>
        [JsonProperty("billingDay")]
        public int? BillingDay 
        { 
            get => billingDay;
            set 
            {
                billingDay = value;
                OnPropertyChanged("BillingDay");
            }
        }

        /// <summary>
        /// Product subscriptions
        /// </summary>
        [JsonProperty("productSubscriptions")]
        public List<ProductSubscription> ProductSubscriptions 
        { 
            get => productSubscriptions;
            set 
            {
                productSubscriptions = value;
                OnPropertyChanged("ProductSubscriptions");
            }
        }

        /// <summary>
        /// Billing summary
        /// </summary>
        [JsonProperty("billingSummary")]
        public BillingSummary BillingSummary 
        { 
            get => billingSummary;
            set 
            {
                billingSummary = value;
                OnPropertyChanged("BillingSummary");
            }
        }
    }
} 