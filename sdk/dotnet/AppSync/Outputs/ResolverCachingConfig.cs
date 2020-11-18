// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppSync.Outputs
{

    [OutputType]
    public sealed class ResolverCachingConfig
    {
        /// <summary>
        /// The list of caching key.
        /// </summary>
        public readonly ImmutableArray<string> CachingKeys;
        /// <summary>
        /// The TTL in seconds.
        /// </summary>
        public readonly int? Ttl;

        [OutputConstructor]
        private ResolverCachingConfig(
            ImmutableArray<string> cachingKeys,

            int? ttl)
        {
            CachingKeys = cachingKeys;
            Ttl = ttl;
        }
    }
}
