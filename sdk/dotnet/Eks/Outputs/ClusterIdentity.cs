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
    public sealed class ClusterIdentity
    {
        /// <summary>
        /// Nested attribute containing [OpenID Connect](https://openid.net/connect/) identity provider information for the cluster.
        /// </summary>
        public readonly ImmutableArray<Outputs.ClusterIdentityOidc> Oidcs;

        [OutputConstructor]
        private ClusterIdentity(ImmutableArray<Outputs.ClusterIdentityOidc> oidcs)
        {
            Oidcs = oidcs;
        }
    }
}
