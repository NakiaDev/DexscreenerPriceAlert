namespace DexscreenerPriceAlert.Classes
{
    public class DexscreenerResponse
    {
        public string schemaVersion { get; set; }
        public DexscreenerPair pair { get; set; }
    }

    public class DexscreenerPair
    {
        public string chainId { get; set; }
        public string url { get; set; }
        public string pairAddress { get; set; }
        public double priceNative { get; set; }
        public double priceUsd { get; set; }
    }
}
