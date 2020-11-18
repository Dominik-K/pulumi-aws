// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppMesh.Inputs
{

    public sealed class VirtualGatewaySpecListenerTlsCertificateArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// An AWS Certificate Manager (ACM) certificate.
        /// </summary>
        [Input("acm")]
        public Input<Inputs.VirtualGatewaySpecListenerTlsCertificateAcmArgs>? Acm { get; set; }

        /// <summary>
        /// A local file certificate.
        /// </summary>
        [Input("file")]
        public Input<Inputs.VirtualGatewaySpecListenerTlsCertificateFileArgs>? File { get; set; }

        public VirtualGatewaySpecListenerTlsCertificateArgs()
        {
        }
    }
}
