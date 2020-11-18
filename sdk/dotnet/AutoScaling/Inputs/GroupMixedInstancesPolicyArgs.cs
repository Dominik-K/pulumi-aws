// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AutoScaling.Inputs
{

    public sealed class GroupMixedInstancesPolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Nested argument containing settings on how to mix on-demand and Spot instances in the Auto Scaling group. Defined below.
        /// </summary>
        [Input("instancesDistribution")]
        public Input<Inputs.GroupMixedInstancesPolicyInstancesDistributionArgs>? InstancesDistribution { get; set; }

        /// <summary>
        /// Nested argument containing launch template settings along with the overrides to specify multiple instance types and weights. Defined below.
        /// </summary>
        [Input("launchTemplate", required: true)]
        public Input<Inputs.GroupMixedInstancesPolicyLaunchTemplateArgs> LaunchTemplate { get; set; } = null!;

        public GroupMixedInstancesPolicyArgs()
        {
        }
    }
}
