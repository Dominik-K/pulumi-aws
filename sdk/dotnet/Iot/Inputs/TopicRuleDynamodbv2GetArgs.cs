// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Iot.Inputs
{

    public sealed class TopicRuleDynamodbv2GetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configuration block with DynamoDB Table to which the message will be written. Nested arguments below.
        /// </summary>
        [Input("putItem")]
        public Input<Inputs.TopicRuleDynamodbv2PutItemGetArgs>? PutItem { get; set; }

        /// <summary>
        /// The IAM role ARN that allows access to the CloudWatch alarm.
        /// </summary>
        [Input("roleArn", required: true)]
        public Input<string> RoleArn { get; set; } = null!;

        public TopicRuleDynamodbv2GetArgs()
        {
        }
    }
}
