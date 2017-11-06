using Newtonsoft.Json;
using System;

namespace Odry.CoindarAPI.EventTools
{
    public class Event : IEvent
    {
        [JsonProperty("caption")]
        private string CaptionVal
        {
            set { Caption = value; }
        }
        public string Caption { get; private set; }

        [JsonProperty("proof")]
        private string ProofVal
        {
            set { Proof = value; }
        }

        public string Proof { get; private set; }

        [JsonProperty("caption_ru")]
        private string CaptionRuVal
        {
            set { CaptionRu = value; }
        }

        public string CaptionRu { get; private set; }

        [JsonProperty("proof_ru")]
        private string ProofRuVal
        {
            set { ProofRu = value; }
        }

        public string ProofRu { get; private set; }

        [JsonProperty("public_date")]
        private string PublicDateVal
        {
            set { PublicDate = Helper.ParseDateTime(value); }
        }

        public DateTime PublicDate { get; private set; }

        [JsonProperty("start_date")]
        private string StartDateVal
        {
            set { StartDate = value; }
        }

        public string StartDate { get; private set; }

        [JsonProperty("end_date")]
        private string EndDateVal
        {
            set { EndDate = value; }
        }

        public string EndDate { get; private set; }

        [JsonProperty("coin_name")]
        private string CoinNameVal
        {
            set { CoinName = value; }
        }

        public string CoinName { get; private set; }

        [JsonProperty("coin_symbol")]
        private string CoinSymbolVal
        {
            set { CoinSymbol = value; }
        }

        public string CoinSymbol { get; private set; }
    }
}
