// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.GuardDuty.Inputs
{

    public sealed class FilterFindingCriteriaArgs : Pulumi.ResourceArgs
    {
        [Input("criterions", required: true)]
        private InputList<Inputs.FilterFindingCriteriaCriterionArgs>? _criterions;
        public InputList<Inputs.FilterFindingCriteriaCriterionArgs> Criterions
        {
            get => _criterions ?? (_criterions = new InputList<Inputs.FilterFindingCriteriaCriterionArgs>());
            set => _criterions = value;
        }

        public FilterFindingCriteriaArgs()
        {
        }
    }
}
