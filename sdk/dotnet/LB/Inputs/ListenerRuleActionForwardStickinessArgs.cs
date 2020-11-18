// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.LB.Inputs
{

    public sealed class ListenerRuleActionForwardStickinessArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The time period, in seconds, during which requests from a client should be routed to the same target group. The range is 1-604800 seconds (7 days).
        /// </summary>
        [Input("duration", required: true)]
        public Input<int> Duration { get; set; } = null!;

        /// <summary>
        /// Indicates whether target group stickiness is enabled.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        public ListenerRuleActionForwardStickinessArgs()
        {
        }
    }
}
