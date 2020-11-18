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
    public sealed class WebAclRuleStatementNotStatementStatementOrStatementStatementAndStatement
    {
        /// <summary>
        /// The statements to combine with `AND` logic. You can use any statements that can be nested. See Statement above for details.
        /// </summary>
        public readonly ImmutableArray<Outputs.WebAclRuleStatementNotStatementStatementOrStatementStatementAndStatementStatement> Statements;

        [OutputConstructor]
        private WebAclRuleStatementNotStatementStatementOrStatementStatementAndStatement(ImmutableArray<Outputs.WebAclRuleStatementNotStatementStatementOrStatementStatementAndStatementStatement> statements)
        {
            Statements = statements;
        }
    }
}
