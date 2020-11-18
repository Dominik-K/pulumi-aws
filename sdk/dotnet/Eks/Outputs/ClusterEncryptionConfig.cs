// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Eks.Outputs
{

    [OutputType]
    public sealed class ClusterEncryptionConfig
    {
        /// <summary>
        /// Configuration block with provider for encryption. Detailed below.
        /// </summary>
        public readonly Outputs.ClusterEncryptionConfigProvider Provider;
        /// <summary>
        /// List of strings with resources to be encrypted. Valid values: `secrets`
        /// </summary>
        public readonly ImmutableArray<string> Resources;

        [OutputConstructor]
        private ClusterEncryptionConfig(
            Outputs.ClusterEncryptionConfigProvider provider,

            ImmutableArray<string> resources)
        {
            Provider = provider;
            Resources = resources;
        }
    }
}
