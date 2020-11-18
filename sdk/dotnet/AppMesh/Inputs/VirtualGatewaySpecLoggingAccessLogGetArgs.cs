// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppMesh.Inputs
{

    public sealed class VirtualGatewaySpecLoggingAccessLogGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The file object to send virtual gateway access logs to.
        /// </summary>
        [Input("file")]
        public Input<Inputs.VirtualGatewaySpecLoggingAccessLogFileGetArgs>? File { get; set; }

        public VirtualGatewaySpecLoggingAccessLogGetArgs()
        {
        }
    }
}
