// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.StorageGateway.Inputs
{

    public sealed class GatewaySmbActiveDirectorySettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the domain that you want the gateway to join.
        /// </summary>
        [Input("domainName", required: true)]
        public Input<string> DomainName { get; set; } = null!;

        /// <summary>
        /// The password of the user who has permission to add the gateway to the Active Directory domain.
        /// </summary>
        [Input("password", required: true)]
        public Input<string> Password { get; set; } = null!;

        /// <summary>
        /// The user name of user who has permission to add the gateway to the Active Directory domain.
        /// </summary>
        [Input("username", required: true)]
        public Input<string> Username { get; set; } = null!;

        public GatewaySmbActiveDirectorySettingsArgs()
        {
        }
    }
}
