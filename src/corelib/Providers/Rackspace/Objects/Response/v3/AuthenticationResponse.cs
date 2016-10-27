namespace net.openstack.Providers.Rackspace.Objects.Response.v3
{
    using net.openstack.Core.Domain.v3;
    using Newtonsoft.Json;

    /// <summary>
    /// This models the JSON response used for the Authenticate request.
    /// </summary>
    /// <seealso href="http://docs.openstack.org/api/openstack-identity-service/2.0/content/POST_authenticate_v2.0_tokens_.html">Authenticate (OpenStack Identity Service API v2.0 Reference)</seealso>
    /// <threadsafety static="true" instance="false"/>
    [JsonObject(MemberSerialization.OptIn)]
    internal class AuthenticationResponse
    {
        /// <summary>
        /// Gets additional information about the authenticated user.
        /// </summary>
        /// <seealso cref="UserAccess"/>
        [JsonProperty("token")]
        public UserAccess UserAccess { get; private set; }
    }
}
