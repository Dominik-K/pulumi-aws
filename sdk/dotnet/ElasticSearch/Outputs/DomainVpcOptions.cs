// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.ElasticSearch.Outputs
{

    [OutputType]
    public sealed class DomainVpcOptions
    {
        public readonly ImmutableArray<string> AvailabilityZones;
        /// <summary>
        /// List of VPC Security Group IDs to be applied to the Elasticsearch domain endpoints. If omitted, the default Security Group for the VPC will be used.
        /// </summary>
        public readonly ImmutableArray<string> SecurityGroupIds;
        /// <summary>
        /// List of VPC Subnet IDs for the Elasticsearch domain endpoints to be created in.
        /// </summary>
        public readonly ImmutableArray<string> SubnetIds;
        public readonly string? VpcId;

        [OutputConstructor]
        private DomainVpcOptions(
            ImmutableArray<string> availabilityZones,

            ImmutableArray<string> securityGroupIds,

            ImmutableArray<string> subnetIds,

            string? vpcId)
        {
            AvailabilityZones = availabilityZones;
            SecurityGroupIds = securityGroupIds;
            SubnetIds = subnetIds;
            VpcId = vpcId;
        }
    }
}
