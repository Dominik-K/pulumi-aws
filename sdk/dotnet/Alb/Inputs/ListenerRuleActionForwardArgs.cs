// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Alb.Inputs
{

    public sealed class ListenerRuleActionForwardArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The target group stickiness for the rule.
        /// </summary>
        [Input("stickiness")]
        public Input<Inputs.ListenerRuleActionForwardStickinessArgs>? Stickiness { get; set; }

        [Input("targetGroups", required: true)]
        private InputList<Inputs.ListenerRuleActionForwardTargetGroupArgs>? _targetGroups;

        /// <summary>
        /// One or more target groups block.
        /// </summary>
        public InputList<Inputs.ListenerRuleActionForwardTargetGroupArgs> TargetGroups
        {
            get => _targetGroups ?? (_targetGroups = new InputList<Inputs.ListenerRuleActionForwardTargetGroupArgs>());
            set => _targetGroups = value;
        }

        public ListenerRuleActionForwardArgs()
        {
        }
    }
}
