// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Dlm.Inputs
{

    public sealed class LifecyclePolicyPolicyDetailsGetArgs : Pulumi.ResourceArgs
    {
        [Input("resourceTypes", required: true)]
        private InputList<string>? _resourceTypes;

        /// <summary>
        /// A list of resource types that should be targeted by the lifecycle policy. `VOLUME` is currently the only allowed value.
        /// </summary>
        public InputList<string> ResourceTypes
        {
            get => _resourceTypes ?? (_resourceTypes = new InputList<string>());
            set => _resourceTypes = value;
        }

        [Input("schedules", required: true)]
        private InputList<Inputs.LifecyclePolicyPolicyDetailsScheduleGetArgs>? _schedules;

        /// <summary>
        /// See the `schedule` configuration block.
        /// </summary>
        public InputList<Inputs.LifecyclePolicyPolicyDetailsScheduleGetArgs> Schedules
        {
            get => _schedules ?? (_schedules = new InputList<Inputs.LifecyclePolicyPolicyDetailsScheduleGetArgs>());
            set => _schedules = value;
        }

        [Input("targetTags", required: true)]
        private InputMap<string>? _targetTags;

        /// <summary>
        /// A map of tag keys and their values. Any resources that match the `resource_types` and are tagged with _any_ of these tags will be targeted.
        /// </summary>
        public InputMap<string> TargetTags
        {
            get => _targetTags ?? (_targetTags = new InputMap<string>());
            set => _targetTags = value;
        }

        public LifecyclePolicyPolicyDetailsGetArgs()
        {
        }
    }
}
