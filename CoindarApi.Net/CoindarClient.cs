using Odry.CoindarAPI.EventTools;

namespace Odry.CoindarAPI
{
    public sealed class CoindarClient
    {
        /// <summary>Represents the authenticator object of the client.</summary>
        public Authenticator Authenticator { get; private set; }

        /// <summary>Represents the events object.</summary>
        public IEvents Events;


        /// <summary>Creates a new instance of Coindar API .NET's client service.</summary>
        public CoindarClient()
        {
            var apiWebClient = new ApiWebClient(Helper.ApiUrlHttpsBase);

            Authenticator = new Authenticator(apiWebClient);

            Events = new Events(apiWebClient);
        }
    }
}
