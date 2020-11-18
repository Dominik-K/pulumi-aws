// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Dlm.Inputs
{

    public sealed class LifecyclePolicyPolicyDetailsScheduleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Copy all user-defined tags on a source volume to snapshots of the volume created by this policy.
        /// </summary>
        [Input("copyTags")]
        public Input<bool>? CopyTags { get; set; }

        /// <summary>
        /// See the `create_rule` block. Max of 1 per schedule.
        /// </summary>
        [Input("createRule", required: true)]
        public Input<Inputs.LifecyclePolicyPolicyDetailsScheduleCreateRuleArgs> CreateRule { get; set; } = null!;

        /// <summary>
        /// A name for the schedule.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// See the `retain_rule` block. Max of 1 per schedule.
        /// </summary>
        [Input("retainRule", required: true)]
        public Input<Inputs.LifecyclePolicyPolicyDetailsScheduleRetainRuleArgs> RetainRule { get; set; } = null!;

        [Input("tagsToAdd")]
        private InputMap<string>? _tagsToAdd;

        /// <summary>
        /// A map of tag keys and their values. DLM lifecycle policies will already tag the snapshot with the tags on the volume. This configuration adds extra tags on top of these.
        /// </summary>
        public InputMap<string> TagsToAdd
        {
            get => _tagsToAdd ?? (_tagsToAdd = new InputMap<string>());
            set => _tagsToAdd = value;
        }

        public LifecyclePolicyPolicyDetailsScheduleArgs()
        {
        }
    }
}