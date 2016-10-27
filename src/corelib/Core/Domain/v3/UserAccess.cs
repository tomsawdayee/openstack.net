namespace net.openstack.Core.Domain.v3
{
    using Newtonsoft.Json;

    /// <summary>
    /// Represents the response to a user authentication.
    /// </summary>
    /// <seealso href="http://docs.openstack.org/api/openstack-identity-service/2.0/content/POST_authenticate_v2.0_tokens_.html">Authenticate (OpenStack Identity Service API v2.0 Reference)</seealso>
    /// <threadsafety static="true" instance="false"/>
    [JsonObject(MemberSerialization.OptIn)]
    public class UserAccess : ExtensibleJsonObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccess"/> class.
        /// </summary>
        /// <remarks>
        /// This constructor is used by the JSON deserializer.
        /// </remarks>
        [JsonConstructor]
        protected UserAccess()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccess"/> class
        /// with the specified token, user, and service catalog.
        /// </summary>
        /// <param name="token">The <see cref="IdentityToken "/>.</param>
        public UserAccess(IdentityToken token)
        {
            Token = token;
        }

        /// <summary>
        /// Gets the <see cref="IdentityToken"/> which allows providers to make authenticated
        /// calls to API methods.
        /// </summary>
        /// <remarks>
        /// The specific manner in which the token is used is provider-specific. Some implementations
        /// pass the token's <see cref="IdentityToken.Id"/> as an HTTP header when requesting a
        /// resource.
        /// </remarks>
        /// <seealso href="http://docs.openstack.org/api/openstack-identity-service/2.0/content/POST_authenticate_v2.0_tokens_.html">Authenticate (OpenStack Identity Service API v2.0 Reference)</seealso>
        [JsonProperty("token")]
        public IdentityToken Token { get; private set; }
    }
}
