// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Alb.Outputs
{

    [OutputType]
    public sealed class ListenerRuleActionForwardStickiness
    {
        /// <summary>
        /// The time period, in seconds, during which requests from a client should be routed to the same target group. The range is 1-604800 seconds (7 days).
        /// </summary>
        public readonly int Duration;
        /// <summary>
        /// Indicates whether target group stickiness is enabled.
        /// </summary>
        public readonly bool? Enabled;

        [OutputConstructor]
        private ListenerRuleActionForwardStickiness(
            int duration,

            bool? enabled)
        {
            Duration = duration;
            Enabled = enabled;
        }
    }
}
