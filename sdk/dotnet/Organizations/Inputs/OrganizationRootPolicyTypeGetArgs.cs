// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Organizations.Inputs
{

    public sealed class OrganizationRootPolicyTypeGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The status of the policy type as it relates to the associated root
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("type")]
        public Input<string>? Type { get; set; }

        public OrganizationRootPolicyTypeGetArgs()
        {
        }
    }
}
