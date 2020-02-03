namespace Be.Vlaanderen.Basisregisters.GrAr.Legacy
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// De geografische naam.
    /// </summary>
    [DataContract(Name = "GeografischeNaam", Namespace = "")]
    public class GeografischeNaam
    {
        /// <summary>
        /// De spelling van de geografische naam in de gespecifieerde taal.
        /// </summary>
        [DataMember(Name = "Spelling", Order = 1)]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Spelling { get; set; }

        /// <summary>
        /// De taal van de geografische naam.
        /// </summary>
        [DataMember(Name = "Taal", Order = 2)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Taal Taal { get; set; }

        public GeografischeNaam(string spelling, Taal taalCode)
        {
            Spelling = spelling;
            Taal = taalCode;
        }
    }
}
