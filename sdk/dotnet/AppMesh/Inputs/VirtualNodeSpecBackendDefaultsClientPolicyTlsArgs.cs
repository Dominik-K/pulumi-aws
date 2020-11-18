// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppMesh.Inputs
{

    public sealed class VirtualNodeSpecBackendDefaultsClientPolicyTlsArgs : Pulumi.ResourceArgs
    {
        [Input("enforce")]
        public Input<bool>? Enforce { get; set; }

        [Input("ports")]
        private InputList<int>? _ports;

        /// <summary>
        /// One or more ports that the policy is enforced for.
        /// </summary>
        public InputList<int> Ports
        {
            get => _ports ?? (_ports = new InputList<int>());
            set => _ports = value;
        }

        /// <summary>
        /// The TLS validation context.
        /// </summary>
        [Input("validation", required: true)]
        public Input<Inputs.VirtualNodeSpecBackendDefaultsClientPolicyTlsValidationArgs> Validation { get; set; } = null!;

        public VirtualNodeSpecBackendDefaultsClientPolicyTlsArgs()
        {
        }
    }
}
