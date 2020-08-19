using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class TaxLiabilityDeclaration : BaseModel 
    {
        // These fields hold the values for the public properties.
        private TaxLiabilityDeclarationAnswerEnum taxLiabilityDeclarationAnswer;
        private UsTaxLiabilityDeclarationAnswerEnum usTaxLiabilityDeclarationAnswer;
        private List<TaxLiabilityDeclarationCountry> taxLiabilityDeclarationCountries;

        /// <summary>
        /// Is the account holder liable for tax
        /// </summary>
        [JsonProperty("taxLiabilityDeclarationAnswer", ItemConverterType = typeof(StringValuedEnumConverter))]
        public TaxLiabilityDeclarationAnswerEnum TaxLiabilityDeclarationAnswer 
        { 
            get => taxLiabilityDeclarationAnswer;
            set 
            {
                taxLiabilityDeclarationAnswer = value;
                OnPropertyChanged("TaxLiabilityDeclarationAnswer");
            }
        }

        /// <summary>
        /// Is the account holder liable for tax in the US
        /// </summary>
        [JsonProperty("usTaxLiabilityDeclarationAnswer", ItemConverterType = typeof(StringValuedEnumConverter))]
        public UsTaxLiabilityDeclarationAnswerEnum UsTaxLiabilityDeclarationAnswer 
        { 
            get => usTaxLiabilityDeclarationAnswer;
            set 
            {
                usTaxLiabilityDeclarationAnswer = value;
                OnPropertyChanged("UsTaxLiabilityDeclarationAnswer");
            }
        }

        /// <summary>
        /// Countries in which account holder has tax liabilities
        /// </summary>
        [JsonProperty("taxLiabilityDeclarationCountries")]
        public List<TaxLiabilityDeclarationCountry> TaxLiabilityDeclarationCountries 
        { 
            get => taxLiabilityDeclarationCountries;
            set 
            {
                taxLiabilityDeclarationCountries = value;
                OnPropertyChanged("TaxLiabilityDeclarationCountries");
            }
        }
    }
} 