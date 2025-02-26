// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using System.Linq;

    public partial class MongoDBCollectionGetPropertiesResource
    {
        /// <summary>
        /// Initializes a new instance of the MongoDBCollectionGetPropertiesResource class.
        /// </summary>
        public MongoDBCollectionGetPropertiesResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MongoDBCollectionGetPropertiesResource class.
        /// </summary>

        /// <param name="id">Name of the Cosmos DB MongoDB collection
        /// </param>

        /// <param name="shardKey">A key-value pair of shard keys to be applied for the request.
        /// </param>

        /// <param name="indexes">List of index keys
        /// </param>

        /// <param name="analyticalStorageTtl">Analytical TTL.
        /// </param>

        /// <param name="rid">A system generated property. A unique identifier.
        /// </param>

        /// <param name="ts">A system generated property that denotes the last updated timestamp of the
        /// resource.
        /// </param>

        /// <param name="etag">A system generated property representing the resource etag required for
        /// optimistic concurrency control.
        /// </param>
        public MongoDBCollectionGetPropertiesResource(string id, System.Collections.Generic.IDictionary<string, string> shardKey = default(System.Collections.Generic.IDictionary<string, string>), System.Collections.Generic.IList<MongoIndex> indexes = default(System.Collections.Generic.IList<MongoIndex>), int? analyticalStorageTtl = default(int?), string rid = default(string), double? ts = default(double?), string etag = default(string))

        {
            this.Id = id;
            this.ShardKey = shardKey;
            this.Indexes = indexes;
            this.AnalyticalStorageTtl = analyticalStorageTtl;
            this.Rid = rid;
            this.Ts = ts;
            this.Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets name of the Cosmos DB MongoDB collection
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id {get; set; }

        /// <summary>
        /// Gets or sets a key-value pair of shard keys to be applied for the request.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "shardKey")]
        public System.Collections.Generic.IDictionary<string, string> ShardKey {get; set; }

        /// <summary>
        /// Gets or sets list of index keys
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "indexes")]
        public System.Collections.Generic.IList<MongoIndex> Indexes {get; set; }

        /// <summary>
        /// Gets or sets analytical TTL.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "analyticalStorageTtl")]
        public int? AnalyticalStorageTtl {get; set; }

        /// <summary>
        /// Gets a system generated property. A unique identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "_rid")]
        public string Rid {get; private set; }

        /// <summary>
        /// Gets a system generated property that denotes the last updated timestamp of
        /// the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "_ts")]
        public double? Ts {get; private set; }

        /// <summary>
        /// Gets a system generated property representing the resource etag required
        /// for optimistic concurrency control.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "_etag")]
        public string Etag {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Id == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Id");
            }





        }
    }
}