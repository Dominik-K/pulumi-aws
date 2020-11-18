// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppMesh.Inputs
{

    public sealed class VirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The TLS validation context trust for an AWS Certificate Manager (ACM) certificate.
        /// </summary>
        [Input("acm")]
        public Input<Inputs.VirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustAcmArgs>? Acm { get; set; }

        /// <summary>
        /// The TLS validation context trust for a local file.
        /// </summary>
        [Input("file")]
        public Input<Inputs.VirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustFileArgs>? File { get; set; }

        public VirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustArgs()
        {
        }
    }
}
