// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Dlm.Outputs
{

    [OutputType]
    public sealed class LifecyclePolicyPolicyDetails
    {
        /// <summary>
        /// A list of resource types that should be targeted by the lifecycle policy. `VOLUME` is currently the only allowed value.
        /// </summary>
        public readonly ImmutableArray<string> ResourceTypes;
        /// <summary>
        /// See the `schedule` configuration block.
        /// </summary>
        public readonly ImmutableArray<Outputs.LifecyclePolicyPolicyDetailsSchedule> Schedules;
        /// <summary>
        /// A map of tag keys and their values. Any resources that match the `resource_types` and are tagged with _any_ of these tags will be targeted.
        /// </summary>
        public readonly ImmutableDictionary<string, string> TargetTags;

        [OutputConstructor]
        private LifecyclePolicyPolicyDetails(
            ImmutableArray<string> resourceTypes,

            ImmutableArray<Outputs.LifecyclePolicyPolicyDetailsSchedule> schedules,

            ImmutableDictionary<string, string> targetTags)
        {
            ResourceTypes = resourceTypes;
            Schedules = schedules;
            TargetTags = targetTags;
        }
    }
}
