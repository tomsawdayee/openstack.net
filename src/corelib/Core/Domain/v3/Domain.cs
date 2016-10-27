namespace net.openstack.Core.Domain.v3
{
    using System.Diagnostics;
    using Newtonsoft.Json;

    /// <summary>
    /// A personality that a user assumes when performing a specific set of operations. A role
    /// includes a set of right and privileges. A user assuming that role inherits those rights
    /// and privileges.
    /// </summary>
    /// <remarks>
    /// In OpenStack Identity Service, a token that is issued to a user includes the list of
    /// roles that user can assume. Services that are being called by that user determine how
    /// they interpret the set of roles a user has and to which operations or resources each
    /// role grants access.
    /// </remarks>
    /// <threadsafety static="true" instance="false"/>
    [JsonObject(MemberSerialization.OptIn)]
    [DebuggerDisplay("{Name,nq} ({Id, nq})")]
    public class Domain : ExtensibleJsonObject
    {
        /// <summary>
        /// Gets the unique identifier for the role.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the role.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

        /// <summary>
        ///
        /// </summary>
        [JsonConstructor]
        protected Domain()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class with
        /// the specified name and description.
        /// </summary>
        /// <param name="name">The name of the role.</param>
        public Domain(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        public Domain(string name, string id)
        {
            Name = name;
            Id = id;
        }
    }
}