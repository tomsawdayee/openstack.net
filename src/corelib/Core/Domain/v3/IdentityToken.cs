namespace net.openstack.Core.Domain.v3
{
    using System;
    using System.Collections.Generic;
    using net.openstack.Core.Providers;
    using Newtonsoft.Json;

    /// <summary>
    /// Represents the authentication token used for making authenticated calls to
    /// multiple APIs.
    /// </summary>
    /// <threadsafety static="true" instance="false"/>
    [JsonObject(MemberSerialization.OptIn)]
    public class IdentityToken : ExtensibleJsonObject
    {

        /// <summary>
        /// Gets the "methods" property for the user.
        /// <note type="warning">The value of this property is not defined. Do not use.</note>
        /// </summary>
        [JsonProperty("methods")]
        public string[] Methods { get; private set; }


        /// <summary>
        /// Gets the "roles" property for the user.
        /// <note type="warning">The value of this property is not defined. Do not use.</note>
        /// </summary>
        [JsonProperty("roles")]
        public Role[] Roles { get; private set; }


        /// <summary>
        /// Gets the token expiration time in the format originally returned by the
        /// authentication response.
        /// </summary>
        /// <seealso cref="net.openstack.Core.Providers.v3.IIdentityProvider.GetToken"/>
        [JsonProperty("expires_at")]
        public string Expires { get; private set; }

        /// <summary>
        /// Gets the token ID which can be used to make authenticated API calls.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets a <see cref="Tenant"/> object containing the name and ID of the
        /// tenant (or account) for the authenticated credentials.
        /// </summary>
        [JsonProperty("tenant")]
        public Tenant Tenant { get; private set; }

        /// <summary>
        /// Gets the services which may be accessed by this user.
        /// </summary>
        /// <seealso href="http://docs.openstack.org/api/openstack-identity-service/2.0/content/POST_authenticate_v2.0_tokens_.html">Authenticate (OpenStack Identity Service API v2.0 Reference)</seealso>
        [JsonProperty("catalog")]
        public ServiceCatalog[] ServiceCatalog { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extras")]
        public object Extras { get; private set; }


        /// <summary>
        /// Gets the details for the authenticated user, such as the username and roles.
        /// </summary>
        /// <seealso href="http://docs.openstack.org/api/openstack-identity-service/2.0/content/POST_authenticate_v2.0_tokens_.html">Authenticate (OpenStack Identity Service API v2.0 Reference)</seealso>
        [JsonProperty("user")]
        public UserDetails User { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("audit_ids")]
        public string[] AuditIds { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("issued_at")]
        public string IssuedAt { get; private set; }


        /// <summary>
        /// Gets whether or not the token has expired. This property simply checks
        /// the <see cref="Expires"/> property against the current system time.
        /// If the <see cref="Expires"/> value is missing or not in a recognized
        /// format, the token is assumed to have expired.
        /// </summary>
        /// <value><see langword="true"/> if the token has expired; otherwise, <see langword="false"/>.</value>
        public bool IsExpired
        {
            get
            {
                DateTimeOffset expiration;
                if (!DateTimeOffset.TryParse(Expires, out expiration))
                    return true;

                return expiration <= DateTimeOffset.Now;
            }
        }

        /// <summary>
        /// Gets a Collection of <see cref="AuthenticationType"/> objects representing the ways the 
        /// user has authenticated.
        /// </summary>
        /// <preliminary/>
        [JsonProperty("RAX-AUTH:authenticatedBy", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<AuthenticationType> AuthenticationTypes { get; private set; } 
    }
}
