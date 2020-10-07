// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppMesh.Inputs
{

    public sealed class VirtualNodeSpecBackendVirtualServiceGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The client policy for the backend.
        /// </summary>
        [Input("clientPolicy")]
        public Input<Inputs.VirtualNodeSpecBackendVirtualServiceClientPolicyGetArgs>? ClientPolicy { get; set; }

        /// <summary>
        /// The name of the virtual service that is acting as a virtual node backend.
        /// </summary>
        [Input("virtualServiceName", required: true)]
        public Input<string> VirtualServiceName { get; set; } = null!;

        public VirtualNodeSpecBackendVirtualServiceGetArgs()
        {
        }
    }
}
