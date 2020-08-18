using System.Collections.Generic;
using System.Text;
using StarlingBankClient.Utilities;

namespace StarlingBankClient
{
    public class Configuration
    {


        public enum Environments
        {
            //PRODUCTION server environment
            PRODUCTION,
            //SANDBOX server environment
            SANDBOX,
        }
        

        //The current environment being used
        public static Environments Environment = Environments.SANDBOX;

        //OAuth 2.0 Access Token
        //TODO: Replace the OAuthAccessToken with an appropriate value
        public static string OAuthAccessToken = "";

        

        /// <summary>
        /// Makes a list of the BaseURL parameters 
        /// </summary>
        /// <return>Returns the parameters list</return>
        internal static List<KeyValuePair<string, object>> GetBaseURIParameters()
        {
            var kvpList = new List<KeyValuePair<string, object>>();
            return kvpList; 
        }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters
        /// </summary>
        /// <return>Returns the base url</return>
        internal static string GetBaseURI()
        {
            var urlBuilder = Environment == Environments.PRODUCTION ? new StringBuilder("https://api.starlingbank.com") : new StringBuilder("https://api-sandbox.starlingbank.com");
            APIHelper.AppendUrlWithTemplateParameters(urlBuilder, GetBaseURIParameters());
            return urlBuilder.ToString();        
        }

        public static string GetOAuthServerURI(bool production)
        {
            return production ? "https://oauth.starlingbank.com" : "https://oauth-sandbox.starlingbank.com";
        }

    }
}