// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.LB.Inputs
{

    public sealed class TargetGroupHealthCheckArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Boolean to enable / disable `stickiness`. Default is `true`
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The number of consecutive health checks successes required before considering an unhealthy target healthy. Defaults to 3.
        /// </summary>
        [Input("healthyThreshold")]
        public Input<int>? HealthyThreshold { get; set; }

        /// <summary>
        /// The approximate amount of time, in seconds, between health checks of an individual target. Minimum value 5 seconds, Maximum value 300 seconds. For `lambda` target groups, it needs to be greater as the `timeout` of the underlying `lambda`. Default 30 seconds.
        /// </summary>
        [Input("interval")]
        public Input<int>? Interval { get; set; }

        /// <summary>
        /// The HTTP codes to use when checking for a successful response from a target. You can specify multiple values (for example, "200,202") or a range of values (for example, "200-299"). Applies to Application Load Balancers only (HTTP/HTTPS), not Network Load Balancers (TCP).
        /// </summary>
        [Input("matcher")]
        public Input<string>? Matcher { get; set; }

        /// <summary>
        /// The destination for the health check request. Applies to only HTTP/HTTPS.
        /// </summary>
        [Input("path")]
        public Input<string>? Path { get; set; }

        /// <summary>
        /// The port on which targets receive traffic, unless overridden when registering a specific target. Required when `target_type` is `instance` or `ip`. Does not apply when `target_type` is `lambda`.
        /// </summary>
        [Input("port")]
        public Input<string>? Port { get; set; }

        /// <summary>
        /// The protocol to use for routing traffic to the targets. Should be one of `GENEVE`, `HTTP`, `HTTPS`, `TCP`, `TCP_UDP`, `TLS`, or `UDP`. Required when `target_type` is `instance` or `ip`. Does not apply when `target_type` is `lambda`.
        /// </summary>
        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        /// <summary>
        /// The amount of time, in seconds, during which no response means a failed health check. For Application Load Balancers, the range is 2 to 120 seconds, and the default is 5 seconds for the `instance` target type and 30 seconds for the `lambda` target type. For Network Load Balancers, you cannot set a custom value, and the default is 10 seconds for TCP and HTTPS health checks and 6 seconds for HTTP health checks.
        /// </summary>
        [Input("timeout")]
        public Input<int>? Timeout { get; set; }

        /// <summary>
        /// The number of consecutive health check failures required before considering the target unhealthy . For Network Load Balancers, this value must be the same as the `healthy_threshold`. Defaults to 3.
        /// </summary>
        [Input("unhealthyThreshold")]
        public Input<int>? UnhealthyThreshold { get; set; }

        public TargetGroupHealthCheckArgs()
        {
        }
    }
}
