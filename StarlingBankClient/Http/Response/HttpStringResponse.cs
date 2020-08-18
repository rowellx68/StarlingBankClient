namespace StarlingBankClient.Http.Response
{
    public class HttpStringResponse : HTTPResponse
    {
        /// <summary>
        /// Raw string body of the http response
        /// </summary>
        public string Body { get; set; }
    }
}
