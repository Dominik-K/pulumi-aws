// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2.Inputs
{

    public sealed class VpnConnectionVgwTelemetryGetArgs : Pulumi.ResourceArgs
    {
        [Input("acceptedRouteCount")]
        public Input<int>? AcceptedRouteCount { get; set; }

        [Input("lastStatusChange")]
        public Input<string>? LastStatusChange { get; set; }

        [Input("outsideIpAddress")]
        public Input<string>? OutsideIpAddress { get; set; }

        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("statusMessage")]
        public Input<string>? StatusMessage { get; set; }

        public VpnConnectionVgwTelemetryGetArgs()
        {
        }
    }
}
