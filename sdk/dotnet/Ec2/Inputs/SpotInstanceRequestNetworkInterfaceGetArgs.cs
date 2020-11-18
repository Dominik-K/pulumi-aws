// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2.Inputs
{

    public sealed class SpotInstanceRequestNetworkInterfaceGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether or not to delete the network interface on instance termination. Defaults to `false`. Currently, the only valid value is `false`, as this is only supported when creating new network interfaces when launching an instance.
        /// </summary>
        [Input("deleteOnTermination")]
        public Input<bool>? DeleteOnTermination { get; set; }

        /// <summary>
        /// The integer index of the network interface attachment. Limited by instance type.
        /// </summary>
        [Input("deviceIndex", required: true)]
        public Input<int> DeviceIndex { get; set; } = null!;

        /// <summary>
        /// The ID of the network interface to attach.
        /// </summary>
        [Input("networkInterfaceId", required: true)]
        public Input<string> NetworkInterfaceId { get; set; } = null!;

        public SpotInstanceRequestNetworkInterfaceGetArgs()
        {
        }
    }
}
