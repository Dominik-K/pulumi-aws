// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.WafV2.Inputs
{

    public sealed class WebAclRuleStatementOrStatementStatementNotStatementStatementNotStatementArgs : Pulumi.ResourceArgs
    {
        [Input("statements", required: true)]
        private InputList<Inputs.WebAclRuleStatementOrStatementStatementNotStatementStatementNotStatementStatementArgs>? _statements;

        /// <summary>
        /// The statement to negate. You can use any statement that can be nested. See Statement above for details.
        /// </summary>
        public InputList<Inputs.WebAclRuleStatementOrStatementStatementNotStatementStatementNotStatementStatementArgs> Statements
        {
            get => _statements ?? (_statements = new InputList<Inputs.WebAclRuleStatementOrStatementStatementNotStatementStatementNotStatementStatementArgs>());
            set => _statements = value;
        }

        public WebAclRuleStatementOrStatementStatementNotStatementStatementNotStatementArgs()
        {
        }
    }
}
