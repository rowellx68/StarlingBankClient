using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class AccessToken : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string accessToken;
        private string refreshToken;
        private string tokenType;
        private long? accessTokenExpiresInSeconds;
        private string scope;

        /// <summary>
        /// The access token
        /// </summary>
        [JsonProperty("accessToken")]
        public string AccessTokenProp 
        { 
            get => accessToken;
            set 
            {
                accessToken = value;
                OnPropertyChanged("AccessTokenProp");
            }
        }

        /// <summary>
        /// The refresh token
        /// </summary>
        [JsonProperty("refreshToken")]
        public string RefreshToken 
        { 
            get => refreshToken;
            set 
            {
                refreshToken = value;
                OnPropertyChanged("RefreshToken");
            }
        }

        /// <summary>
        /// The token type, as described in https://tools.ietf.org/html/rfc6749#section-7.1
        /// </summary>
        [JsonProperty("tokenType")]
        public string TokenType 
        { 
            get => tokenType;
            set 
            {
                tokenType = value;
                OnPropertyChanged("TokenType");
            }
        }

        /// <summary>
        /// The time in seconds from issuance at which the access token will expire
        /// </summary>
        [JsonProperty("accessTokenExpiresInSeconds")]
        public long? AccessTokenExpiresInSeconds 
        { 
            get => accessTokenExpiresInSeconds;
            set 
            {
                accessTokenExpiresInSeconds = value;
                OnPropertyChanged("AccessTokenExpiresInSeconds");
            }
        }

        /// <summary>
        /// The scopes which this token has permission to use: Space delimited case sensitive Strings, as described in https://tools.ietf.org/html/rfc6749#section-3.3
        /// </summary>
        [JsonProperty("scope")]
        public string Scope 
        { 
            get => scope;
            set 
            {
                scope = value;
                OnPropertyChanged("Scope");
            }
        }
    }
} 