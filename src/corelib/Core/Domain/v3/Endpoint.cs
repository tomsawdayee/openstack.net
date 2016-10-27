namespace net.openstack.Core.Domain.v3
{
    using Newtonsoft.Json;

    /// <summary>
    /// Represents an endpoint for a service provided in the <see cref="ServiceCatalog"/>.
    /// </summary>
    /// <threadsafety static="true" instance="false"/>
    [JsonObject(MemberSerialization.OptIn)]
    public class Endpoint : ExtensibleJsonObject
    {
        /// <summary>
        /// Gets the region where this service endpoint is located. If this is <see langword="null"/>
        /// or empty, the region is not specified.
        /// </summary>
        [JsonProperty("region_id")]
        public string RegionId { get; private set; }

        /// <summary>
        /// Gets the public URL of the service.
        /// </summary>
        [JsonProperty("url")]
        public string PublicURL { get; private set; }

        /// <summary>
        /// Gets the region where this service endpoint is located. If this is <see langword="null"/>
        /// or empty, the region is not specified.
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; private set; }

        /// <summary>
        /// Gets the tenant (or account) ID which this endpoint operates on.
        /// </summary>
        [JsonProperty("interface")]
        public string Interface { get; private set; }

        /// <summary>
        /// Gets the tenant (or account) ID which this endpoint operates on.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

    }
}
