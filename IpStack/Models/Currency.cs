using System.Text.Json.Serialization;

namespace IpStack.Models
{
    public class Currency
    {
        /// <summary>
        /// Returns the 3-letter code of the main currency associated with the IP.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Returns the name of the given currency.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Returns the plural name of the given currency.
        /// </summary>
        public string Plural { get; set; }

        /// <summary>
        /// Returns the symbol letter of the given currency.
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// Returns the native symbol letter of the given currency.
        /// </summary>
        [JsonPropertyName("symbol_native")]
        public string SymbolNative { get; set; }
    }
}
