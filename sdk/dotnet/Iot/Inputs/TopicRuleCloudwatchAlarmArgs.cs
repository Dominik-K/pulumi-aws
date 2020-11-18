// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Iot.Inputs
{

    public sealed class TopicRuleCloudwatchAlarmArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The CloudWatch alarm name.
        /// </summary>
        [Input("alarmName", required: true)]
        public Input<string> AlarmName { get; set; } = null!;

        /// <summary>
        /// The IAM role ARN that allows access to the CloudWatch alarm.
        /// </summary>
        [Input("roleArn", required: true)]
        public Input<string> RoleArn { get; set; } = null!;

        /// <summary>
        /// The reason for the alarm change.
        /// </summary>
        [Input("stateReason", required: true)]
        public Input<string> StateReason { get; set; } = null!;

        /// <summary>
        /// The value of the alarm state. Acceptable values are: OK, ALARM, INSUFFICIENT_DATA.
        /// </summary>
        [Input("stateValue", required: true)]
        public Input<string> StateValue { get; set; } = null!;

        public TopicRuleCloudwatchAlarmArgs()
        {
        }
    }
}
