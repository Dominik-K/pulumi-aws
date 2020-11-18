// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppMesh.Inputs
{

    public sealed class VirtualNodeSpecListenerPortMappingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The port used for the port mapping.
        /// </summary>
        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        /// <summary>
        /// The protocol used for the port mapping. Valid values are `http`, `http2`, `tcp` and `grpc`.
        /// </summary>
        [Input("protocol", required: true)]
        public Input<string> Protocol { get; set; } = null!;

        public VirtualNodeSpecListenerPortMappingArgs()
        {
        }
    }
}