namespace Odry.CoindarAPI
{
    public class Authenticator
    {
        private ApiWebClient ApiWebClient { get; set; }

        internal Authenticator(ApiWebClient apiWebClient)
        {
            ApiWebClient = apiWebClient;
        }
    }
}
