// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Iot.Inputs
{

    public sealed class TopicRuleIotEventArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the AWS IoT Events input.
        /// </summary>
        [Input("inputName", required: true)]
        public Input<string> InputName { get; set; } = null!;

        /// <summary>
        /// Use this to ensure that only one input (message) with a given messageId is processed by an AWS IoT Events detector. 
        /// </summary>
        [Input("messageId")]
        public Input<string>? MessageId { get; set; }

        /// <summary>
        /// The ARN of the IAM role that grants access.
        /// </summary>
        [Input("roleArn", required: true)]
        public Input<string> RoleArn { get; set; } = null!;

        public TopicRuleIotEventArgs()
        {
        }
    }
}
