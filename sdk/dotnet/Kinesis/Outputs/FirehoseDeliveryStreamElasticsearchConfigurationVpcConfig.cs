// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Kinesis.Outputs
{

    [OutputType]
    public sealed class FirehoseDeliveryStreamElasticsearchConfigurationVpcConfig
    {
        /// <summary>
        /// The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary [IAM permissions](https://docs.aws.amazon.com/firehose/latest/dev/controlling-access.html#using-iam-es-vpc)
        /// </summary>
        public readonly string RoleArn;
        /// <summary>
        /// A list of security group IDs to associate with Kinesis Firehose.
        /// </summary>
        public readonly ImmutableArray<string> SecurityGroupIds;
        /// <summary>
        /// A list of subnet IDs to associate with Kinesis Firehose.
        /// </summary>
        public readonly ImmutableArray<string> SubnetIds;
        public readonly string? VpcId;

        [OutputConstructor]
        private FirehoseDeliveryStreamElasticsearchConfigurationVpcConfig(
            string roleArn,

            ImmutableArray<string> securityGroupIds,

            ImmutableArray<string> subnetIds,

            string? vpcId)
        {
            RoleArn = roleArn;
            SecurityGroupIds = securityGroupIds;
            SubnetIds = subnetIds;
            VpcId = vpcId;
        }
    }
}
