// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.WafV2.Outputs
{

    [OutputType]
    public sealed class WebAclRuleStatementRuleGroupReferenceStatementExcludedRule
    {
        /// <summary>
        /// The name of the rule to exclude. If the rule group is managed by AWS, see the [documentation](https://docs.aws.amazon.com/waf/latest/developerguide/aws-managed-rule-groups-list.html) for a list of names in the appropriate rule group in use.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private WebAclRuleStatementRuleGroupReferenceStatementExcludedRule(string name)
        {
            Name = name;
        }
    }
}
